
using TestImageAPI.Helper;

namespace TestImageAPI.Service
{
    public class ProduceImageService:IProduceImageService
    {


        /// <summary>
        /// Genera un immagine
        /// </summary>
        /// <param name="documents"></param>
        /// <returns></returns>
        public  async Task<string> ProduceImageTest()
        {

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            string respList;

            try
            {
                int pageCount = 1;
                string fileName = Guid.NewGuid().ToString("N");

                //foreach (DocumentDTO doc in documents)
                //{
                //    if (doc != null && doc.Pages != null)
                //    {
                //        foreach (var p in doc.Pages)
                //        {
                return await Producer.ProduceImageTest();




            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.ToString()}");
                return null;
            }
        }
    }
}

