﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Business_Logic
{
    /// <summary>
    /// Enums for business logic
    /// </summary>
    public enum MemberClearance
    {
        Guest = 'g',
        Student = 's',
        Teacher = 't',
        Admin = 'a',
        Parent='p'
    }
    public enum MemberGender
    {
        Male = 'm',
        Female = 'f',
        Unknown = ' '
    }
    public enum LessonChangeType
    {
        Cancel= 'c',
        Fill= 'f',
        Test= 't',
        FinalTest = 'b',
        Unknown = 'u'
    }
}