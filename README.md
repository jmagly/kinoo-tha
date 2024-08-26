# Kibeam Interview Take Home Assignment

## Objective

The goal of this assignment is to assess your ability to work with data structures and demonstrate your proficiency in transforming data from one format to another. You will be provided with a CSV file containing real world data events from our device data. 

Your task is to convert this data into another structured format of your choice (e.g., JSON, YAML, TOML, XML) and ensure that the resulting structure is well-formed and usable.

The end goal of this data structure will be to send it off to another service that will ingest all this data and process it into a RedShift database; which will be the goal of our in person coding exercise!

## Developer Notes

We want to respect your time and request that you do **not** spend more than one (1) hour on this solution. This does mean that you might have to make some different design decisions when coming up with your solution.  Please take that into account when coming up with your solution. 

If you would like to place comments in your solution for discussion during the in-person interview process, please feel free to do that.

And while we do require strong C# skills for this position, we also use many other technical tools to accomplish our tasks. Please feel free to use your most effective tool to accomplish this task with the amount of time that is allotted. This could be a simple CLI tool like `jq`. A scripting language like JavaScript, Ruby, or Python. Or you can use a static language like C# if that is what you're most comfortable with.

## Requirements

### Input Data

* You will receive a CSV file containing rows of event data.
* The CSV file will include various columns with data types such as strings, integers, dates, and possibly nested structures (e.g., serialized JSON strings).

### Input Data Validations

There is no need to do any data validation on the data. We're not trying to trick you with anything. It is great to put comments for discussion on where it is useful to keep an eye out for possible data validation issues, but it is not part of the requirements for the interview process.

### Output Data

Transform the data from the CSV format to one of the following formats of your choice:

* JSON
* YAML
* TOML
* XML

Be prepared to explain some details on why you chose the format you decide on.

### Transformation Rules

* Ensure that all data from the CSV is accurately represented in the chosen format.
* Handle any data type conversions as necessary (e.g., string to integer, string to date).
* Preserve the hierarchical structure of the data where applicable (e.g., nested objects in JSON or XML).

### Error Handling

Your solution should gracefully handle any potential errors, such as malformed CSV data or data type mismatches. 

It can simply skip any lines that could possibly cause errors. Log a message to the console.

### Performance Considerations

Please feel free to document any assumptions made about the size of the data or performance trade-offs. Or any questions or optimizations you have on possible ways to handle this differently.

### Code Requirements

* Your solution can be implemented using C# and .NET Core. You can also use any other language or tool that you feel can accomplish the same goal in a clearer manor. Please be ready to explain why you chose the language and solution that you did though. Acceptable languages or tools would include, but are not limited to: JavaScript, TypeScript, Ruby, Python, jq.
* Include comments and documentation to explain your code and the decisions you made.

### Deliverables

* The source code for the solution, including any necessary dependencies.
* A brief README file that explains how to run your solution, any assumptions made, and any known limitations.
* The transformed data file in the chosen format.

### Evaluation Criteria

We're simply looking for some code that will convert from CSV to the chosen format. The end goal is to simply have a discussion with you on the choices you make. Discuss pros and cons on any of those choices and to have a good technical discussion about other possible solutions.

### Submission Instructions

Ensure that all code and deliverables are included and clearly organized. If you need to clarify anything, please do so in the README or through text.

### Note

This assignment is designed to be completed independently. We encourage you to use any resources you need (e.g., documentation, online resources), but the work submitted must be your own.

Good luck, and we look forward to reviewing your submission!

