nav > li > a { /*Alla a som child till li som child till nav displayas som ett block i mitten av skärmen*/
    display: block;
    text-decoration: none;
    text-align: center;
}

li a:hover {
    background-color: rgb(60, 200, 160); 
}

li a:active {
    background-color: rgb(255,0,0); 
}

li a
{
    list-style: none;
    margin: 0;
    display: block;
    padding: 16px 90px;
    color: white;
    text-decoration: none;
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

