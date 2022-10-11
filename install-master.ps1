

# stop containers


docker stop categoryapi
docker stop gateway


# remove containers


docker rm category.api
docker rm gateway


# remove images


docker rmi $(docker images 'category.api' -a -q)
docker rmi $(docker images 'gateway' -a -q)
	

docker system prune -a -af 

docker-compose --env-file .env.production up --build