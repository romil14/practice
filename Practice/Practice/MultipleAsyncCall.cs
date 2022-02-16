using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class MultipleAsyncCall
    {
        public async Task<List<string>> GetFbName()
        {
            await Task.Delay(5000);
            return new List<string>() { "FB1", "FB2", "FB3" };
        }

        public async Task<List<string>> GetInstaName()
        {
            await Task.Delay(3000);
            return new List<string>() { "Insta1", "Insta2", "Insta3" };
        }

        public async Task<List<string>> GetData()
        {
            var result = new List<string>();
            var fbData = await GetFbName();
            var instaData = await GetInstaName();

            result.AddRange(fbData);
            result.AddRange(instaData);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            //Task<List<string>> fbTaskData = GetFbName();
            //Task<List<string>> instaTaskData = GetInstaName();

            //await Task.WhenAll(fbTaskData, instaTaskData);

           
            //result.AddRange(fbTaskData.Result);
            //result.AddRange(instaTaskData.Result);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            return result;

        }
    }
}
