﻿using Семестр_2_Лаба_3;
Person vasyl = new Student("Vasyl", "Vasylovych", "Vasylev", 19, 2, true);
Person yaroslavIhorovich = new Lecturer("Yaroslav", "Ihorovich", "Kornaga", 30, true);
vasyl.GetInfo();
yaroslavIhorovich.GetInfo();
Student vasyl2 = new Student("Vasyl", "Vasylovych", "Vasylev", 19, 2, true);
Lecturer yaroslavIhorovich2 = new Lecturer("Yaroslav", "Ihorovich", "Kornaga", 30, true);
vasyl2.GetAge();
vasyl2.GetPresence();
vasyl2.GetCourse();
Console.WriteLine();
yaroslavIhorovich2.GetCheckingHomeworks();
yaroslavIhorovich2.GetAge();
//Console.WriteLine(yaroslavIhorovich.ToString());
//Console.WriteLine(yaroslavIhorovich2.ToString());
//Console.WriteLine(yaroslavIhorovich2.Equals(vasyl));