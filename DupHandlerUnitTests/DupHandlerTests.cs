namespace GDHUnitTests
{
    using DuplicateHandlerNS;

    [TestClass]
    public class DupHandlerTests
    {
        [TestMethod]
        public void TestRemoveDuplicateTestTransactionClasses()
        {
            // Arrange
            var testHandler = new DuplicateHandler<TestTransactions>();
            var trans1 = new TestTransactions(234, new DateTime(2019, 05, 09), 34.99m);
            var trans2 = new TestTransactions(235, new DateTime(2019, 05, 09), 34.99m);
            var trans3 = new TestTransactions(236, new DateTime(2019, 05, 09), 34.99m);

            var actualCollection = new List<TestTransactions>();
            actualCollection.Add(trans1);
            actualCollection.Add(trans1);
            actualCollection.Add(trans2);
            actualCollection.Add(trans3);
            actualCollection.Add(trans3);
            actualCollection.Add(trans1);

            var expectedCollection = new List<TestTransactions>();
            expectedCollection.Add(trans1);
            expectedCollection.Add(trans2);
            expectedCollection.Add(trans3);

            // Act
            actualCollection = (List<TestTransactions>)testHandler.RemoveDuplicates(actualCollection);

            // Assert
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }

    /// <summary>
    /// Class <c>TestTransations</c> is solely used for testing if the DuplicateHandler will
    /// remove repeated instances of a class in a list.
    /// </summary>
    public class TestTransactions
    {
        private int _transactionID;
        private DateTime _chargeDate;
        private decimal _payment;

        public TestTransactions(int initTransactionID, DateTime initChargeDate, decimal initPayment)
        {
            _transactionID = initTransactionID;
            _chargeDate = initChargeDate;
            _payment = initPayment;
        }

        public int TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        public DateTime ChargeDate
        {
            get { return _chargeDate; }
            set { _chargeDate = value; }
        }

        public decimal Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }
    }
}
