// See https://aka.ms/new-console-template for more information
using DesingPatterns.DesignPatterns.BuilderDesingPattern;





// ******** BUILDER DESING PATTERN ******** \\
ICarBuilder car = new AudiConcreteBuilder();

CreateCar createCar = new CreateCar();
createCar.Create(car);
Console.WriteLine(car.Car.ToString());

car = new BmwConcreteBuilder();
createCar.Create(car);
Console.WriteLine(car.Car.ToString());


//Diğer örnekler promosyon => promosyon için concrete classlar işçi,amir,kadınlar