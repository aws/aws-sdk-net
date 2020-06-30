#if !NETSTANDARD13
/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
 */

using Amazon.QLDB;
using Amazon.QLDB.Model;

using Moq;
using System;
using System.Linq;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.PaginatorTests
{
    [TestClass]
    public class QLDBPaginatorTests
    {
        private static Mock<AmazonQLDBClient> _mockClient;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            _mockClient = new Mock<AmazonQLDBClient>("access key", "secret", Amazon.RegionEndpoint.USEast1);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        public void ListJournalKinesisStreamsForLedgerTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalKinesisStreamsForLedgerRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJournalKinesisStreamsForLedgerResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJournalKinesisStreamsForLedgerResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJournalKinesisStreamsForLedger(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJournalKinesisStreamsForLedger(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJournalKinesisStreamsForLedgerTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalKinesisStreamsForLedgerRequest>();

            var response = InstantiateClassGenerator.Execute<ListJournalKinesisStreamsForLedgerResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJournalKinesisStreamsForLedger(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJournalKinesisStreamsForLedger(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        public void ListJournalS3ExportsTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalS3ExportsRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJournalS3ExportsResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJournalS3ExportsResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJournalS3Exports(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJournalS3Exports(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJournalS3ExportsTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalS3ExportsRequest>();

            var response = InstantiateClassGenerator.Execute<ListJournalS3ExportsResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJournalS3Exports(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJournalS3Exports(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        public void ListJournalS3ExportsForLedgerTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalS3ExportsForLedgerRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListJournalS3ExportsForLedgerResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListJournalS3ExportsForLedgerResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListJournalS3ExportsForLedger(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListJournalS3ExportsForLedger(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListJournalS3ExportsForLedgerTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListJournalS3ExportsForLedgerRequest>();

            var response = InstantiateClassGenerator.Execute<ListJournalS3ExportsForLedgerResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListJournalS3ExportsForLedger(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListJournalS3ExportsForLedger(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        public void ListLedgersTest_TwoPages()
        {
            var request = InstantiateClassGenerator.Execute<ListLedgersRequest>();

            var firstResponse = InstantiateClassGenerator.Execute<ListLedgersResponse>();
            var secondResponse = InstantiateClassGenerator.Execute<ListLedgersResponse>();
            secondResponse.NextToken = null;

            _mockClient.SetupSequence(x => x.ListLedgers(request)).Returns(firstResponse).Returns(secondResponse);
            var paginator = _mockClient.Object.Paginators.ListLedgers(request);
            
            Assert.AreEqual(2, paginator.Responses.ToList().Count);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("QLDB")]
        [ExpectedException(typeof(System.InvalidOperationException), "Paginator has already been consumed and cannot be reused. Please create a new instance.")]
        public void ListLedgersTest__OnlyUsedOnce()
        {
            var request = InstantiateClassGenerator.Execute<ListLedgersRequest>();

            var response = InstantiateClassGenerator.Execute<ListLedgersResponse>();
            response.NextToken = null;

            _mockClient.Setup(x => x.ListLedgers(request)).Returns(response);
            var paginator = _mockClient.Object.Paginators.ListLedgers(request);

            // Should work the first time
            paginator.Responses.ToList();

            // Second time should throw an exception
            paginator.Responses.ToList();
        }

    }
}
#endif