namespace SocialMedia.Project.Main.Interface;

internal class Exceptions
{
    public class invalidChoiceException : Exception
    {
        invalidChoiceException() { }
        public invalidChoiceException(string message) : base(message) { }
        public invalidChoiceException(string message, Exception inner) : base(message, inner) { }


        public class InvalidEmailException : Exception
        {
            public InvalidEmailException() { }
            public InvalidEmailException(string message) : base(message) { }
            public InvalidEmailException(string message, Exception inner) : base(message, inner) { }
        }

        public class InvalidPasswordException : Exception
        {
            public InvalidPasswordException() { }
            public InvalidPasswordException(string message) : base(message) { }
            public InvalidPasswordException(string message, Exception inner) : base(message, inner) { }
        }

        public class EmptyFieldException : Exception
        {
            public EmptyFieldException() { }
            public EmptyFieldException(string message) : base(message) { }
            public EmptyFieldException(string message, Exception inner) : base(message, inner) { }
        }
        public class InvalidIdException : Exception
        {
            public InvalidIdException() { }

            public InvalidIdException(string message) : base(message) { }
            public InvalidIdException(string message, Exception inner) : base(message, inner) { }

        }
    }
}
