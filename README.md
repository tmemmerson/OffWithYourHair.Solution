**<h1 align = "center"> EAU CLAIRE'S HAIR & HEAD REMOVAL SALON**


<h1 align="center">
  <img width="900" height="499" src="https://coding-assets.s3-us-west-2.amazonaws.com/img/eau-claires-hero.png">
</h1>

**<h1 align="center">"OFF WITH YOUR HAIR"**


**<h4 align = "center">
  <a href="#✅requirements">Requirements</a> •
  <a href="#💻setup">Setup</a> •
  <a href="#🔧protecting-your-data">Protecting Data</a> •
  <a href="#📫questions-and-concerns">Q's & C's</a> •
  <a href="#🔧technologies-used">Technologies</a> •
  <a href="#🐛bugs">Bugs</a> •  
  <a href="#❤️contributors">Contributors</a> •
  <a href="#📘license">License</a>**

<br>
<h2 align = "center">

**ABOUT**

</p>

_Eau Claire seems to have lost her database and her head. She is in need of a database management system to collect client and stylist information. Clients are allowed one stylist, while stylists are allowed multiple clients. Claire has asked us to write a new application to allow her to track and view all her stylists, their details, their associated clients, as well as update and add information to those individuals' records._


## **✅REQUIREMENTS**

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)


## **💻SETUP**


copy this url to clone this project to your local system:
```html
https://github.com/tmemmerson/OffWithYourHair.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

With the project open to the root directory, navigate to the production directory with the following command in your terminal.
```js 
cd ProjectName
```

Then, install the necessary packages with the following command
```js 
dotnet restore 
```

Finally, you can start the program with this command.
```js 
dotnet run 
``` 

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/dotnet-readme.gif "How to clone repo")


#### **Copy and paste this code snippet into the query field in MySql Workbench. Then execute w/ Control+Shift+Enter.**

```cs
CREATE DATABASE `hair_salon` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Note` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```
## **🔧PROTECTING YOUR DATA**

#### **Step 1: From within VSCode in the root project directory, we will create a .gitignore file**

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/mac-pass-sm.png)
```js 
touch .gitignore 
```

# For ![l-top](https://github.com/ryanoasis/nerd-fonts/wiki/screenshots/v1.0.x/windows-pass-sm.png)

```js 
ni .gitignore 
```

#### Step 2: commit that .gitignore file (this prevents your sensitive information from being shown to others). **⚠️DO NOT PROCEED UNTIL YOU DO!⚠️**

![setup](https://coding-assets.s3-us-west-2.amazonaws.com/img/entity-readme-image.png "Set up instructions")

#### Step 3: **To commit your .gitignore file enter the following commands**

```js
git add .gitignore
```
```js
git commit -m "protect data"
```

#### Step 4: **Then, you need to update your username and password in the appsettings.json file.**

_by default these are set to user:root and an empty password. if you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)

<br>

## **📫QUESTIONS AND CONCERNS**

_Questions, comments and concerns can be directed to the author [Tristan Emmerson](tristan@stickerslug.com)_

<br>

## **🔧Technologies Used**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

<br>


## **🐛Known Bugs**

_**None as of:** 7/30/2020_

<br>


## **❤️Contributors**

| [<img src="https://coding-assets.s3-us-west-2.amazonaws.com/img/tristan_emmerson.jpg" width="160px;"/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br /> |
| :-----------------------------------------------------------------------------------------------------------------------------------------------------------------: |

<br>

## **📘License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Tristan Emmerson, Stickerslug Inc._**

