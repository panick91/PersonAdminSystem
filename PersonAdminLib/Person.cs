namespace PersonAdminLib
{
    /// <summary>
    /// Represents a Person data object
    /// </summary>
    public class Person
    {
        public string firstname { get; set; }
        public string surname { get; set; }

        /// <summary>
        /// Initializes Person data object
        /// For keeping code simple NO argument checks 
        /// </summary>
        /// <param name="firstname">can also be null</param>
        /// <param name="surname"></param>
        public Person(string firstname, string surname)
        {
            this.firstname = firstname;
            this.surname = surname;
        }
    }
}