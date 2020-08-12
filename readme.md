# GPA Calculator

## Overview

This application is meant to be used by individuals who want a simple tool to
calculate their GPA.

### Features

This application aims to provide following functionalities.

1. Calculate and show GPA based on the courses and the outcome the user entered
2. Allow the user to select the courses they have taken from a provided list
3. Save the entered data so that the user does not have to enter their data
   again

### Structure

There are mainly 4 parts that contribute to this application.

#### Course and GradeEntry

`Course` and `GradeEntry` are the driving data of this application. `Course`s
are provided by the application, while `GradeEntry`s are meant to be modified by
the user. However, `Grade` field is the only modifiable part.

Below is the structure of `Course` and `GradeEntry`. `GradeEntry` inherits from
`Course`.

```
Course
├ Code     : string
├ Name     : string
└ Semester : (Year, Season)

GradeEntry
├ Code     : string         (inherited)
├ Name     : string         (inherited)
├ Semester : (Year, Season) (inherited)
└ Grade    : int (0-100)
```

#### DataList

`DataList<T>` is a generic class that is a list with change events. It
implements `IBindingList` that facilitates updating `DataGridView` as the stored
data is changed.

#### Main Form

This is the main window of the application where the user can edit their grades
and see the calculated GPA. They can also save and load grade entries.

#### Course List (Secondary Form)

This is where the list of provided courses is shown. The user can filter the
list using controls for search. Courses that are already in the grade entries is
not shown in order to prevent duplicate entries. There can be at most one course
list window that is open at a moment.

### Executing the Application

If the application reports an error with `FileNotFoundException`, you need to
copy `Courses.json` file into the directory where the executable file is
located. It is typically in `<Project Folder>\GPACalculator\bin\Debug`.

## Tasks

- [ ] Spash screen
- [ ] Main form with (4/6)
  - [ ] At least six among the following (3/6)
    - [X] Button
    - [X] Label
    - [ ] Text Box
    - [ ] Radio Button
    - [ ] Check Box
    - [ ] Tab Control
    - [ ] Picture Box
    - [ ] Table Layout
    - [X] Flow Layout
  - [X] At least one of (1/1)
    - [ ] List Box
    - [X] Combo Box
    - [ ] Tree View
  - [ ] At least two of (1/2)
    - [ ] Dictionary
    - [ ] Queue
    - [ ] Stack
    - [ ] Linked List
    - [X] List
  - [X] DataGridView with data
        Course list in secondary form
  - [X] Data read in from a JSON, XML, or text file
        Read in from JSON file (`Courses.json`)
  - [X] Able to add/remove/modify data
        Grade entry list is able to be modified at run time
- [X] Secondary form that has some data sent to and received from the main form
      1. Grade entry list (in order to filter out courses already in the entry
         list)
      2. Form closing event (so that the main form clears the reference to the
         secondary form)
- [ ] At least 24 items
- [X] Own generic method or class
      `DataList<T>`: provides updates for any changes made to the grade entry
                     list
