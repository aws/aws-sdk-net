using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ServiceClientGenerator;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class XmlSampleGeneratorTests
    {
        static readonly ServiceModel CLOUDFORMATION_MODEL = Utils.LoadServiceModel("cloudformation-2010-05-15.normal.json", null);
        static readonly ServiceModel SQS_MODEL = Utils.LoadServiceModel("sqs-2012-11-05.normal.json", null);
        static readonly ServiceModel IAM_MODEL = Utils.LoadServiceModel("iam-2010-05-08.normal.json", null);

        [TestMethod][TestCategory("UnitTest")]
        public void SanityGenerateForAllsOperations()
        {
            SanityGenerateForAllsOperations(CLOUDFORMATION_MODEL);
            SanityGenerateForAllsOperations(SQS_MODEL);
            SanityGenerateForAllsOperations(IAM_MODEL);
        }

        private void SanityGenerateForAllsOperations(ServiceModel serviceModel)
        {
            foreach (var operation in serviceModel.Operations)
            {
                try
                {
                    Generate(serviceModel, operation.Name);
                }
                catch (Exception e)
                {
                    throw new Exception("Failed to generate for operation " + operation, e);
                }
            }
        }

        [TestMethod][TestCategory("UnitTest")]
        public void ListTables()
        {
            var responseJson = Generate(CLOUDFORMATION_MODEL, "ListStacks");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseJson);

            Assert.AreEqual("ListStacksResponse", doc.DocumentElement.Name);
            var resultNode = doc.DocumentElement.ChildNodes[0];
            Assert.AreEqual("ListStacksResult", resultNode.Name);

            Assert.AreEqual(XmlNodeType.Text, resultNode["NextToken"].ChildNodes[0].NodeType);
            Assert.IsTrue(resultNode["NextToken"].InnerText.Length > 0);

            var stackSummaries = resultNode["StackSummaries"];
            Assert.IsNotNull(stackSummaries, "No stack summaries");

            var members = stackSummaries.SelectNodes("member");
            Assert.IsTrue(members.Count > 0);

            Assert.AreEqual(XmlNodeType.Element, members[0].NodeType);
        }


        [TestMethod][TestCategory("UnitTest")]
        public void FlattenMapTest()
        {
            var responseXml = Generate(SQS_MODEL, "ReceiveMessage");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseXml);

            Assert.AreEqual("ReceiveMessageResponse", doc.DocumentElement.Name);
            var resultNode = doc.DocumentElement.ChildNodes[0];
            Assert.AreEqual("ReceiveMessageResult", resultNode.Name);

            var messageNode = resultNode.SelectSingleNode("Message");
            var attributeNodes = messageNode.SelectNodes("Attribute");
            Assert.IsTrue(attributeNodes.Count > 1);

            Assert.AreEqual(XmlNodeType.Text, attributeNodes[0]["Name"].ChildNodes[0].NodeType);
            Assert.AreEqual(XmlNodeType.Text, attributeNodes[0]["Value"].ChildNodes[0].NodeType);
        }

        [TestMethod][TestCategory("UnitTest")]
        public void NonFlattenMapTest()
        {
            var responseJson = Generate(IAM_MODEL, "GetAccountSummary");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(responseJson);

            Assert.AreEqual("GetAccountSummaryResponse", doc.DocumentElement.Name);
            var resultNode = doc.DocumentElement.ChildNodes[0];
            Assert.AreEqual("GetAccountSummaryResult", resultNode.Name);

            var summaryMapNodes = resultNode.SelectNodes("SummaryMap");
            Assert.AreEqual(1, summaryMapNodes.Count);

            Assert.IsTrue(summaryMapNodes[0].SelectNodes("entry").Count > 1);

            var entryNode = summaryMapNodes[0].SelectNodes("entry")[0];
            Assert.AreEqual(XmlNodeType.Text, entryNode["key"].ChildNodes[0].NodeType);
            Assert.AreEqual(XmlNodeType.Text, entryNode["value"].ChildNodes[0].NodeType);
        }


        string Generate(ServiceModel model, string operationName)
        {
            var operation = model.Operations.First(x => x.Name == operationName);
            var generator = new XmlSampleGenerator(model, operation);
            return generator.Execute();
        }
    }
}
