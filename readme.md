# GPA Calculator

## Table of Contents <!-- omit in toc -->

- [GPA Calculator](#gpa-calculator)
  - [Overview](#overview)
    - [Executing the Application](#executing-the-application)
    - [Features](#features)
    - [Structure](#structure)
      - [Course and GradeEntry](#course-and-gradeentry)
      - [DataList](#datalist)
      - [Main Form](#main-form)
      - [Course List (Secondary Form)](#course-list-secondary-form)
  - [Challenges](#challenges)
    - [Window](#window)
    - [Form Designer](#form-designer)
    - [Components](#components)
    - [`DataListView` and `DataList<T>`](#datalistview-and-datalistt)
  - [Tasks](#tasks)

## Overview

This application is meant to be used by individuals who want a simple tool to
calculate their GPA.

### Executing the Application

If the application reports an error with `FileNotFoundException`, you need to
copy `Courses.json` file into the directory where the executable file is
located. It is typically in `<Project Folder>\GPACalculator\bin\Debug`.

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

## Challenges

### Window

1. How to programmatically close a window

   ```csharp
   myForm.Close();
   ```

1. How to programmatically focus a window

   ```csharp
   myForm.Focus();
   ```

1. How to programmatically hide a window

   ```csharp
   myForm.Hide();
   ```

1. How to programmatically open a new window

   ```csharp
   MyForm myForm = new MyForm();
   myForm.ShowDialog(); // Execution flow stops here until the form is closed
   ```

### Form Designer

1. Making controls respond to resize of windows<br>
   Responsive design required a lot of knowledge of various properties the
   controls had.

1. Figuring out what `Anchors` does<br>
   `Anchors` keeps the control's borders a fixed length away from the borders
   of the window. If the value is `Top, Right`, then the top and right borders
   are kept the same length away from the top and right borders of the window.
   The left and bottom borders move around to keep the control's size the same.

1. Figuring out what `Dock` does<br>
   `Dock` provides a convenient way to make controls responsive to resize of the
   window. Especially, the value of `Fill` provides a one-click way to make the
   control expand to the full size of its parent container.

1. Figuring out how to change window title<br>
   The `Text` property of the window changes the title shown at the top.

1. Using `Margin` and `Padding`<br>
   We had to adjust `Margin` and `Padding` properties to get the optimal layout
   of the controls.

### Components

1. `Timer` and event<br>
   The event for `Timers` is called `Tick`, which is a name usually used for
   functions executed everytime in the event loop for applications. But in this
   case, the `Tick` event is acutally raised when the timer is up.

1. `OpenFileDialog`<br>
   This application needs to load a JSON file, so we needed to search for how to
   use this component.

1. `SaveFileDialog`<br>
   This application needs to save a JSON file, so we needed to search for how to
   use this component.

### `DataListView` and `DataList<T>`

1. Making `DataListView` update itself when the data changes<br>
   Implementing `IBindingList` for `DataList<T>` was very complicated.

1. Different ways to implement a method of an interface<br>
   There were some differences between the first and second methods below.

   ```csharp
   public interface IMyInterface
   {
       void FirstMethod();
       void SecondMethod();
   }

   public class MyClass : IMyInterface
   {
       // This is exposed as a public method, so it can be called anywhere.
       // When there are multiple interfaces with the same type signature
       // and the same name, this method implements all of the methods from
       // all of those interfaces.
       public void FirstMethod() { }

       // This is not exposed as a method. To call this method, you need to
       // cast this to the corresponding interface object.
       // Ex) ((MyInterface)myInstance).SecondMethod();
       // The method is only implemented for the specified interface.
       void IMyInterface.SecondMethod() { }
   }
   ```

1. Event in interface and as a property<br>
   Implementing an event in an interface as a property required a little bit of
   research. The property, unlike normal ones, required `add` and `remove`
   accessors instead of `get` and `set`.

   ```csharp
   public interface IMyInterface
   {
       event MyEventHandlerType MyEvent;
   }

   public class MyClass : IMyInterface
   {
       private MyEventHandlerType onMyEvent;

       public event MyEventHandlerType MyEvent
       {
           add
           {
               onMyEvent += value;
           }
           remove
           {
               onMyEvent -= value;
           }
       }
   }
   ```

## Tasks

- [X] Spash screen
- [ ] Main form with (5/6)
  - [X] At least six among the following (6/6)
    - [X] Button
    - [X] Label
    - [ ] Text Box
    - [ ] Radio Button
    - [X] Check Box
    - [ ] Tab Control
    - [X] Picture Box
    - [X] Table Layout
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
  - [X] DataGridView with data<br>
        Course list in secondary form
  - [X] Data read in from a JSON, XML, or text file<br>
        Read in from JSON file (`Courses.json`)
  - [X] Able to add/remove/modify data<br>
        Grade entry list is able to be modified at run time
- [X] Secondary form that has some data sent to and received from the main form
      <br>
      1. Grade entry list (in order to filter out courses already in the entry
         list)<br>
      2. Form closing event (so that the main form clears the reference to the
         secondary form)<br>
- [ ] At least 24 items (15/24)
- [X] Own generic method or class<br>
      `DataList<T>`: provides updates for any changes made to the grade entry
                     list
