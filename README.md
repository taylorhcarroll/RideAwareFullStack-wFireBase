# RideAwareFullStack

This is version 2 of Front-End Capstone RideAware.
This will use FireBase for authentication.
It will use SQL for database.
It will use React for FrontEnd. (possible refactor of fronEnd to hook up to BackEnd).

This will also include features for attendance record keeping.

## ERD 
table users {
  id int
  administrator false
  locationId int
  avatarURL varchar
  mapLocation varchar
}

table studentdUser {
  id int
  userId int
  primaryUser boolean
  studentId int
  expire boolean
  expireDate datetime
}

table students {
  id int
  name varchar
  teacherId int
  avatarURL varchar
}

table carUser {
  id int
  userId int
  carId int
  primaryUser boolean
  expire boolean
  expireDate datetime
}

table cars {
  id int
  make varchar
  model varchar
  color varchar
  avatarURL varchar
}

table location {
  id int
  mapLocation varchar
}

table studentRide {
  id int
  rideId int
  studentId int
}

table rides {
  id int
  userId int
  date varchar
  timeStamp varchar
  editTimeStamp varchar
  locationId int
}

table class {
  id int
  userId int
  Schedule datetime
  locationId int
}

table classStudents { 
  id Int
  classId Int
  studentId int
}

table attendenceRecord {
  id int
  date datetime
  classId int
}

table attendenceRecordStudents {
  id int
  attendenceRecordId int
  studentId int
  present bool
}

Ref: "rides"."locationId" < "location"."id"

Ref: "rides"."id" < "studentRide"."rideId"

Ref: "studentRide"."studentId" < "students"."id"

Ref: "studentdUser"."userId" < "users"."id"

Ref: "students"."id" < "studentdUser"."studentId"

Ref: "carUser"."userId" < "users"."id"

Ref: "carUser"."carId" < "cars"."id"

Ref: "class"."userId" < "users"."id"

Ref: "classStudents"."classId" < "class"."id"

Ref: "classStudents"."studentId" < "students"."id"

Ref: "class"."locationId" < "location"."id"

Ref: "attendenceRecord"."classId" < "classStudents"."classId"

Ref: "attendenceRecordStudents"."attendenceRecordId" < "attendenceRecord"."id"
