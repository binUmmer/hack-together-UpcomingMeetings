# hack-together-UpcomingMeetings

[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)

# About
This is a simple .NET Core Console App that lists all your upcoming meetings of the day from your default calendar. 

As beginner on dotNet and Graph SDK this is a basic app (that works!)

Please feel free to check it out

# Pre-requisites
The app is not a verified published app, which means you will not be able to consent to it as a normal user.
Use your administrative account which has access to Azure AD or ask your Azure AD admin to consent to the application.
The admin can consent for whole organization.  
  
Below url can be used for granting the constent  
https://login.microsoftonline.com/common/adminconsent?client_id=e19857ae-15ed-4222-b4fa-ce2388a22c3c

Note: When admin consent to the app using this url, after that the web page may show an HTTP 404 response, that can be ignored.

Also make sure the user account you use to login has Exchange Online license activated


# Screenshot
When you run the app, and successfully login with a mailbox enabled user you get an output like below:

- With meetings on the calendar
![image](https://user-images.githubusercontent.com/84803086/224236463-6dcec986-cdea-4055-a2f9-0a2bc115ecd1.png)


- When there are no events for the remaining of the day
![image](https://user-images.githubusercontent.com/84803086/224237449-71b8ea06-5229-4d5d-97c5-3b2f748d52a6.png)

# Futher learning ideas
- Present more info, like organizer, location, if its an online meeting
- Add actions, respond to organizer, email all attendees etc.
- Move presentation to web page using an MVC project
- Add more view options like daily, workweek, week, monthly view.

# Feedback
I welcome your feedback for learning and improving this project

[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)
