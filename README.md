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
docker run -i -t islamabdeen/social-security-number-container:latest

## This will pull (if not exist) then run the image and the application will run automatically as below:

Unable to find image 'islamabdeen/social-security-number-container:latest' locally
latest: Pulling from islamabdeen/social-security-number-container
70ba6f391a98: Already exists
373a7eec07ac: Already exists
9d34a524cc37: Already exists
5031cc584802: Already exists
bfb7937ccd29: Pull complete
b53dab47a425: Pull complete
Digest: sha256:6bc62405d8e4c672f0695b688d73230f20f31d955d53ed5d6973915e5431a67d
Status: Downloaded newer image for islamabdeen/social-security-number-container:latest
Please enter social security number:
8112189876
social security number entered is: 8112189876

result True

## run the image again and try a wrong number:
docker run -i -t islamabdeen/social-security-number-container:latest
Please enter social security number:
8112189875
social security number entered is: 8112189875

result False