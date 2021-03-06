using System;
class MainClass {
  public static void Main (string[] args) {
    //Equation for position at time t: Xt = X + V * T;
    //Equation for velocity at time t: Vt = V(always the same) + T(changes by 0.2) * A(Earth's gravity);
    //Adding "time" 0.2s by 0.2s;
    
    double positionXAtT, positionX, velocityV, timeT;
    double newPositionXAtT, newPositionX, newVelocityV, newTimeT, earthGravity, velocityVAtT;
    string aux;
    
    
    newTimeT = 0;
    earthGravity = -9.81;
    
    Console.WriteLine("Enter initial position for 'y'");
    aux = Console.ReadLine();
    positionX = Convert.ToDouble(aux);
    Console.WriteLine("Enter initial velocity 'v'");
    aux = Console.ReadLine();
    velocityV = Convert.ToDouble(aux);
    for (int counter = 0; counter <= 5; counter = counter + 1) //Applied 5x
      {
      while (newTimeT <= 1.0)
        {
          /*Console.WriteLine("Enter initial position for 'y'");
          aux = Console.ReadLine();
          positionX = Convert.ToDouble(aux);
          Console.WriteLine("Enter initial velocity 'v'");
          aux = Console.ReadLine();
          velocityV = Convert.ToDouble(aux);*/
          Console.WriteLine("Enter time 't'");
          aux = Console.ReadLine();
          timeT = Convert.ToDouble(aux);
          newTimeT = timeT;
          
          positionXAtT = positionX + (velocityV * timeT);
          Console.WriteLine("Position at time 't' is equal to:" + positionXAtT);
          velocityVAtT = velocityV + (newTimeT * earthGravity);
          Console.WriteLine("Velocity at time 't' is equal to:" + velocityVAtT);
          positionX = positionXAtT;
          velocityV = velocityVAtT;
          timeT = timeT + timeT;
      }
    }
  }
}

//IMPROVED

using System;
class MainClass {
  public static void Main (string[] args) {
    //Equation for position at time t: Xt = X + V * T;
    //Equation for velocity at time t: Vt = V(always the same) + T(changes by 0.2) * A(Earth's gravity);
    //Adding "time" 0.2s by 0.2s;
    
    double posXAtTimT = 0, posX = 0, velV = 0, timT = 0;
    double posXAtTimTS = 0, velVAtTimT = 0, sec = 0;
    double counter = 0;
    double store = 0;
    double earthGrav = -9.81;
    string aux;
    
    earthGrav = -9.81;
    
    while (counter < 6)
      {
        /*Console.WriteLine("Enter initial position for 'y': ");
        aux = Console.ReadLine();
        posX = Convert.ToDouble(aux);
        Console.WriteLine("Enter initial velocity 'v': ");
        aux = Console.ReadLine();
        velV = Convert.ToDouble(aux);*/
        if (timT == 0 && sec == 0 && posX == 0 && velV == 0)
          {
            Console.WriteLine("Enter initial position for 'y': ");
            aux = Console.ReadLine();
            posX = Convert.ToDouble(aux);
            Console.WriteLine("Enter initial velocity 'v': ");
            aux = Console.ReadLine();
            velV = Convert.ToDouble(aux);
            Console.WriteLine("Enter time 't' or seconds 's': ");
            aux = Console.ReadLine();
            store = Convert.ToDouble(aux);
            timT = timT + store;
            sec = sec + store;
          }
        else if (timT < 0 && sec < 0)
          {
            timT = 0;
            sec = 0;
            Console.WriteLine("TimT " + timT);
            Console.WriteLine("sec " + sec);
          }
        else
          {
            timT = timT + sec;
            Console.WriteLine("TimT " + timT);
            Console.WriteLine("sec " + sec);
          }
        
        if (posXAtTimT == 0 && velVAtTimT == 0)
        {
          posXAtTimT = posX + (velV * sec);
          Console.WriteLine("Position at time " + timT + " is equal to: " + posXAtTimT);
          Console.WriteLine("First time done.");
        }
        else
        {
          posXAtTimTS = posXAtTimT + (velVAtTimT * sec);
          Console.WriteLine("Position at time " + timT + " + " + sec + " is equal to: " + posXAtTimTS);
          posXAtTimT = posXAtTimTS;
        }
        velVAtTimT = velV + (earthGrav * timT);
        Console.WriteLine("Velocity at time " + timT + " is equal to: " + velVAtTimT);
        counter = counter + 1;
    }
  }
}
