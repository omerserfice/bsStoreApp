
namespace Entities.RequestFeatures
{
    public class BookParameters : RequestParameters
    {
        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; } = 1000; // max fiyatı 1000 verdik.
        public bool ValidPriceRange => MaxPrice > MinPrice; // maxprice minprice den büyükse true olacak. aksi halde false 
        public String? SearchTerm { get; set; }

        public BookParameters()
        {
            OrderBy = "id";   // herhangi bir bilgi verilmediyse id ye göre sırala.
        }
    }
}
