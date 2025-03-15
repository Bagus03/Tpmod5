namespace Tpmod5
{
    public class DataGeneric<T>
    {
        public T Data { get; set; } 
        public DataGeneric(T data)
        {
            this.Data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
}
