<!DOCTYPE html>
<html lang = "en" >
    < head >
        < meta charset="UTF-8">
        <meta name = "viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Strategy</title>
        <link rel = "stylesheet" type="text/css" href="CssSpel.css"> <!--Referar till CSS filen.-->
    </head>
    <body bgcolor = "Blue" >
  
          < div class="row">
            <div class="column"></div>
            <div class="column"></div>
            <div class="column">
                <p> Vilken �r din favorit typ av strategi spel och vilket �r det?</p>
                <select>
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