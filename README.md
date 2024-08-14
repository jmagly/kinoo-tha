# Kibeam Interview Take Home Assignment

## Objective

The goal of this assignment is to assess your ability to work with data structures and demonstrate your proficiency in transforming data from one format to another. You will be provided with a CSV file containing real world data events from our device data. Your task is to convert this data into another structured format of your choice (e.g., JSON, YAML, TOML, XML) and ensure that the resulting structure is well-formed and usable.

The end goal of this data structure will be to send it off to another service that will ingest all this data and process it into a RedShift database; which will be the goal of our in person coding exercise!

## Requirements

### Input Data

* You will receive a CSV file containing rows of event data.
* The CSV file will include various columns with data types such as strings, integers, dates, and possibly nested structures (e.g., serialized JSON strings).

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

* Your solution should gracefully handle any potential errors, such as malformed CSV data or data type mismatches.
* Implement validation checks to ensure the integrity of the transformed data.
* Provide appropriate error messages or logging for any issues encountered during the transformation process.

### Performance Considerations

* The solution should be efficient and capable of handling large CSV files with minimal performance degradation.
* Document any assumptions made about the size of the data or performance trade-offs.

### Code Requirements

* Your solution can be implemented using C# and .NET Core. You can also use any other language or tool that you feel can accomplish the same goal in a clearer manor. Please be ready to explain why you chose the language and solution that you did though. Acceptable languages or tools would include, but are not limited to: JavaScript, TypeScript, Ruby, Python, jq.
* The code should be well-organized, modular, and follow best practices for software development (e.g., SOLID principles, appropriate use of design patterns).
* Include comments and documentation to explain your code and the decisions you made.

### Deliverables

* The source code for the solution, including any necessary dependencies.
* A brief README file that explains how to run your solution, any assumptions made, and any known limitations.
* The transformed data file in the chosen format.
* Optional: Include unit tests to demonstrate the correctness of your solution.

### Evaluation Criteria

* Correctness: Does the solution accurately transform the data as specified?
* Code Quality: Is the code clean, well-organized, and adheres to best practices?
* Performance: Does the solution efficiently handle the provided data?
* Error Handling: Are potential errors managed appropriately?
* Documentation: Is the README clear and informative?

### Submission Instructions

* Please create a branch in the provided repository in the format of `/interview/[first-last]`
* When you're ready, please submit a pull request with your implemented solution.
* Ensure that all code and deliverables are included and clearly organized. If you need to clarify anything, please do so in your pull request.

### Deadline

The assignment is due by 7 days from the time you receive it. Please ensure that you manage your time effectively to meet this deadline.

### Note

This assignment is designed to be completed independently. We encourage you to use any resources you need (e.g., documentation, online resources), but the work submitted must be your own.

Good luck, and we look forward to reviewing your submission!

