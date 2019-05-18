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
                <li><a href = "Action.html" > Action </ a ></ li >  < !--länkar till de olika genrerna-->
                <li><a href = "Adventure.html" > Adventure </ a ></ li >
  
                  < li >< a href= "Strategy.html" > Strategy </ a ></ li >
  
                  < li >< a href= "Sport.html" > Sport </ a ></ li >
  
                  < li >< a href= "RPG.html" > RPG </ a ></ li >
  
                  < li >< a href= "Fighting.html" > Fighting </ a ></ li >
  
                  < li >< a href= "Simulation.html" > Simulation </ a ></ li >
  
              </ ul >
  
          </ nav >
  
          < div class="row">
            <div class="column">
                <p>123</p>
            </div>
            <div class="column">
                <p>123</p>
            </div>
            <div class="column">
                <dl>
                    <dt>Action</dt>
                    <dd>123</dd>
                    <dt>Adventure</dt>
                    <dd>123</dd>
                </dl>
                <p>Vad tycker du om denna sida från 1 till 100?</p>
                <p>Dra slidern till vänster eller skriv in ett tal till höger...eller båda.</p>
                <form oninput = "x.value=parseInt(a.value)+parseInt(b.value)" > 0
                    < input type= "range" id= "a" value= "50" > 100
                    +< input type= "number" id= "b" value= "50" >
                    =< output name= "x" for="a b"></output>
                </form>
            </div>
        </div>
    </body>
    <footer>
        <p>Projekt som ska vara inne<time datetime="2019-05-19">19:de maj.</time></p>
    </footer>
</html>