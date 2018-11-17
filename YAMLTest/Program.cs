using System;
using YamlDotNet;

namespace YAMLTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Test Yaml........................");
            Console.WriteLine();

            var user = new User()
            {
                Id = 1,
                Email = "abc@a.com",
                UserName = "admin",
                Password = "123456",
                IsActive = true,
                Person = new Person()
                {
                    Id = 1,
                    Name = "张三",
                    Age = 30
                }
            };

            Console.WriteLine("User Hash:" + user.GetHashCode());

            var serializer = new YamlDotNet.Serialization.Serializer();

            var yamlResult = serializer.Serialize(user);
            Console.WriteLine(yamlResult);

            var deserializer = new YamlDotNet.Serialization.Deserializer();
            var userClone = deserializer.Deserialize<User>(yamlResult);

            Console.WriteLine("UserClone Hash:" + userClone.GetHashCode());

            Console.WriteLine("User equals UserClone:" + (user == userClone));


            Console.WriteLine();

            Console.WriteLine("End Test Yaml........................");
            Console.ReadLine();
        }
    }
}
