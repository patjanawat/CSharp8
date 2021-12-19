namespace Asynchronous_sample
{
    public class Asynchronous_sample1{
        public static async IAsyncEnumerable<int> GenerateSequence(){
            for(int i= 0; i < 20; i++){
                await Task.Delay(100);
                yield return i;
            }
        }
    }
}