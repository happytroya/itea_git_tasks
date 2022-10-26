using System;


namespace PhoneBook
{
    public enum NumberType
    {
        mobile,
        official,
        work
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook[] newPhoneBook = 
            {
                new PhoneBook("Ivan", "0960286020", NumberType.mobile),
                new PhoneBook("Vika", "0888888888", NumberType.mobile),
                new PhoneBook("Ivan", "7777777777", NumberType.mobile),
                new PhoneBook("Bogdan", "1234567890", NumberType.mobile),
                new PhoneBook("Igor", "09876543212", NumberType.mobile),
                new PhoneBook("Oleksiy","2282282282", NumberType.mobile),
            };

            while (true)
            {
                Console.WriteLine("Press 1 if you want to search by name");
                Console.WriteLine("Press 2 if you want to search by number");
                Console.WriteLine("Press 3 if you want to search by number type");

                string operationNumber = Console.ReadLine();

                Console.WriteLine("Enter value: ");
                string stringToFind = Console.ReadLine();

                bool valueIsCorrect = false;
                foreach (PhoneBook person in newPhoneBook)
                {
                    switch (operationNumber)
                    {
                        case "1":
                            if (person.FindByName(stringToFind))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect = true;
                            }
                            break;
                        case "2":
                            if (person.FindByNumber(stringToFind))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect = true;
                            }
                            break;
                        case "3":
                            if (person.FindByType((NumberType)Enum.Parse(typeof(NumberType), stringToFind)))
                            {
                                Console.WriteLine(person.GetInfo());
                                valueIsCorrect = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect value. Try again");
                            break;
                    }

                }
                if (!valueIsCorrect)
                {
                    Console.WriteLine("No results.");
                }
            }
        }
    }

    public struct PhoneBook 
    {
        private string personName;
        private string phoneNumber;
        private NumberType phoneNumberType;
        public PhoneBook(string personName, string phoneNumber, NumberType phoneNumberType)
        {
            this.personName = personName;
            this.phoneNumber = phoneNumber;
            this.phoneNumberType = phoneNumberType;
        }

        public string GetInfo()
        {
            return $"Abonent: {personName}, phone type: {phoneNumberType} - {phoneNumber}";
        }

        public bool FindByName(string stringToFind)
        {
            return personName.ToLower().Contains(stringToFind.ToLower());      
        }

        public bool FindByNumber(string stringToFind)
        {
            return phoneNumber.ToLower().Contains(stringToFind.ToLower());
        }

        public bool FindByType(NumberType numberType)
        {
            return phoneNumberType == numberType;
        }


    }
}
