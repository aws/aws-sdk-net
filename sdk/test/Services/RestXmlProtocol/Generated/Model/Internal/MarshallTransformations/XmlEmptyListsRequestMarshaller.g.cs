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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.RestXmlProtocol.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RestXmlProtocol.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// XmlEmptyLists Request Marshaller
    /// </summary>
    public partial class XmlEmptyListsRequestMarshaller : IMarshaller<IRequest, XmlEmptyListsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((XmlEmptyListsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(XmlEmptyListsRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlProtocol");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "PUT";

            request.ResourcePath = "/XmlEmptyLists";

#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            var bufferTextWriter = new XMLEncodedBufferTextWriter(((PooledContentStream)request.ContentStream).BufferWriter);
            using (var xmlWriter = XmlWriter.Create(bufferTextWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#else
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {
#endif
                var context = new XmlMarshallerContext(request, xmlWriter);
                context.Writer.WriteStartElement("XmlEmptyListsRequest");
                if (publicRequest.IsSetBooleanList())
                {
                    var publicRequestBooleanList = publicRequest.BooleanList;
                    context.Writer.WriteStartElement("booleanList");
                    foreach (var publicRequestBooleanListValue in publicRequestBooleanList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromBool(publicRequestBooleanListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetEnumList())
                {
                    var publicRequestEnumList = publicRequest.EnumList;
                    context.Writer.WriteStartElement("enumList");
                    foreach (var publicRequestEnumListValue in publicRequestEnumList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(publicRequestEnumListValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetFlattenedList())
                {
                    var publicRequestFlattenedList = publicRequest.FlattenedList;
                    foreach (var publicRequestFlattenedListValue in publicRequestFlattenedList)
                    {
                        context.Writer.WriteStartElement("flattenedList");
                        context.Writer.WriteValue(publicRequestFlattenedListValue);
                        context.Writer.WriteEndElement();
                    }
                }
                if (publicRequest.IsSetFlattenedList2())
                {
                    var publicRequestFlattenedList2 = publicRequest.FlattenedList2;
                    foreach (var publicRequestFlattenedList2Value in publicRequestFlattenedList2)
                    {
                        context.Writer.WriteStartElement("customName");
                        context.Writer.WriteValue(publicRequestFlattenedList2Value);
                        context.Writer.WriteEndElement();
                    }
                }
                if (publicRequest.IsSetFlattenedListWithMemberNamespace())
                {
                    var publicRequestFlattenedListWithMemberNamespace = publicRequest.FlattenedListWithMemberNamespace;
                    foreach (var publicRequestFlattenedListWithMemberNamespaceValue in publicRequestFlattenedListWithMemberNamespace)
                    {
                        context.Writer.WriteStartElement("flattenedListWithMemberNamespace");
                        context.Writer.WriteValue(publicRequestFlattenedListWithMemberNamespaceValue);
                        context.Writer.WriteEndElement();
                    }
                }
                if (publicRequest.IsSetFlattenedListWithNamespace())
                {
                    var publicRequestFlattenedListWithNamespace = publicRequest.FlattenedListWithNamespace;
                    foreach (var publicRequestFlattenedListWithNamespaceValue in publicRequestFlattenedListWithNamespace)
                    {
                        context.Writer.WriteStartElement("flattenedListWithNamespace");
                        context.Writer.WriteValue(publicRequestFlattenedListWithNamespaceValue);
                        context.Writer.WriteEndElement();
                    }
                }
                if (publicRequest.IsSetFlattenedStructureList())
                {
                    var publicRequestFlattenedStructureList = publicRequest.FlattenedStructureList;
                    foreach (var publicRequestFlattenedStructureListValue in publicRequestFlattenedStructureList)
                    {
                        if (publicRequestFlattenedStructureListValue != null)
                        {
                            context.Writer.WriteStartElement("flattenedStructureList");
                            StructureListMemberMarshaller.Instance.Marshall(publicRequestFlattenedStructureListValue, context);
                            context.Writer.WriteEndElement();
                        }
                    }
                }
                if (publicRequest.IsSetIntEnumList())
                {
                    var publicRequestIntEnumList = publicRequest.IntEnumList;
                    context.Writer.WriteStartElement("intEnumList");
                    foreach (var publicRequestIntEnumListValue in publicRequestIntEnumList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromInt(publicRequestIntEnumListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetIntegerList())
                {
                    var publicRequestIntegerList = publicRequest.IntegerList;
                    context.Writer.WriteStartElement("integerList");
                    foreach (var publicRequestIntegerListValue in publicRequestIntegerList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromInt(publicRequestIntegerListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetNestedStringList())
                {
                    var publicRequestNestedStringList = publicRequest.NestedStringList;
                    context.Writer.WriteStartElement("nestedStringList");
                    foreach (var publicRequestNestedStringListValue in publicRequestNestedStringList)
                    {
                        context.Writer.WriteStartElement("member");
                        foreach (var item1 in publicRequestNestedStringListValue)
                        {
                            context.Writer.WriteStartElement("member");
                            context.Writer.WriteValue(item1);
                            context.Writer.WriteEndElement();
                        }
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetRenamedListMembers())
                {
                    var publicRequestRenamedListMembers = publicRequest.RenamedListMembers;
                    context.Writer.WriteStartElement("renamed");
                    foreach (var publicRequestRenamedListMembersValue in publicRequestRenamedListMembers)
                    {
                        context.Writer.WriteStartElement("item");
                        context.Writer.WriteValue(publicRequestRenamedListMembersValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetStringList())
                {
                    var publicRequestStringList = publicRequest.StringList;
                    context.Writer.WriteStartElement("stringList");
                    foreach (var publicRequestStringListValue in publicRequestStringList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(publicRequestStringListValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetStringSet())
                {
                    var publicRequestStringSet = publicRequest.StringSet;
                    context.Writer.WriteStartElement("stringSet");
                    foreach (var publicRequestStringSetValue in publicRequestStringSet)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(publicRequestStringSetValue);
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetStructureList())
                {
                    var publicRequestStructureList = publicRequest.StructureList;
                    context.Writer.WriteStartElement("myStructureList");
                    foreach (var publicRequestStructureListValue in publicRequestStructureList)
                    {
                        if (publicRequestStructureListValue != null)
                        {
                            context.Writer.WriteStartElement("item");
                            StructureListMemberMarshaller.Instance.Marshall(publicRequestStructureListValue, context);
                            context.Writer.WriteEndElement();
                        }
                    }
                    context.Writer.WriteEndElement();
                }
                if (publicRequest.IsSetTimestampList())
                {
                    var publicRequestTimestampList = publicRequest.TimestampList;
                    context.Writer.WriteStartElement("timestampList");
                    foreach (var publicRequestTimestampListValue in publicRequestTimestampList)
                    {
                        context.Writer.WriteStartElement("member");
                        context.Writer.WriteValue(StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestTimestampListValue));
                        context.Writer.WriteEndElement();
                    }
                    context.Writer.WriteEndElement();
                }
                context.Writer.WriteEndElement();
            }
            try
            {
#if NETFRAMEWORK
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
#endif
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-16";
            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            PostMarshallCustomization(request, publicRequest);
            return request;
        }

        private static readonly XmlEmptyListsRequestMarshaller _instance = new();

        internal static XmlEmptyListsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static XmlEmptyListsRequestMarshaller Instance => _instance;

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, XmlEmptyListsRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, XmlEmptyListsRequest publicRequest);
    }
}
