<!DOCTYPE html>
<html lang = "en" >
    < head >
        < meta charset="UTF-8">
        <meta name = "viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Strategy</title>
        <link rel = "stylesheet" type="text/css" href="CssSpel.css"> <!--Referar till CSS filen.-->
        <style>

              div {
    font - size: 2rem;
}
        </style>
    </head>
    <body bgcolor = "Blue" >
        < P > < a href="webb.html">Tillbaka till hubben</a></P>
        <div class="row">
            <div class="column"> <!--De tre spalterna-->
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
            <div class="column">
                <h1>Fakta om strategispel</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
            <div class="column">
                <p> Vilken �r din favorit typ av strategi spel och vilket �r det?</p>
                <select> <!--Forms fr�gorna-->
                    <optgroup label = "4X" >
                        < option value="civilization">Civlization</option>
                        <option value = "galactic civiliations" > Galactic Civilizations</option>
                        <option value = "europa universalis" > Europa Universalis</option>
                    </optgroup>
                    <optgroup label = "RTS" >
                        < option value="starcraft">Starcraft</option>
                        <option value = "warcraft" > Warcraft </ option >
                        < option value="company of heroes">Company of Heroes</option>
                    </optgroup>
                    <optgroup label = "Turn based strategy" >
                        < option value="xcom">XCOM</option>
                        <option value = "total war" > Total War</option>
                        <option value = "heroes of might and magic" > Heroes of Might and Magic</option>
                        </optgroup>
                </select>
                <p>Hur l�nge har du spelat spel?</p>
                <form action = "/action_page.php" method= "get" >
    
                        < input list= "�r" name= "�r" >
    
                        < datalist id= "�r" >
    
                            < option value= "Spelar inte" >
    
                            < option value= "1 �r" >
    
                            < option value= "2 �r" >
    
                            < option value= "3 �r" >
    
                            < option value= "4 �r" >
    
                            < option value= "5 �r" >
    
                            < option value= "6 �r" >
    
                            < option value= "7 �r" >
    
                            < option value= "8 �r" >
    
                            < option value= "9 �r" >
    
                            < option value= "10 �r" >
    
                        </ datalist >
    
                    < input type= "submit" >
    
                    </ form >
    
                    < p > Tryck p� denna knappen om du vill.</p>
                <button type = "button" > Tryck mig!</button>
            </div>
        </div>
    </body>
</html>