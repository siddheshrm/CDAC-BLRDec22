# Contains instructions for the Docker Environment to load the dependencies required to run UR application. Except the OS, U have to provide all the dependencies that has to  be loaded into the container.
FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac SampleFile.java
CMD exec java SampleFile