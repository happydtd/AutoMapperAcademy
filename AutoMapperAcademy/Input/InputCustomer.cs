namespace AutoMapperAcademy.Input
{
    public class InputCustomer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public static InputCustomer BuildInputCustomer()
        {
            return new InputCustomer { FirstName = "Chris", LastName = "Great" };
        }
    }
}