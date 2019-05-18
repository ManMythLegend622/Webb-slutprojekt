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
                <p> Vilken är din favorit typ av strategi spel och vilket är det?</p>
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
                <p>Hur länge har du spelat spel?</p>
                <form action = "/action_page.php" method= "get" >
    
                        < input list= "år" name= "år" >
    
                        < datalist id= "år" >
    
                            < option value= "Spelar inte" >
    
                            < option value= "1 år" >
    
                            < option value= "2 år" >
    
                            < option value= "3 år" >
    
                            < option value= "4 år" >
    
                            < option value= "5 år" >
    
                            < option value= "6 år" >
    
                            < option value= "7 år" >
    
                            < option value= "8 år" >
    
                            < option value= "9 år" >
    
                            < option value= "10 år" >
    
                        </ datalist >
    
                    < input type= "submit" >
    
                    </ form >
    
                    < p > Tryck på denna knappen om du vill.</p>
                <button type = "button" > Tryck mig!</button>
            </div>
        </div>
    </body>
</html>