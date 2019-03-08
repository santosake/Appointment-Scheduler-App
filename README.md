# Appointment-Scheduler-App

This application uses C# and MySQL. 

The objective of this project was to create an appointment scheduling program for a ficticious international company
to help manage their various consultants, customers, and coordinate schedules in a time zone/region sensitive manner.
The Database ERD is already set and the program must adopt it.

Program Features:
1. Login form with error control and automatically changes all English text to Spanish if users machine's region is set to a Spanish
   speaking region.
2. Customer screen to add, edit, and delete customer records.
3. Appointment screen to add, edit, and delete appointments with associated customer.
4. Calendar with a month or weekly view.
5. Automatically adjusted appointment times based on user time zone.
6. 15 minute prior appointment alerts based on user's login time. 
7. Generate three kinds of reports; number of appointment types by month, schedule for each consultant, and number of appointments by city.
8. Track user activity recording timestamps for logins in the UserActivityRecords.txt file.
9. Various exceptions controls for all data entry fields.
