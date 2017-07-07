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
    Console.WriteLine("Enter time 't'");
    aux = Console.ReadLine();
    timeT = Convert.ToDouble(aux);
    for (int counter = 0; counter <= 5; counter = counter + 1) //Applied 5x
      {
      while (newTimeT <= 1.0)
        {
          /*Console.WriteLine("Enter initial position for 'y'");
          aux = Console.ReadLine();
          positionX = Convert.ToDouble(aux);
          Console.WriteLine("Enter initial velocity 'v'");
          aux = Console.ReadLine();
          velocityV = Convert.ToDouble(aux);
          Console.WriteLine("Enter time 't'");
          aux = Console.ReadLine();
          timeT = Convert.ToDouble(aux);*/
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
