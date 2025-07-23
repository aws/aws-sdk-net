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

/*
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlProtocol.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// XmlLists Request Marshaller
    /// </summary>       
    public partial class XmlListsRequestMarshaller : IMarshaller<IRequest, XmlListsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlListsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(XmlListsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            request.HttpMethod = "PUT";
            request.ResourcePath = "/XmlLists";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("XmlListsRequest", "");
                var publicRequestBooleanList = publicRequest.BooleanList;
                if (publicRequestBooleanList != null && (publicRequestBooleanList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("booleanList");
                    foreach (var publicRequestBooleanListValue in publicRequestBooleanList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestBooleanListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestEnumList = publicRequest.EnumList;
                if (publicRequestEnumList != null && (publicRequestEnumList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("enumList");
                    foreach (var publicRequestEnumListValue in publicRequestEnumList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestEnumListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestFlattenedList = publicRequest.FlattenedList;
                if (publicRequestFlattenedList != null && (publicRequestFlattenedList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    foreach (var publicRequestFlattenedListValue in publicRequestFlattenedList) 
                    {
                        xmlWriter.WriteStartElement("flattenedList");
                        xmlWriter.WriteValue(publicRequestFlattenedListValue);
                        xmlWriter.WriteEndElement();
                    }            
                }
                var publicRequestFlattenedList2 = publicRequest.FlattenedList2;
                if (publicRequestFlattenedList2 != null && (publicRequestFlattenedList2.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    foreach (var publicRequestFlattenedList2Value in publicRequestFlattenedList2) 
                    {
                        xmlWriter.WriteStartElement("customName");
                        xmlWriter.WriteValue(publicRequestFlattenedList2Value);
                        xmlWriter.WriteEndElement();
                    }            
                }
                var publicRequestFlattenedListWithMemberNamespace = publicRequest.FlattenedListWithMemberNamespace;
                if (publicRequestFlattenedListWithMemberNamespace != null && (publicRequestFlattenedListWithMemberNamespace.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    foreach (var publicRequestFlattenedListWithMemberNamespaceValue in publicRequestFlattenedListWithMemberNamespace) 
                    {
                        xmlWriter.WriteStartElement("flattenedListWithMemberNamespace", "https://xml-member.example.com");

                        xmlWriter.WriteValue(publicRequestFlattenedListWithMemberNamespaceValue);
                        xmlWriter.WriteEndElement();
                    }            
                }
                var publicRequestFlattenedListWithNamespace = publicRequest.FlattenedListWithNamespace;
                if (publicRequestFlattenedListWithNamespace != null && (publicRequestFlattenedListWithNamespace.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    foreach (var publicRequestFlattenedListWithNamespaceValue in publicRequestFlattenedListWithNamespace) 
                    {
                        xmlWriter.WriteStartElement("flattenedListWithNamespace");
                        xmlWriter.WriteValue(publicRequestFlattenedListWithNamespaceValue);
                        xmlWriter.WriteEndElement();
                    }            
                }
                var publicRequestFlattenedStructureList = publicRequest.FlattenedStructureList;
                if (publicRequestFlattenedStructureList != null && (publicRequestFlattenedStructureList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    foreach (var publicRequestFlattenedStructureListValue in publicRequestFlattenedStructureList) 
                    {
                    if (publicRequestFlattenedStructureListValue != null)
                    {
                        xmlWriter.WriteStartElement("flattenedStructureList");
                        if(publicRequestFlattenedStructureListValue.IsSetA())
                            xmlWriter.WriteElementString("value", StringUtils.FromString(publicRequestFlattenedStructureListValue.A));
                        if(publicRequestFlattenedStructureListValue.IsSetB())
                            xmlWriter.WriteElementString("other", StringUtils.FromString(publicRequestFlattenedStructureListValue.B));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                }
                var publicRequestIntegerList = publicRequest.IntegerList;
                if (publicRequestIntegerList != null && (publicRequestIntegerList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("integerList");
                    foreach (var publicRequestIntegerListValue in publicRequestIntegerList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestIntegerListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestIntEnumList = publicRequest.IntEnumList;
                if (publicRequestIntEnumList != null && (publicRequestIntEnumList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("intEnumList");
                    foreach (var publicRequestIntEnumListValue in publicRequestIntEnumList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestIntEnumListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestNestedStringList = publicRequest.NestedStringList;
                if (publicRequestNestedStringList != null && (publicRequestNestedStringList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("nestedStringList");
                    foreach (var publicRequestNestedStringListValue in publicRequestNestedStringList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        foreach (var publicRequestNestedStringListValueInnerValue in publicRequestNestedStringListValue)
                        {
                            xmlWriter.WriteStartElement("member");
                            xmlWriter.WriteValue(publicRequestNestedStringListValueInnerValue);
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestRenamedListMembers = publicRequest.RenamedListMembers;
                if (publicRequestRenamedListMembers != null && (publicRequestRenamedListMembers.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("renamed");
                    foreach (var publicRequestRenamedListMembersValue in publicRequestRenamedListMembers) 
                    {
                        xmlWriter.WriteStartElement("item");
                        xmlWriter.WriteValue(publicRequestRenamedListMembersValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestStringList = publicRequest.StringList;
                if (publicRequestStringList != null && (publicRequestStringList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("stringList");
                    foreach (var publicRequestStringListValue in publicRequestStringList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestStringListValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestStringSet = publicRequest.StringSet;
                if (publicRequestStringSet != null && (publicRequestStringSet.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("stringSet");
                    foreach (var publicRequestStringSetValue in publicRequestStringSet) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(publicRequestStringSetValue);
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestStructureList = publicRequest.StructureList;
                if (publicRequestStructureList != null && (publicRequestStructureList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("myStructureList");
                    foreach (var publicRequestStructureListValue in publicRequestStructureList) 
                    {
                    if (publicRequestStructureListValue != null)
                    {
                        xmlWriter.WriteStartElement("item");
                        if(publicRequestStructureListValue.IsSetA())
                            xmlWriter.WriteElementString("value", StringUtils.FromString(publicRequestStructureListValue.A));
                        if(publicRequestStructureListValue.IsSetB())
                            xmlWriter.WriteElementString("other", StringUtils.FromString(publicRequestStructureListValue.B));
                        xmlWriter.WriteEndElement();
                    }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestTimestampList = publicRequest.TimestampList;
                if (publicRequestTimestampList != null && (publicRequestTimestampList.Count > 0 || !AWSConfigs.InitializeCollections)) 
                {
                    xmlWriter.WriteStartElement("timestampList");
                    foreach (var publicRequestTimestampListValue in publicRequestTimestampList) 
                    {
                        xmlWriter.WriteStartElement("member");
                        xmlWriter.WriteValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestTimestampListValue));
                        xmlWriter.WriteEndElement();
                    }            
                    xmlWriter.WriteEndElement();            
                }

                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static XmlListsRequestMarshaller _instance = new XmlListsRequestMarshaller();        

        internal static XmlListsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static XmlListsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, XmlListsRequest publicRequest);
    }    
}