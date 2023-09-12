# VsBugTest
Bug in VS2022 debug window losing visibility to object

This project/solution is a quicky demonstration of a bug in VS2022 17.7.0 and (probably through) 17.7.3

Using CSVHelper to load a dummy CSV file.  When debugging the program (breakpoint at ; after "var records..." line)
The Locals window will show this screen:
<img width="914" alt="debug screen 1" src="https://github.com/gt2847c/VsBugTest/assets/8898797/a35fafa3-862f-4434-a626-27c785bcb40e">

If you then try and use the scroll bar or even your mouse wheel to scroll down past the visible entries, the screen immediately chnages
to show the Results View with "Enumeration yielded no results" and all the entries that had been displayed disappear.

<img width="934" alt="debug screen 2" src="https://github.com/gt2847c/VsBugTest/assets/8898797/a96c222c-1306-4fed-8d5b-2fe548c4217b">

The results object is still at least partially visible as expending the Non-Public members shows data:

<img width="884" alt="debug screen 3" src="https://github.com/gt2847c/VsBugTest/assets/8898797/11f42501-1987-490a-b51d-c10dd498831b">

Added an addition section that does not use "using" statements to prevent disposal. 
