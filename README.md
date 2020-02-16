# ISAD251 - Database Application Development COURSEWORK 01 - CafeO Prototype Page

## Linked YouTube video (of using this database application)
[![Linked YouTube video (of the using the database application)](http://img.youtube.com/vi/CVgH_lmaZZ4/0.jpg)](http://www.youtube.com/watch?v=CVgH_lmaZZ4)
http://www.youtube.com/watch?v=CVgH_lmaZZ4

## Application Factsheet
### Background
This database driven application is a simple three tier application having a simple browser-based client, middleware coded in a server-side language of C# and a database contained in a Microsoft SQL database.  It is developed for use in a tea-room/cafe which provides the functionalities for the customer user to order the product, in addition to the admin user to create and enter details of the product for sale.  According two the requirements, only two types of product, i.e. tea and cake, are included in this application.

### Scope
Besides, the features of this application is based on the requirements listed below:
1.	A customer want to order a product.
1.	A customer want to view what have been ordered.
1.	A customer want to add more product in the current order.
1.	A customer want to remove items from the current order.
1.	An admin want to enter details of the drinks/snacks for sale.
1.	An admin want like to read the details of the drinks/snacks for sale.
1.	An admin want like to view a customer’s order(s).
1.	An admin want like to edit the details of the drinks/snacks for sale.
1.	An the admin would like to withdraw a drink/snack from sale.

### Outside the Scope
As this application is not a full system.  This minimum viable product (MVP) only impletemented the features listed above, whereas the following three features are outside of the scope of this system:
1.	Payments\
    Customer paying for their order is not required.
1.	Delivering the order\
    Customer receiving their order is not required.
1.	Other users\
    No other users with other user stories are required.

### Key Features
1. Customer user can order tea/cake.
1. Customer user can read their ordered tea/cake.
1. Customer user can add more/ remove the tea/cake in the current order.
1. Admin user can create, edit, or remove tea/cake for sale.
1. Admin user can view particular customer’s order(s).

### User Roles
Two user roles, i.e. Admin & Customer, with respective views and features are created for this application.   

### Other Features
1. User Login with input validation at client side.
1. Data input validation including business rules of the product details are adopted
1. RESTful Web services allow the other systems to access and manipulate textual representations of product data
1. Customer User Registration

## Screenshots
Following screenshots illastrate the basic features of this application.

### Admin Views & Features
For the user role Admin
#### Login page
Login the site.
<kbd>![](/screenshots/admin01LoginPage.JPG)<kbd>

#### Product Menu
Click the "Tea" or "Cake" Menu from the navigation bar to view the list of products for sale.
<kbd>![](/screenshots/admin02Menu.JPG)<kbd>

#### Create Product on Menu
Click the "Create" button to create product for sale and input details.
<kbd>![](/screenshots/admin03Create.JPG)<kbd>

#### View Product Details
Click the "Detail" button next to the product to view the details of that product.
<kbd>![](/screenshots/admin04View.JPG)<kbd>

#### Edit Product Details
Click the "Edit" button next to that product to edit the product details.
<kbd>![](/screenshots/admin05Edit.JPG)<kbd>

#### Remove Product from sale
Click the "Delete" next to the product to remove that product from sale.
<kbd>![](/screenshots/admin06Remove.JPG)<kbd>

#### View Customer Order(s)
Click the "Customer Orders" on the navigation bar.
<kbd>![](/screenshots/admin07ViewOrder.JPG)<kbd>

#### View Orders(s) of a Customer
Enter the username of the customer in the searchbox and click the "Search" button to view the order(s) of that customer.
<kbd>![](/screenshots/admin08ViewUserOrder.JPG)<kbd>

### Customer Views & Features
For the customer user

#### Home Page
Home page of the cafe containing slideshow of images which attrack customers.
<kbd>![](/screenshots/customer01Home.JPG)<kbd>

#### Product Menu (Tea/Cake)
##### Drink Menu
Click "Drink" on the navigation bar to view the Drink Menu.
<kbd>![](/screenshots/customer02Tea.JPG)<kbd>

##### Cake Menu
Click "Cake" on the navigation bar to view the Cake Menu.
<kbd>![](/screenshots/customer02Cake.JPG)<kbd>

#### Order a Product
Click "Add to order" next to the product for order.  The user can further add any product to the current order before the order completed.

##### Order Tea
<kbd>![](/screenshots/customer03OrderTea.JPG)<kbd>

##### Order Cake    
<kbd>![](/screenshots/customer03OrderCake.JPG)<kbd>

#### View Ordered Product
Click "Review Ordered Item" to view the ordered product.
<kbd>![](/screenshots/customer04ViewOrder.JPG)<kbd>

#### Withdraw Ordered Product
Click "Remove from cart" to withdraw an ordered product from current order.
<kbd>![](/screenshots/customer04WithdrawOrder.JPG)<kbd>

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for testing purposes.

### Download & Run
Download the code and open the open CafeO.csproj with Microsoft Visual Studio 2019.

### Prerequisites
* To run this code-first application, please run the "update-datebase" command in the package manager console before running the application.
* Enable the auto-update of packages.

### Testing Accounts
Application testing can be conducted by login with following two testing accounts:

#### Testing admin views and features
username: admin@cafe.com\
password: admin123

#### Testing customer views and features
username: guest@cafe.com\
password: guest123

## Built With
* [Microsoft Visual Studio](https://visualstudio.microsoft.com/vs/)
* [ASP.Net](https://dotnet.microsoft.com/apps/aspnet)
* [Entity Framework](https://docs.microsoft.com/en-us/ef/)

## Authors
* **Maidie Ho**

## Acknowledgments
* Module Leader: Dr. Shirley Atkinson
* Module Lecturer: Mr. William Pang
* Peer Review Partner: Mr. Ivan Wong

