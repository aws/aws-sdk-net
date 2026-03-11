/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.IntegrationTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServiceClientGenerator.Endpoints;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using AWSSDK.UnitTests.TestTools;
namespace AWSSDK.UnitTests
{
    /// <summary>
    /// These tests test marshalling the put and get lifecycle configuration. 
    /// Since there is a lot of customization hooks in the generator, these tests
    /// make sure that those customization hooks generated the right marshallers.
    /// </summary>
    [TestClass]
    public class LifecycleConfigurationTests
    {
        private XmlUnmarshallerContext CreateLifecycleConfigurationResponse(GetLifecycleConfigurationResponse response)
        {
            var configuration = response.Configuration;
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("LifecycleConfiguration");
                //1
                foreach (var rule in configuration.Rules)
                {

                    xmlWriter.WriteStartElement("Rule");


                    xmlWriter.WriteStartElement("AbortIncompleteMultipartUpload");
                    xmlWriter.WriteElementString("DaysAfterInitiation", StringUtils.FromInt(rule.AbortIncompleteMultipartUpload.DaysAfterInitiation.Value));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Expiration");
                    xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(rule.Expiration.Date.Value));
                    xmlWriter.WriteElementString("Days", StringUtils.FromInt(rule.Expiration.Days.Value));
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteStartElement("Filter");

                    xmlWriter.WriteStartElement("And");
                    xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(rule.Filter.And.ObjectSizeGreaterThan.Value));
                    xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(rule.Filter.And.ObjectSizeLessThan.Value));
                    xmlWriter.WriteElementString("Prefix", rule.Filter.And.Prefix);

                    foreach(var tag in rule.Filter.And.Tags)
                    {
                        xmlWriter.WriteStartElement("Tag");
                        xmlWriter.WriteElementString("Key", tag.Key);
                        xmlWriter.WriteElementString("Value", tag.Value);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteElementString("ObjectSizeGreaterThan", StringUtils.FromLong(rule.Filter.ObjectSizeGreaterThan.Value));
                    xmlWriter.WriteElementString("ObjectSizeLessThan", StringUtils.FromLong(rule.Filter.ObjectSizeLessThan.Value));
                    xmlWriter.WriteElementString("Prefix", rule.Filter.Prefix);
                    xmlWriter.WriteStartElement("Tag");
                    xmlWriter.WriteElementString("Key", rule.Filter.Tag.Key);
                    xmlWriter.WriteElementString("Value", rule.Filter.Tag.Value);
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteElementString("ID", StringUtils.FromString(rule.Id));
                    xmlWriter.WriteStartElement("NoncurrentVersionExpiration");
                    xmlWriter.WriteElementString("NewerNoncurrentVersions", StringUtils.FromInt(rule.NoncurrentVersionExpiration.NewerNoncurrentVersions.Value));
                    xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(rule.NoncurrentVersionExpiration.NoncurrentDays.Value));
                    xmlWriter.WriteEndElement();
                    foreach(var nonCurrentVersionTransition in rule.NoncurrentVersionTransitions)
                    {
                        xmlWriter.WriteStartElement("NoncurrentVersionTransition");
                        xmlWriter.WriteElementString("NewerNoncurrentVersions", StringUtils.FromInt(nonCurrentVersionTransition.NewerNoncurrentVersions.Value));
                        xmlWriter.WriteElementString("NoncurrentDays", StringUtils.FromInt(nonCurrentVersionTransition.NoncurrentDays.Value));
                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(nonCurrentVersionTransition.StorageClass));
                        xmlWriter.WriteEndElement();
                    }
                    foreach(var transition in rule.Transitions)
                    {
                        xmlWriter.WriteStartElement("Transition");
                        xmlWriter.WriteElementString("Date", StringUtils.FromDateTimeToISO8601WithOptionalMs(transition.Date.Value));
                        xmlWriter.WriteElementString("Days", StringUtils.FromInt(transition.Days.Value));
                        xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(transition.StorageClass));
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();

                var content = stringWriter.ToString();
                var buffer = Encoding.UTF8.GetBytes(content);
                var memStream = new MemoryStream(buffer);
                var context = new XmlUnmarshallerContext(memStream, true, new WebResponseData());
                return context;
            }
        }
        [TestMethod]
        public void TestPutLifecycleConfiguration()
        {
            string iso8601 = "2025-07-30T12:34:56Z";
            DateTime dateTime = DateTime.Parse(iso8601, null, System.Globalization.DateTimeStyles.RoundtripKind);
            var request = new PutLifecycleConfigurationRequest
            {
                ChecksumAlgorithm = ChecksumAlgorithm.CRC32,
                BucketName = "testing123",
                Configuration = new LifecycleConfiguration
                {
                    Rules = new List<LifecycleRule>
                    {
                        new LifecycleRule
                        {
                            AbortIncompleteMultipartUpload = new LifecycleRuleAbortIncompleteMultipartUpload
                            {
                                DaysAfterInitiation = 20
                            },
                            Expiration = new LifecycleRuleExpiration
                            {
                                Date = dateTime,
                                Days = 20
                            },
                            Filter = new LifecycleFilter
                            {
                                And = new LifecycleRuleAndOperator
                                {
                                    ObjectSizeGreaterThan = 1000,
                                    ObjectSizeLessThan = 2000,
                                    Prefix = "foo",
                                    Tags = new List<Tag>
                                    {
                                        new Tag {Key="foo",Value="bar"}
                                    }
                                },
                                ObjectSizeGreaterThan = 3000,
                                ObjectSizeLessThan = 4000,
                                Prefix = "qux",
                                Tag = new Tag{Key="a",Value="b"}
                            },
                            Id = "1",
                            NoncurrentVersionExpiration = new LifecycleRuleNoncurrentVersionExpiration
                            {
                                NewerNoncurrentVersions = 10,
                                NoncurrentDays = 10
                            },
                            NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>
                            {
                                new LifecycleRuleNoncurrentVersionTransition
                                {
                                    NewerNoncurrentVersions = 1,
                                    NoncurrentDays = 1,
                                    StorageClass = S3StorageClass.Glacier,
                                },
                                new LifecycleRuleNoncurrentVersionTransition
                                {
                                    NewerNoncurrentVersions = 2,
                                    NoncurrentDays = 2,
                                    StorageClass = S3StorageClass.Glacier,
                                },
                            },
                            Transitions = new List<LifecycleTransition>
                            {
                                new LifecycleTransition
                                {
                                    Date = dateTime,
                                    Days = 10,
                                    StorageClass = S3StorageClass.Glacier,
                                },
                                new LifecycleTransition
                                {
                                    Date = dateTime,
                                    Days = 10,
                                    StorageClass = S3StorageClass.Glacier,
                                }
                            }
                        }
                    }
                },
            };
            IRequest iRequest = PutLifecycleConfigurationRequestMarshaller.Instance.Marshall(request);
            string content = Encoding.UTF8.GetString(iRequest.Content);
            XDocument actualDoc = XDocument.Parse(content);
            //raw string literals not available in lang version 9
            #region expectedBody
            string expectedBody = "<LifecycleConfiguration xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\"><Rule><AbortIncompleteMultipartUpload><DaysAfterInitiation>20</DaysAfterInitiation></AbortIncompleteMultipartUpload><Expiration><Date>2025-07-30T12:34:56Z</Date><Days>20</Days></Expiration><Filter><And><ObjectSizeGreaterThan>1000</ObjectSizeGreaterThan><ObjectSizeLessThan>2000</ObjectSizeLessThan><Prefix>foo</Prefix><Tag><Key>foo</Key><Value>bar</Value></Tag></And><ObjectSizeGreaterThan>3000</ObjectSizeGreaterThan><ObjectSizeLessThan>4000</ObjectSizeLessThan><Prefix>qux</Prefix><Tag><Key>a</Key><Value>b</Value></Tag></Filter><ID>1</ID><NoncurrentVersionExpiration><NewerNoncurrentVersions>10</NewerNoncurrentVersions><NoncurrentDays>10</NoncurrentDays></NoncurrentVersionExpiration><NoncurrentVersionTransition><NewerNoncurrentVersions>1</NewerNoncurrentVersions><NoncurrentDays>1</NoncurrentDays><StorageClass>GLACIER</StorageClass></NoncurrentVersionTransition><NoncurrentVersionTransition><NewerNoncurrentVersions>2</NewerNoncurrentVersions><NoncurrentDays>2</NoncurrentDays><StorageClass>GLACIER</StorageClass></NoncurrentVersionTransition><Transition><Date>2025-07-30T12:34:56Z</Date><Days>10</Days><StorageClass>GLACIER</StorageClass></Transition><Transition><Date>2025-07-30T12:34:56Z</Date><Days>10</Days><StorageClass>GLACIER</StorageClass></Transition><Status xmlns=\"http://s3.amazonaws.com/doc/2006-03-01/\">Disabled</Status></Rule></LifecycleConfiguration>";
            #endregion
            XDocument expectedDoc = XDocument.Parse(expectedBody);
            Assert.IsTrue(ComparisonUtils.AreDocumentsEqual(expectedDoc, actualDoc));
        }
    }
}
