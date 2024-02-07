# Socialsecuritynumber App

# Test locallay:
--------------
Open termial and type: dotnet test

There are 4 test cases. You can add more or manipulate them.
In short, social security numbers contains a check digit as last digit you can check the correctness of social security number by using the Luhn algorithm and this the main logic.
Also, we add check for number of digits of social security number (10).
More info about social security numbers is here https://sv.wikipedia.org/wiki/Personnummer_i_Sverige

# Pull down and run the Docker container:
----------------------------------------
## pull the image:
docker pull islamabdeen/social-security-number-container:latest

## run the image:
docker run -i -t islamabdeen/social-security-number-container:latest

### the application will run automatically as below:
Please enter social security number:
8112189876
social security number entered is: 8112189876

result True

### run the image again to use the application again
docker run -i -t islamabdeen/social-security-number-container:latest
Please enter social security number:
8112189875
social security number entered is: 8112189875

result False