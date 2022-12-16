FROM ubuntu:20.04
# Download the updated list of all the tools available so I'm getting the latest version
RUN apt-get update 
RUN apt-get install -y build-essential
WORKDIR /app
COPY src/hello.c /app/
RUN gcc -o hello hello.c
ENTRYPOINT [ "/app/hello" ]