<!DOCTYPE html>
<html lang = "en" >


    < head >
        < meta charset="UTF-8">
        <meta name = "viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="ie=edge">
        <title>Webb</title>
        <link rel = "stylesheet" type="text/css" href="CssSpel.css"> <!--Referar till CSS filen.-->
    </head>
    <body>
        <nav>
            <ul>
                <li><a href = "Action.html" > Action </ a ></ li >  < !--l�nkar till de olika genrerna-->
                <li><a href = "Adventure.html" > Adventure </ a ></ li >
  
                  < li >< a href= "Strategy.html" > Strategy </ a ></ li >
  
                  < li >< a href= "Sport.html" > Sport </ a ></ li >
  
                  < li >< a href= "RPG.html" > RPG </ a ></ li >
  
                  < li >< a href= "Fighting.html" > Fighting </ a ></ li >
  
                  < li >< a href= "Simulation.html" > Simulation </ a ></ li >
  
              </ ul >
  
          </ nav >
  
          < div class="row">
            <div class="column"> <!--De tre spalterna-->
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
            <div class="column">
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
            </div>
            <div class="column">
                <dl>
                    <dt>Action</dt> <!--Lista och beskrivning f�r de olika genrerna-->
                    <dd>Actionspel �r en abstrakt datorspelsgenre som fokuserar p� fysiska utmaningar, d�ribland reaktionstid och koordination.</dd>
                    <dt>Adventure</dt>
                    <dd>�ventyrsspel �r en �vergripande genre inom dator- och TV-spel som k�nnetecknas av ett starkt historieber�ttande inslag.</dd>
                    <dt>Strategy</dt>
                    <dd>Strategispel �r ett spel d�r deltagarna anv�nder sitt strategiska t�nkande.</dd>
                </dl>
                <p>Vad tycker du om denna sida fr�n 1 till 100?</p> <!--Forms fr�gor-->
                <p>Dra slidern till v�nster eller skriv in ett tal till h�ger... eller b�da.</p>
                <form oninput = "x.value=parseInt(a.value)+parseInt(b.value)" > 0
                    < input type= "range" id= "a" value= "50" > 100
                    +< input type= "number" id= "b" value= "50" >
                    =< output name= "x" for="a b"></output>
                </form>
            </div>
        </div>
        <footer>
            <p>Projekt som ska vara inne<time datetime="2019-05-19">19:de maj.</time></p> <!--text med time ooch datetime v�rden-->
        </footer>
    </body>
</html>