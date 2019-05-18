
/*------------------------------------Nav menyn--------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

nav > li > a { /*Alla a som child till li som child till nav displayas som ett block i mitten av skärmen*/
    display: block;
    text-decoration: none;
    text-align: center;
}

li a:hover {
    background-color: rgb(60, 200, 160); /*Blir grönaktig färg när musen är över knappen*/
}

li a:active {
    background-color: rgb(255,0,0); /*Blir till röd färg när knappen trycks*/
}

li a
{
    list-style: none;
    margin: 0;
    display: block;
    padding: 16px 80px;
    color: white;
    text-decoration: none;
}
@media screen and(max-width: 900px)
{ /*Om skärmen är mindre än 900 pixlar knapparna vara en per rad istället*/
    li a {
    padding: 16px 350px;
    }
}

li {
    float: left;
    border-right: 1px solid #bbb;
}


li:last.child {
    border-right: none;
}

ul {
    border-radius: 32px;
    padding: 0;
    overflow: hidden;
    margin: 0;
    list-style-type: none;
    overflow: hidden;
    background-color: rgb(60, 20, 200);
}

/*-------------------------Slut på kod för nav meny, början på kod för columnerna--------------------------------------------------------------------------------------------------------------*/

.column { /*Skapar columner som är lika stora och täcker en tredjedel av skärmen*/
    float: left;
    width: 33.33%;
    background-color: hsla(0, 100%, 100%, 0.8);
}

.row:after {
    content: "";
    display: table;
    clear: both;
}


@media screen and(max-width: 600px)
{ /*Om skärmen är mindre än 600 pixlar så kommer columnerna åvanför varandra istället*/
  .column {
    width: 100 %;
    }
}

/*-------------------------Slut på kod för columnerna----------------------------------------------------------------------------------------------------------------------------------------------*/

thead {color:green;}
tbody {color:blue;}
tfoot {color:red;}

caption {
    font-size: 32px;
}
