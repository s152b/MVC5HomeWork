using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5HomeWork.Models
{   
	public  class v客戶資料Repository : EFRepository<v客戶資料>, Iv客戶資料Repository
	{

	}

	public  interface Iv客戶資料Repository : IRepository<v客戶資料>
	{

	}
}