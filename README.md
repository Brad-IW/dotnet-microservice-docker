# DotNET Microservice Docker

## Installation Guide

This guide assumes that [Docker](https://docs.docker.com/get-docker/) has already been installed and initialised. 

1. Clone this repo and extract the files.
2. Open a terminal and navigate to the dotnet-microservice-docker folder.
3. Run `docker compose up` 
    
    Once the compose file has finished its start up procedure the API will be accessible from `localhost:5000`. 
    
4. After ensuring that the container has built and ran successfully, type `CTRL + C` or `COMMAND + C` on Linux and Mac into your terminal to stop the containers.
5. Run `docker compose up -d` to run the container in the background.

## Test Plan

This optional test plan will take you through the process of using the DotNET Microservice Web API. The plan assumes that the actions below are performed on a local machine running the docker containers, however this can easily be changed by swapping all instances of localhost to the ip address of the machine running docker. These tests are designed with the use of [Postman](https://www.postman.com/) in mind.

1. Open Postman and create a new GET request.
2. Enter `localhost:5000/api/hello` as the url.
3. Press the send button.

    After completing these steps the API should return with Hello!

4. Change the url to `localhost:5000/api/hello/:name` to add a name variable.
5. In the path variables set name to your name.
6. Press the send button.

    With this the API will response with Hello followed by your name.