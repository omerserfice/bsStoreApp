namespace Entities.RequestFeatures
{
    public abstract class RequestParameters 
    {
		const int maxPageSize = 50; // sabit tanımladık. pagesize 50 yi geçemeyecek.
        public int PageNumber { get; set; }

		private int _pageSize;

		public int PageSize // bu alanda bir mantık işleticez. get de pagesize dönecek ama set ederken value değerini kısıtlamamız gerekecek.
		{
			get { return _pageSize; }
			set { _pageSize = value > maxPageSize ? maxPageSize : value; }
		}

        public String? OrderBy { get; set; }
        public String? Fields { get; set; }

    }

	
}
