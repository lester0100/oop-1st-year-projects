<h1>Object-Oriented Programming: College Projects (1st Year)</h1>

This repository contains several C# projects I created during my first year of college for the Object-Oriented Programming course.
<br/><br/>

**Table of Contents**
- Project 1: Windows Forms Suite
- Project 2: Vaccination Registration Form
- Project 3: Save/Open Dialogs & Loader Demo
- Project 4: File Handling & Record Update Demo
<br/><br/>

**Project 1: Windows Forms Suite (MainForm and Program1 to Program5)**

This Windows Forms application consists of six forms: one Main Form that links to five smaller forms. I built this project for the Object-Oriented Programming course to practice Windows Forms UI, event handling, basic business logic, and input validation in C#.

- Program 1: Net Income Calculator - This program calculates net income by subtracting deductions from gross income, including income tax, SSS, and MI. The result is shown, and you can't edit the fields until you clear them.


- **Program 2: Circle Circumference** - You enter a radius, and the program calculates the circumference using the formula 2 × π × radius (with π approximated as 3.1416). The result appears, and the input is locked until you clear it.

- **Program 3: Final Price (with tax)** - This program takes an initial price and a tax rate (as a multiplier), then calculates the tax and adds it to the price to display the final amount. After calculating, the inputs are disabled until you clear them.



- **Program 4: Net Salary** - This program receives a gross salary and applies a tiered deduction: 10% if the amount exceeds $1,000, otherwise 5%. It displays the net salary and disables input until the field is cleared.



- **Program 5: Gross Pay (overtime)** - This program accepts an hourly rate and the number of hours worked, then calculates the gross pay using a 1.5 multiplier when the hours exceed 40 (applied to all hours in this version). It displays the pay and locks inputs until you clear them.



**Key Features**

  → All forms display results in a label (lblResult) and have a Clear button to reset fields and re-enable inputs.
  
  → Navigation: MainForm opens each ProgramX form using .Show() and hides itself with .Hide(). Program forms can also be moved to adjacent forms or returned to the MainForm. Some forms have an Application.Exit() button.
  
  → Validation (applies to all programs): Each form checks for empty fields and uses double.TryParse to make sure inputs are numbers. If input is empty or invalid, a MessageBox appears and the textbox is selected for correction. Inputs are disabled after a successful calculation.
  
  → Inputs are disabled after a successful calculation to prevent accidental changes. The Clear button resets the UI. For stricter business logic, you could add rules like checking for positive numbers, using decimals for money, or applying overtime only to hours over 40.
<hr/>

**Project 2: Vaccination Registration Form**

This project is a Windows Forms (C#) app for collecting user information and vaccination appointment details. As you fill out each field, the next one unlocks. A progress bar tracks your progress, and clicking Submit opens a confirmation dialog to finish, reset, or exit.

**Key Features**

- The form unlocks each field in order: first name, last name, sex, contact or age, email, birth date, address, calendar, and location. The progress bar updates as you complete each step.
- When you click Submit, the form summarizes your information and asks you to confirm with Yes, No, or Cancel. Yes completes the process and shows a notification, No resets the form, and Cancel closes the app.
- The form checks that the first name, last name, contact, email, address, and location are filled in. If any are empty, it highlights the missing field.
- The form does not accept fields with only numbers for name, email, address, or location. If you enter only numbers, it highlights and selects that box.
- The contact field uses a MaskedTextBox to check the format. If the input is incorrect, the form responds, for example, by enabling the date picker when it is ready.
- Tooltips guide you on the main actions: Submit, Clear, and Exit. Clear resets the form, and Exit closes the app.
<hr/>


**Project 3: Save/Open Dialogs & Loader Demo**

This Windows Forms (C#) demo features an animated loader that advances a ProgressBar, then opens a utility form for uploading and saving images and RTF text. The loader moves labels and shows a Start button when done. The utility form uses standard dialogs, context menus, tooltips, and NotifyIcon feedback for common file tasks.

**Key Features**
- The loader runs a four-stage animation that moves two labels and updates a ProgressBar. The Start button becomes active only when the animation finishes.
- Image upload uses OpenFileDialog with image filters to load pictures into a PictureBox. Image save uses SaveFileDialog.
- Text upload loads RTF files into a RichTextBox using OpenFileDialog with an RTF filter. Text save uses SaveFileDialog, but checks that the RichTextBox is not empty before prompting. If it is empty, the user is notified.
- Right-click context menus appear only when there is content (picture or text) and offer Clear actions to safely clear the selected control.
- ToolTips explain upload and save actions. File dialogs use default extensions and filters to help you choose the right file types and avoid invalid selections.
<hr/>

Project 4: File Handling & Record Update Demo

This Windows Forms (C#) utility reads records from a Data.txt file and displays them. You can search by last name to load a record for editing. The app updates the file by writing to a temporary support file and then replacing the original file.


**Key Features**

- When the app starts, it loads and displays the contents of Data.txt. File I/O uses try/catch blocks to handle access errors.
- Typing a last name searches Data.txt line by line. When a match is found, the form fills in the FirstName and Age fields and enables the Update and Clear controls so you can edit the record.
- Update checks that required fields (last name, first name, age) are filled in, rejects names with only numbers using int.TryParse, and makes sure Age is numeric before saving changes. It updates the record by writing a support file, copying it over Data.txt, reloading the display, and notifying you.
- Clear resets the input fields and UI state. Controls stay disabled until a valid last-name match is found.
- Data and support file paths are computed relative to the running executable, so files live alongside the app.



