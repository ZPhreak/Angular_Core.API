﻿using Angular_Core.API.DomainModels;
using Angular_Core.API.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Angular_Core.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await studentRepository.GetStudentsAsync();

            return Ok(mapper.Map<List<Student>>(students));

            //var domainModelStudents = new List<Student>();

            //foreach (var student in students)
            //{
            //    domainModelStudents.Add(new Student() 
            //    { 
            //        Id = student.Id, 
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        DateOfBirth = student.DateOfBirth,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,  
            //        Address = new Address()
            //        {
            //            Id = student.Address.Id,
            //            PhysicalAddress = student.Address.PhysicalAddress,
            //            PostalAddress = student.Address.PostalAddress,
            //        },
            //        Gender = new Gender() 
            //        { 
            //            Id = student.GenderId, 
            //            Description =  student.Gender.Description
            //        }
            //    });
            //}

            //return Ok(domainModelStudents);

        }
    }
}