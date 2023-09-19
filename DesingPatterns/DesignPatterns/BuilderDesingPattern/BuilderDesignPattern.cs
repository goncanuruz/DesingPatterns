using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.DesignPatterns.BuilderDesingPattern
{

    // ******** BUILDER DESING PATTERN ******** \\
    // Builder design pattern creational patterns kategorisine girer.Creational pattern yazılımda yaratılış tasarım kalıpları, nesne oluşturma mekanizmalarıyla ilgilnen, duruma uygun bir şekilde nesneler oluşturmaya çalışan  tasarım kalıplarıdır.

    //Kompleks ve maliyetli nesnelerin(çok sayıda parametreye sahip veya farklı yapıda olan) oluşturulmasını kolaylaştırır, basitleştirir ve okunabilirliğini arttırır.

    //Temel amaçları=>1.Karmaşık nesneleri oluşturmak 2.Parametre kombinasyonlarının yönetimi 3.okunabilir kod
    //Bileşenleri=>director,builder,concrete builder,product
    abstract class ICarBuilder
    {
        protected Car car; //protected olmasının sebebi builder class'ın uygulanacağı derived(türetilmiş) classlardan bu fielda erişebilmektir.
        public Car Car
        {
            get { return car; }
        }
        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetKmLimit();
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int KMLimit { get; set; }


        public override string ToString()
        {
            return
                $"Km limit of {Brand} brand {Model} model car: {KMLimit}";
        }
    }
    //Concrete classlar
    class AudiConcreteBuilder : ICarBuilder
    {
        public AudiConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetBrand() => car.Brand = "Audi";
        public override void SetModel() => car.Model = "A5";
        public override void SetKmLimit() => car.KMLimit = 10000;
    }
    class BmwConcreteBuilder : ICarBuilder
    {
        public BmwConcreteBuilder()
        {
            car = new Car();
        }
        public override void SetBrand() => car.Brand = "Bmw";
        public override void SetModel() => car.Model = "5 series";
        public override void SetKmLimit() => car.KMLimit = 20000;
    }
    //Director Class
    class CreateCar
    {
        public void Create(ICarBuilder car)
        {
            car.SetBrand();
            car.SetModel();
            car.SetKmLimit();
        }
    }


    //abstract : Bu sınıf içinde abstract ile işaretlenen metodlar ve propertyler bu sınıftan kalıtım alan her         sınıfta yazılmak ve implement(uygulanmak) zorundadırlar.
    //abstract metod ya da propertylerin gövdeleri tanımlandıkları class içinde yazılmazlar.Sadece imza dediğimiz     geri dönüş tipleri, isimleri ve erişim belirleyicileri tanımlanabilir.Gövdeleri kalıtım alan sınıfta         override edilerek yazılır.
    //abstract elemanlar private OLAMAZLAR.
    //İçimde herhangi bir abstract yapı olan classın kendisi de abstract olmak zorundadır.
    //abstract olan bir classın içinde abstract olmayan yapılar da bulunabilir.
    //abstract classlardan nesne yaratılamaz.



    //Abstract sınıflar genellikle sadece imza ile tanımlanırlar. yani işlev, parametre ve dönüş değeri belirtilir.İşlevin kendisini boş bırakır.
    //Abstract sınıflardan instance oluşturulamaz. Yani bir nesne oluşturulamaz. Bunun yerine soyut sınıflardan türetilmiş alt sınıfları kullanarak nesne oluşturabiliriz. Abstract classlar sadece o noktadan referans noktası oluşturabilir.
    //Kalıtım(inheritanve) hiyerarşilerinin en üstünde bulunur.

}
