B2B Kafka feed
==============

## Base requirements
* net 6.0

### Set up project
* [install docker](https://docs.docker.com/engine/install/)
* [install docker-compose](https://docs.docker.com/compose/install/)

### Docker Compose
* Build all containers: `docker-compose build`
* Run one container: `docker-compose run --rm <service-name>`
* Run all php consumers `docker-compose up -d`

### Development
```bash
# Add application settings 
  "EventSettings": {
    "Server": "",
    "Key": "",
    "Secret": "",
    "Topic": "",
    "GroupId": ""
  },
  "MarketSettings": {
    "Server": "",
    "Key": "",
    "Secret": "",
    "Topic": "",
    "GroupId": ""
  }
  
# Launch container
docker-compose run --rm <service-name> bash

# Inside the container
cd /var/www/app && composer install
bin/console $BUILDER_TYPE --break
```
