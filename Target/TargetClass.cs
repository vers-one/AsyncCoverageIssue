using System.IO;
using System.Threading.Tasks;

namespace Target
{
    public class TargetClass
    {
        public async Task Copy()
        {
            using (MemoryStream ms1 = new MemoryStream())
            using (MemoryStream ms2 = new MemoryStream())
            {
                await ms1.CopyToAsync(ms2);
            }
        }
    }
}
