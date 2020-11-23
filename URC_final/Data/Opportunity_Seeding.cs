﻿/**
 *
  Author:    Daniel Pak & Kyungyoon Kim
  Date:      Sep 23th, 2020
  Course:    CS 4540, University of Utah, School of Computing
  Copyright: CS 4540, Kyungyoon Kim and Daniel Pak - This work may not be copied for use in Academic Coursework.

  We, Kyungyoon Kim and Daniel Pak, certify that I wrote this code from scratch and did not copy it in part or whole from
  another source.  Any references used in the completion of the assignment are cited in my README file.

  File Contents

     Opportunity_Seeding

 */

using System;
using URC_final.Models;

namespace URC_final.Data
{
    public static class Opportunity_Seeding
    {
        public static void GenerateSeed(URC_final_Context context)
        {
            var opportunites = new Opportunity[]
            {
                new Opportunity
                {
                    ProjectName = "Health Education, Health Communication, and Health Policy Research",
                    ProfessorName = "Jessica King",
                    ProfessorEmail = "professor@utah.edu",
                    Department = "Health, Kinesiology, and Recreation",
                    Description = "Health education and health policy research projects in tobacco regulatory science, more specifically e-cigarettes/vaping.",
                    AssociatedImag = "",
                    StudentMentor = "Danny Lim",
                    BeginningDate = DateTime.Parse("2020-09-30"),
                    EndDate = DateTime.Parse("2019-10-11"),
                    Pay = "$20 per hour",
                    Filled = false,
                    RequiredSkills="Health Education, Health Communication, Health Policy",
                    SearchTags="Health, Health policy, Health system, Tobacco"
                },

                new Opportunity
                {
                    ProjectName = "Urban Ecology: Water use of alternative groundcover species in the Red Butte Garden",
                    ProfessorName = "Diane Pataki",
                    ProfessorEmail = "professor_mary@utah.edu",
                    Department = "Biology",
                    Description = "This is a study of the evapotranspiration of ground cover plant species that are proposed as alternatives to turfgrass lawns. The project involves analyzing data previously collected at Red Butte Gardens. Some additional field work at Red Butte will probably be needed. The results will be used to determine which species require less water for irrigation than turfgrass, and will inform water conservation policies and practices..",
                    AssociatedImag = "",
                    StudentMentor = "Danny Lim",
                    BeginningDate = DateTime.Parse("2020-09-29"),
                    EndDate = DateTime.Parse("2019-10-12"),
                    Pay = "$19 per hour",
                    Filled = false,
                    RequiredSkills="Urban Ecology",
                    SearchTags="Urban, Ecology"
                },

                new Opportunity
                {
                    ProjectName = "City Climate Change Research Assistant",
                    ProfessorName = "Devon Cantwell",
                    ProfessorEmail = "u1148861@utah.edu",
                    Department = "Political Science",
                    Description = "I am analyzing city climate action plans across the world and trying to find key themes, characteristics, and patterns of these climate action plans. Specifically, I will be focusing on Ho Chi Minh City, Buenos Aires, Seoul, and Mexico City, but will also be looking at other city environmental actions as needed for this project.",
                    AssociatedImag = "",
                    StudentMentor = "Danny Lim",
                    BeginningDate = DateTime.Parse("2020-09-11"),
                    EndDate = DateTime.Parse("2019-10-12"),
                    Pay = "$18 per hour",
                    Filled = false,
                    RequiredSkills="Political Science",
                    SearchTags="Politics, climate"
                },

                new Opportunity
                {
                    ProjectName = "Undergraduate researchers for a study on Campus Intimate Partner Violence",
                    ProfessorName = "Heather Melton",
                    ProfessorEmail = "heather.melton@soc.utah.edu",
                    Department = "Sociology",
                    Description = "“How College Students Describe and Experience Intimate Partner Violence: A University of Utah Landscape Study” is a year-long study that includes an inventory of educational practices, policy and practice analysis, observations, focus groups, walking interviews, and staff interviews. It seeks to understand the landscape of all on campus around intimate personal violence, particularly students with minoritized identities. Work under grad students & faculty project investigators (Drs. Linder, Melton, & Richards)",
                    AssociatedImag = "",
                    StudentMentor = "Danny Lim",
                    BeginningDate = DateTime.Parse("2020-09-11"),
                    EndDate = DateTime.Parse("2019-10-12"),
                    Pay = "$17 per hour",
                    Filled = false,
                    RequiredSkills="Sociology",
                    SearchTags="Sociology, Violence "
                },

                new Opportunity
                {
                    ProjectName = "Understanding disease susceptibility at the interface of developmental biology, stem cell biology, and immunology",
                    ProfessorName = "Anna Beaudin",
                    ProfessorEmail = "anna.beaudin@hsc.utah.edu",
                    Department = "Internal Medicine",
                    Description = "The Beaudin lab is broadly interested in how early life parameters, such as infection or nutrition, shape the establishment and trajectory of the immune system from hematopoietic, or blood, stem cells.",
                    AssociatedImag = "",
                    StudentMentor = "Danny Lim",
                    BeginningDate = DateTime.Parse("2020-09-11"),
                    EndDate = DateTime.Parse("2019-10-12"),
                    Pay = "$17 per hour",
                    Filled = false,
                    RequiredSkills="Medical science",
                    SearchTags="Medicine, life, nutrition"
                }
            };


            

            context.Opportunities.AddRange(opportunites);
            context.SaveChanges();
        }
    }
}