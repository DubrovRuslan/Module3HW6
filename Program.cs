namespace Module3HW7
{
    public class Program
    {
        public static void Main()
        {
            var messageBox = new MessageBox();
            var tcs = new TaskCompletionSource();
            var rand = new Random();
            messageBox.Message += (State state) =>
            {
                if (state == State.Ok)
                {
                    Console.WriteLine("Ok - операция была подтверждена");
                }
                else
                {
                    Console.WriteLine("Ok - операция была подтверждена");
                }

                tcs.SetResult();
            };
            messageBox.Open();
            tcs.Task.GetAwaiter().GetResult();
        }
    }
}
