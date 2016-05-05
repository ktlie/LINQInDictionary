using System;
using System.Collections.Generic;
using System.Linq;


namespace DictionaryWhatIs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Customer - Create a customer object using Object Initializer
             * Created on 09/09/2014
             */
            //Customer customer1 = new Customer 
            //{ 
            //    ID = 101,
            //    Name = "Mark",
            //    Salary = 5000
            //};

            //Customer customer2 = new Customer
            //{
            //    ID = 110,
            //    Name = "Pam",
            //    Salary = 6500
            //};
            //Customer customer3 = new Customer
            //{
            //    ID = 119,
            //    Name = "John",
            //    Salary = 3000
            //};

            /*
             * Dictionary<int, Customer> - Create a dictionary of customer object with Customer.ID as a key.
             * Created on 09/09/2014
             */
            //Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            //dictionaryCustomer.Add(customer1.ID, customer1);
            //dictionaryCustomer.Add(customer2.ID, customer2);
            //dictionaryCustomer.Add(customer3.ID, customer3);

            /*
             * List<Customer> - Create a List of customers object.
             * Created on 09/09/2014
             */
            //List<Customer> customers = new List<Customer>();
            //customers.Add(customer1);
            //customers.Add(customer2);
            //customers.Add(customer3);

            /*
             * Dictionary<int, Customer>.ToDictionary - Convert a List of customers object to dictionaries 
             *                                          using Lambda expression.
             * Created on 09/09/2014
             */
            //Dictionary<int, Customer> dictionaryCustomers = customers.ToDictionary(cust => cust.ID, cust => cust);

            /*
             * foreach (KeyValuePair<int, Customer> kvp in dictionaryCustomer) - Loop through a dictionary of customer object
             *          using KeyValuePair<int, Customer>
             * Created on 09/09/2014
             */
            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomer)
            //{
            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("-------------------------------------------------------------");
            //}




























            Customer Customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer Customer2 = new Customer
            {
                ID = 102,
                Name = "Pam",
                Salary = 6500
            };

            Customer Customer3 = new Customer
            {
                ID = 119,
                Name = "John",
                Salary = 3500
            };

            /*
             * Dictionary - Represents a collection keys and values.
             *              <TKey, Value> where TKey is int and Value is Customer Type
             * Created on 09-09-2014
             */
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(Customer1.ID, Customer1);
            dictionaryCustomers.Add(Customer2.ID, Customer2);
            dictionaryCustomers.Add(Customer3.ID, Customer3);

            /*
             * To retrieve the detail one of the customer object.
             */
            //Customer customer119 = dictionaryCustomers[119];

            //Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);
            //Console.ReadLine();

            /*
             * KeyValuePair<TKey,TValue> - To list an items in the Dictionary object using foreach.
             * var - another way to declare KeyValuePair<TKey,TValue> type
             */
            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            //foreach (var customerKeyValuePair in dictionaryCustomers)
            //{
            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("-------------------------------------------------------------");
            //}
            //Console.ReadLine();

            /*
             * To loop through the TKey within the Dictionary object.
             */
            //foreach (int key in dictionaryCustomers.Keys)
            //{
            //    Console.WriteLine("Key = {0}", key.ToString());
            //}
            //Console.ReadLine();

            /*
             * To loop through the VALUE of the Dictionary object.
             */
            //foreach (Customer cust in dictionaryCustomers.Values)
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //Console.ReadLine();

            /*
             * To check or verify the key exist or not
             */
            //if (!dictionaryCustomers.ContainsKey(Customer1.ID))
            //{
            //    dictionaryCustomers.Add(Customer1.ID, Customer1);
            //}
            //Console.ReadLine();

            /*
             * Even if you want to retrieve the value of dictionary object, please make sure
             *      the dictionary has the key before retrieving the value
             */
            //if (dictionaryCustomers.ContainsKey(135))
            //{
            //    Customer cust = dictionaryCustomers[135];
            //}
            //Console.ReadLine();

            /*
             * TryGetValue - Gets the value associated with the specified key,
             *               return "True" or "False"
             */

            //Customer cust;
            //if (dictionaryCustomer.TryGetValue(101, out cust))
            //{
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("The customer is not found");
            //}
            //Console.ReadLine();

            /*
             * Count property - First, Get the number of key/value pairs contained in the 
             *                  System.Collection.Generic.Dictionary
             */
            //Console.WriteLine("Total number of items in the Dictionary = {0}", dictionaryCustomer.Count);

            /*
             * Count()  - This function can be used in the LINQ extension method 
             *          - to return the number of elements in a sequence
             */
            Console.WriteLine("Total number of items in the dictionary = {0}", dictionaryCustomers.Count());
            Console.WriteLine("Total number of items in the dictionary = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 4000));

            /*
             * Remove - remove a value with the specified key from 
             *          System.Collection.Generic.Dictionary
             */
            //dictionaryCustomer.Remove(999);
            /*
             * Clear - Remove all items[ keys and values ] from System.Collection.Generic.Dictionary
             */
            //dictionaryCustomers.Clear();

            /*
             * customerArray - Create a array of customer type
             */
            //Customer[] customerArray = new Customer[3];
            //customerArray[0] = customer1;
            //customerArray[1] = customer2;
            //customerArray[2] = customer3;

            /*
             * ToDictionary - Convert an Array into a Dictionary
             */
            //Dictionary<int, Customer> dictionaryCustomer = customerArray.ToDictionary(cust => cust.ID, cust => cust);
            //foreach (KeyValuePair<int, Customer> kvp in dictionaryCustomer)
            //{
            //    Console.WriteLine("The key is {0}", kvp.Key);
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", kvp.Value.ID, kvp.Value.Name, kvp.Value.Salary);
            //}
            //Console.ReadLine();

            //Dictionary<int, Customer> customerDictionary = customerArray.ToDictionary(cust => cust.ID, cust => cust);
            //foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomer)
            //{
            //    Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
            //    Customer cust = customerKeyValuePair.Value;
            //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            //    Console.WriteLine("-------------------------------------------------------------");
            //}
            //Console.ReadLine();

            /*
             * listCustomer - Create a list of customer type.
             */
            List<Customer> listcustomer = new List<Customer>();
            listcustomer.Add(Customer1);
            listcustomer.Add(Customer2);
            listcustomer.Add(Customer3);

            /*
             * ToDictionary - Convert a list into a Dictionary
             */

            Dictionary<int, Customer> customerDictionary = listcustomer.ToDictionary(cust => cust.ID, cust => cust);
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in customerDictionary)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("-------------------------------------------------------------");
            }
        }

       
    }

    public class Customer 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }





























    //public class Customer
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //}
}
