# Rezare Systems / Map of Agriculture Interview Test

This repository is the template for our technical interview test.

This template contains the following:

- .Net 8.0 Web API
- Angular web application (recommend using node version 16.x or 18.x as this is Angular 16)

Each of the above projects are stubbed out and provides some extremely basic functionality.
The currently implemented features are as follows:

- List of cows on the home page
- API endpoint to return the full list of cows

We ask that you spend as much of the allotted time to do this test as you can; and start by taking a Fork of this repository.

## Your Details

Please enter/replace your details below.
| | |
| - | - |
| Name | John Smith |
| Date | 2022-03-21 |
| Start Time | 00:00+13:00 |
| Finish Time | 02:15+13:00 |

## Requirements

In order to complete this test you will need the following tools:

- Either Visual Studio or Visual Studio Code (or your favourite text editor)
- Command line for running `ng serve` and/or `dotnet run` etc
- Dotnet 8 SDK
- Node 16 or 18
- NPM

You should be able to complete this test on your choice of machine, and some technologies that we use have been deliberately left out to make this as accessible as possible.
The code in this repository will compile and run on Windows, macOS and Linux.

You may if you prefer use your preferred frontend technology, if you are unfamiliar with Angular - in which case, please note it below:  
- [ ] Using different frontend technology

## Instructions

> As you complete each item in the list below, please ensure that you mark it off by changing the `[]` to a `[x]`.
> Please ensure that you record your start and finish time (in local time, using ISO timestamps at the bottom of this README).

- [ ] Add a new field **Liveweight** and flow it through from the API to the frontend.  
- [ ] Add a page in the frontend to allow new cows to be added.  
- [ ] Add an endpoint to the API to allow cows to be added.  
- [ ] Implement the `Add` method of the `ICowService`.  
- [ ] Implement the `Delete` method of the `ICowService`.  
- [ ] Add a delete endpoint to the API.  
- [ ] Add delete functionality to the frontend.  

**Extras (if you have time):**

- [ ] Add a tooltip that provides guidance text based on the cow’s weight range when hovering over the liveweight value:  
  - Liveweight **less than 85%** of Mature Body Weight → *“Below target weight — consider checking nutrition.”*  
  - Liveweight **between 85% and 100%** of Mature Body Weight → *“On target — healthy weight range.”*  
  - Liveweight **greater than 100%** of Mature Body Weight → *“Above target weight — monitor feed and activity.”*
