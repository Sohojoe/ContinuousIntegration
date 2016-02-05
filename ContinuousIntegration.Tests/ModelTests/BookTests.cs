using NUnit.Framework;
using System;

namespace ContinuousIntegration.Tests
{
	[TestFixture ()]
	public class BookTests
	{
		const string kTitle = "Sample Title";

		
		[Test ()]
		public void Title ()
		{
			var book = new Book ();
			book.Title = kTitle;
			Assert.AreEqual (kTitle, book.Title);
		}
		[Test ()]
		public void Pages ()
		{
			var book = new Book ();
			book.Pages = 10;
			Assert.AreEqual (10, book.Pages);
			book.Pages++;
			Assert.AreEqual (11, book.Pages);
			Assert ("test failing");
		}

	}
}

