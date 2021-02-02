create database UniversityManagementSystem
use  UniversityManagementSystem

--Exercise 2.1
create table Student_Info_895184(
Reg_Number varchar(20),
Student_Name varchar(30),
Branch varchar(20),
Contact_Number varchar(20),
Date_of_Birth date,
Date_of_Joining date,
Address varchar(250),
Email_id varchar(250)
);

create table Subject_Master_895184(
Subject_Code varchar(10),
Subject_Name varchar(50),
Weightage Int
);

create table Student_Marks_895184(
Reg_Number varchar(20),
Subject_Code varchar(10),
Semester Int,
Marks Int
);

create table Student_Result_895184(
Reg_Number varchar(20),
Semester Int,
GPA Int,
Is_Eligible_Scholarship char(3)
); 

--Exercise 2.2
insert into Student_Info_895184 values
('MC101301','James','MCA',9714589787,'1984-01-12','2010-07-08','No 10 South Block,Nivea','james.mca@yahoo.com'),
('BEC111402','Manio','ECE',8912457875,'1983-02-23','2011-06-25','8/12 Park View,Sieera','manioma@gmail.com'),
('BEEI101204','Mike','EI',8974567897,'1983-02-10','2010-08-25','Cross villa NY','mike.james@ymail.com'),
('MB111305','Paulson','MBA',8547986123,'1984-12-13','2010-08-08','Lake view NJ','paul.son@rediffmail.com') 
select*from Student_Info_895184

insert into Subject_Master_895184 values
('EE01DCF','DCF',30),
('EC02MUP','Microprocessor',40),
('MC06DIP','Digital Image Processing',30),
('MB03MAR','Marketing Techniques',20),
('EI05IP','Instrumentation Precision',40),
('CPSC02DS','Data Structures',40)
select*from Subject_Master_895184

insert into  Student_Marks_895184 values
('MC101301','EE01DCF',1,75),
('MC101301','EC02MUP',1,65),
('MC101301','MC06DIP',1,70),
('BEC111402','EE01DCF',1,55),
('BEC111402','EC02MUP',1,80),
('BEC111402','MC06DIP',1,60),
('BEEI101204','EE01DCF',1,85),
('BEEI101204','EC02MUP',1,78),
('BEEI101204','MC06DIP',1,80),
('BEEI101204','MB03MAR',2,75),
('BEEI101204','EI05IP',2,65),
('BEEI101204','CPSC02DS',2,75),
('MB111305','EE01DCF',1,65),
('MB111305','EC02MUP',1,68),
('MB111305','MB03MAR',2,85),
('MB111305','EI05IP',2,74),
('MB111305','CPSC02DS',2,62)
select*from Student_Marks_895184
 
 insert into Student_Result_895184 values
('MC101301',1,7.5,'Y'),
('BEC111402',1,7.1,'Y'),
('BEEI101204',1,8.3,'Y'),
('BEEI101204',2,6.9,'N'),
('MB111305',1,6.5,'N'),
('MB111305',2,6.8,'N')
select*from Student_Result_895184
