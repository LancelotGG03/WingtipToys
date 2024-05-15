using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WIngtip.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Carros"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Aviones"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Tractomulas"

                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Barcos"

                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Cohetes"
                },

            };
            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Carro Convertible",
                    Description = "Este carro convertible es rápido, el motor es alimentado por una bateria basada en neutrino (No incluida)."
                    + "¡Enciendelo y hazlo!",

                    ImagePath = "202311024938416456.jpeg",
                    UnitPrice = 22.50,
                    CategoryID = 1,
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Carro Antiguo",
                    Description = "No hay nada de viejo en este juguete, excepto que parece compatible con otros coches de juguetes antiguos.",
                    ImagePath = "Carroantiguo.png",
                    UnitPrice = 15.95,
                    CategoryID = 1,

                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Carro veloz",
                    Description = "Sí, este carro es rápido, pero también flota en el agua.",
                    ImagePath = "carroacuatico.png",
                    UnitPrice = 32.99,
                    CategoryID = 1,

                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Carro súper veloz",
                    Description = "Usa este carro súper rápido para entretener a los enemigos, ¡Las luces y puertas funcionan!.",
                    ImagePath = "carrosuperrapido.png",
                    UnitPrice = 8.95,
                    CategoryID = 1,
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Corredor con estilo antiguo",
                    Description = "Este corredor con estilo antiguo puede volar (con asistencia del usuario), la gravedad controla la duración del vuelo." + "No requiere baterias.",
                    ImagePath = "carrovolador.png",
                    UnitPrice = 34.95,
                    CategoryID = 1,
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Avión Ace",
                    Description = "Auténtico juguete de avión con características reales, colores y detalles.",
                    ImagePath = "Avionrealista.png",
                    UnitPrice = 95.00,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Glider",
                    Description = "Este divertido planeador está hecho de tela real y madera. Se requiere armar.",
                    ImagePath = "avionplaneador.png",
                    UnitPrice = 4.95,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Avión de papel",
                    Description = "Este avión de papel es como ningún otro avión de papel. Se requiere armar.",
                    ImagePath = "avioncarton.png",
                    UnitPrice = 2.95,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Helicóptero",
                    Description = "Este avión cuenta conn banda elástica, y cuenta con dos ruedas.",
                    ImagePath = "helicoptero.png",
                    UnitPrice = 32.95,
                    CategoryID = 2,
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Early Truck",
                    Description = "Este camión de juguete tiene un motor de gasolina real. Requiere mantenimiento.",
                    ImagePath = "camiongas.png",
                    UnitPrice = 15.00,
                    CategoryID = 3,
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Fire truck",
                    Description = "No te cansarás de divertirte con este camión de bomberos.",
                    ImagePath = "camionbomberos.png",
                    UnitPrice = 26.00,
                    CategoryID = 3,
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Big truck",
                    Description = "Este divertido camión de juguete se puede usar para remolcar otros camiones que no son tan grandes.",
                    ImagePath = "camionlargo.png",
                    UnitPrice = 29.00,
                    CategoryID = 3,
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Big Ship",
                    Description = "Es un barco, o un bote, deja que flote." + "Usa inteligencia artificial.",
                    ImagePath = "botemadera.png",
                    UnitPrice = 95.00,
                    CategoryID = 4,
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Paper Boat",
                    Description = "Diversión para todos, este barco de juguete se crea en segundos y flota durante minutos.",
                    ImagePath = "barcodepapel.png",
                    UnitPrice = 4.95,
                    CategoryID = 4,
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Sail Boat",
                    Description = "Pon este velero de juguete en el agua y disfruta.",
                    ImagePath = "barco2.png",
                    UnitPrice = 42.95,
                    CategoryID = 4,
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Rocket",
                    Description = "Este divertido cohete viajará hasta una altura de 200 pies.",
                    ImagePath = "cohete.png",
                    UnitPrice = 122.95,
                    CategoryID = 5,
                }
            };
            return products;
        }
    }
}