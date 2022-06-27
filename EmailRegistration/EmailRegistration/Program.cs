namespace RegexPattern
{
    class Progran
    {
        public static void Main(string[] args)
        {
            RegexClass userRegexTest = new RegexClass();
            String EmailAddress = "hdshreegowri@gmail.com";

            string[] EmailList = { "abc@yohoo.com","abc-100@yohoo.com",
                                    "abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                                     "abc.100@abc.com.au", "abc@1.com","abc","abc@.com.my",
                                    "abc123@gmail.a",
                                     "abc1232.com"
                                     ,".abc@abc.com","abc123.com.my", "abc123@.com.com"};

            userRegexTest.ValidateEmailAddressRegex(EmailAddress);
            foreach (string SampleEmailAddress in EmailList)
            {
                userRegexTest.ValidateEmailAddressRegex(SampleEmailAddress);
            }

        }
    }
}