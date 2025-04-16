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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelectObjectContent Request Marshaller
    /// </summary>       
    public class SelectObjectContentRequestMarshaller : IMarshaller<IRequest, SelectObjectContentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SelectObjectContentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SelectObjectContentRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            request.HttpMethod = "POST";
            request.AddSubResource("select");
            request.AddSubResource("select-type", "2");
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetSSECustomerAlgorithm()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-algorithm"] = publicRequest.SSECustomerAlgorithm;
            }
        
            if (publicRequest.IsSetSSECustomerKey()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key"] = publicRequest.SSECustomerKey;
            }
        
            if (publicRequest.IsSetSSECustomerKeyMD5()) 
            {
                request.Headers["x-amz-server-side-encryption-customer-key-MD5"] = publicRequest.SSECustomerKeyMD5;
            }
            if (!publicRequest.IsSetBucketName())
                throw new AmazonS3Exception("Request object does not have required field BucketName set");
            request.AddPathResource("{Bucket}", StringUtils.FromString(publicRequest.BucketName));
            if (!publicRequest.IsSetKey())
                throw new AmazonS3Exception("Request object does not have required field Key set");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key.TrimStart('/')));
            request.ResourcePath = "/{Bucket}/{Key+}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                xmlWriter.WriteStartElement("SelectObjectContentRequest", "http://s3.amazonaws.com/doc/2006-03-01/");
                if(publicRequest.IsSetExpression())
                    xmlWriter.WriteElementString("Expression", StringUtils.FromString(publicRequest.Expression));

                if(publicRequest.IsSetExpressionType())
                    xmlWriter.WriteElementString("ExpressionType", StringUtils.FromString(publicRequest.ExpressionType));

                if (publicRequest.InputSerialization != null)
                {
                    xmlWriter.WriteStartElement("InputSerialization");
                    if(publicRequest.InputSerialization.IsSetCompressionType())
                        xmlWriter.WriteElementString("CompressionType", StringUtils.FromString(publicRequest.InputSerialization.CompressionType));
                    if (publicRequest.InputSerialization.CSV != null)
                    {
                        xmlWriter.WriteStartElement("CSV");
                        if(publicRequest.InputSerialization.CSV.IsSetAllowQuotedRecordDelimiter())
                            xmlWriter.WriteElementString("AllowQuotedRecordDelimiter", StringUtils.FromBool(publicRequest.InputSerialization.CSV.AllowQuotedRecordDelimiter.Value));
                        if(publicRequest.InputSerialization.CSV.IsSetComments())
                            xmlWriter.WriteElementString("Comments", StringUtils.FromString(publicRequest.InputSerialization.CSV.Comments));
                        if(publicRequest.InputSerialization.CSV.IsSetFieldDelimiter())
                            xmlWriter.WriteElementString("FieldDelimiter", StringUtils.FromString(publicRequest.InputSerialization.CSV.FieldDelimiter));
                        if(publicRequest.InputSerialization.CSV.IsSetFileHeaderInfo())
                            xmlWriter.WriteElementString("FileHeaderInfo", StringUtils.FromString(publicRequest.InputSerialization.CSV.FileHeaderInfo));
                        if(publicRequest.InputSerialization.CSV.IsSetQuoteCharacter())
                            xmlWriter.WriteElementString("QuoteCharacter", StringUtils.FromString(publicRequest.InputSerialization.CSV.QuoteCharacter));
                        if(publicRequest.InputSerialization.CSV.IsSetQuoteEscapeCharacter())
                            xmlWriter.WriteElementString("QuoteEscapeCharacter", StringUtils.FromString(publicRequest.InputSerialization.CSV.QuoteEscapeCharacter));
                        if(publicRequest.InputSerialization.CSV.IsSetRecordDelimiter())
                            xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.InputSerialization.CSV.RecordDelimiter));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.InputSerialization.JSON != null)
                    {
                        xmlWriter.WriteStartElement("JSON");
                        if(publicRequest.InputSerialization.JSON.IsSetType())
                            xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.InputSerialization.JSON.Type));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.InputSerialization.Parquet != null)
                    {
                        xmlWriter.WriteStartElement("Parquet");
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.OutputSerialization != null)
                {
                    xmlWriter.WriteStartElement("OutputSerialization");
                    if (publicRequest.OutputSerialization.CSV != null)
                    {
                        xmlWriter.WriteStartElement("CSV");
                        if(publicRequest.OutputSerialization.CSV.IsSetFieldDelimiter())
                            xmlWriter.WriteElementString("FieldDelimiter", StringUtils.FromString(publicRequest.OutputSerialization.CSV.FieldDelimiter));
                        if(publicRequest.OutputSerialization.CSV.IsSetQuoteCharacter())
                            xmlWriter.WriteElementString("QuoteCharacter", StringUtils.FromString(publicRequest.OutputSerialization.CSV.QuoteCharacter));
                        if(publicRequest.OutputSerialization.CSV.IsSetQuoteEscapeCharacter())
                            xmlWriter.WriteElementString("QuoteEscapeCharacter", StringUtils.FromString(publicRequest.OutputSerialization.CSV.QuoteEscapeCharacter));
                        if(publicRequest.OutputSerialization.CSV.IsSetQuoteFields())
                            xmlWriter.WriteElementString("QuoteFields", StringUtils.FromString(publicRequest.OutputSerialization.CSV.QuoteFields));
                        if(publicRequest.OutputSerialization.CSV.IsSetRecordDelimiter())
                            xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.OutputSerialization.CSV.RecordDelimiter));
                        xmlWriter.WriteEndElement();
                    }
                    if (publicRequest.OutputSerialization.JSON != null)
                    {
                        xmlWriter.WriteStartElement("JSON");
                        if(publicRequest.OutputSerialization.JSON.IsSetRecordDelimiter())
                            xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.OutputSerialization.JSON.RecordDelimiter));
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.RequestProgress != null)
                {
                    xmlWriter.WriteStartElement("RequestProgress");
                    if(publicRequest.RequestProgress.IsSetEnabled())
                        xmlWriter.WriteElementString("Enabled", StringUtils.FromBool(publicRequest.RequestProgress.Enabled.Value));
                    xmlWriter.WriteEndElement();
                }
                if (publicRequest.ScanRange != null)
                {
                    xmlWriter.WriteStartElement("ScanRange");
                    if(publicRequest.ScanRange.IsSetEnd())
                        xmlWriter.WriteElementString("End", StringUtils.FromLong(publicRequest.ScanRange.End.Value));
                    if(publicRequest.ScanRange.IsSetStart())
                        xmlWriter.WriteElementString("Start", StringUtils.FromLong(publicRequest.ScanRange.Start.Value));
                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static SelectObjectContentRequestMarshaller _instance = new SelectObjectContentRequestMarshaller();        

        internal static SelectObjectContentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SelectObjectContentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}