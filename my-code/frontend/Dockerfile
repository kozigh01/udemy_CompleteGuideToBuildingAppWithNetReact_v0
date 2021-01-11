FROM node:15

WORKDIR /src/frontend/app

copy app/package.json ./package.json
# run npm install

copy . .

CMD ['npm', 'start']