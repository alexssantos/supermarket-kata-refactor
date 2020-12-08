using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SupermarketReceipt.Test.Refactor
{
	public class SupermarketMSTestRefactor
	{





		[TestInitialize]
		public void TearUp()
		{
			SupermarketCatalog catalog = new FakeCatalog();

			var toothbrush = new Product("toothbrush", ProductUnit.Each);
			var apples = new Product("apples", ProductUnit.Kilo);


			catalog.AddProduct(toothbrush, 0.99);
			catalog.AddProduct(apples, 1.99);

			var cart = new ShoppingCart();

			var teller = new Teller(null);

			teller.AddSpecialOffer(SpecialOfferType.TenPercentDiscount, toothbrush, 10.0);

		}

		//CADASTRAR CLIENTE ============================================

		[TestMethod]
		[DataTestMethod]
		[DataRow("Alex Santos", "12345678900")]
		[DataRow("Marcio Santos", "99988877700")]
		[DataRow("Lucas Pitol", "11122233344")]
		[DataRow("Bruno Furtado", "12312312300")]
		public void SecessoAoCadastrarCliente(string nome, string cpf)
		{
			//Arrange


			//Act


			//Assert
			Assert.IsNotNull(null);
		}

		[TestMethod]
		[DataTestMethod]
		[DataRow("12345678900")]
		[DataRow("12345678922")]
		[DataRow("11122233300")]
		[ExpectedException(typeof(System.Exception))]
		public void ErroAoCadastrarClienteQuandoJaExisteCpf(string cpf)
		{
			//Arrange


			//Act


			//Assert
			Assert.IsTrue(true);
		}

		//BUSCAR CLIENTE ============================================

		[TestMethod]
		public void SucessoAoBuscarCliente()
		{
			//Arrange


			//Act


			//Assert
			Assert.IsTrue(true);
		}

		[TestMethod]
		[ExpectedException(typeof(System.Exception))]
		public void ErroAoBuscarClienteQuandoIdNaoExistirNaBase()
		{
			//Arrange



			//Act


			//Assert
			Assert.IsNull(null);
		}

	}
}