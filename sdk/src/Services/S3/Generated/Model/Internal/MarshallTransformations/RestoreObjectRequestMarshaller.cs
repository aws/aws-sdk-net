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
    /// RestoreObject Request Marshaller
    /// </summary>       
    public partial class RestoreObjectRequestMarshaller : IMarshaller<IRequest, RestoreObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreObjectRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.S3");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.AddSubResource("restore");
        
            if (publicRequest.IsSetChecksumAlgorithm()) 
            {
                request.Headers["x-amz-sdk-checksum-algorithm"] = publicRequest.ChecksumAlgorithm;
            }
        
            if (publicRequest.IsSetExpectedBucketOwner()) 
            {
                request.Headers["x-amz-expected-bucket-owner"] = publicRequest.ExpectedBucketOwner;
            }
        
            if (publicRequest.IsSetRequestPayer()) 
            {
                request.Headers["x-amz-request-payer"] = publicRequest.RequestPayer;
            }
            if (string.IsNullOrEmpty(publicRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "RestoreObjectRequest.BucketName");
            if (string.IsNullOrEmpty(publicRequest.Key))
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "RestoreObjectRequest.Key");
            request.AddPathResource("{Key+}", StringUtils.FromString(publicRequest.Key));
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.ResourcePath = "/{Key+}";
            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                    xmlWriter.WriteStartElement("RestoreRequest", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if(publicRequest.IsSetDays())
                        xmlWriter.WriteElementString("Days", StringUtils.FromInt(publicRequest.Days.Value));

                    if(publicRequest.IsSetDescription())
                        xmlWriter.WriteElementString("Description", StringUtils.FromString(publicRequest.Description));

                    TierCustomMarshall(xmlWriter, publicRequest);
                    if (publicRequest.IsSetOutputLocation())
                    {
                        xmlWriter.WriteStartElement("OutputLocation");
                        if (publicRequest.OutputLocation.IsSetS3())
                        {
                            xmlWriter.WriteStartElement("S3");
                            AccessControlListCustomMarshall(xmlWriter, publicRequest);
                            if(publicRequest.OutputLocation.S3.IsSetBucketName())
                                xmlWriter.WriteElementString("BucketName", StringUtils.FromString(publicRequest.OutputLocation.S3.BucketName));
                            if(publicRequest.OutputLocation.S3.IsSetCannedACL())
                                xmlWriter.WriteElementString("CannedACL", StringUtils.FromString(publicRequest.OutputLocation.S3.CannedACL));
                            if (publicRequest.OutputLocation.S3.IsSetEncryption())
                            {
                                xmlWriter.WriteStartElement("Encryption");
                                if(publicRequest.OutputLocation.S3.Encryption.IsSetEncryptionType())
                                    xmlWriter.WriteElementString("EncryptionType", StringUtils.FromString(publicRequest.OutputLocation.S3.Encryption.EncryptionType));
                                if(publicRequest.OutputLocation.S3.Encryption.IsSetKMSContext())
                                    xmlWriter.WriteElementString("KMSContext", StringUtils.FromString(publicRequest.OutputLocation.S3.Encryption.KMSContext));
                                if(publicRequest.OutputLocation.S3.Encryption.IsSetKMSKeyId())
                                    xmlWriter.WriteElementString("KMSKeyId", StringUtils.FromString(publicRequest.OutputLocation.S3.Encryption.KMSKeyId));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequest.OutputLocation.S3.IsSetPrefix())
                                xmlWriter.WriteElementString("Prefix", StringUtils.FromString(publicRequest.OutputLocation.S3.Prefix));
                            if(publicRequest.OutputLocation.S3.IsSetStorageClass())
                                xmlWriter.WriteElementString("StorageClass", StringUtils.FromString(publicRequest.OutputLocation.S3.StorageClass));
                            if (publicRequest.OutputLocation.S3.IsSetTagging())
                            {
                                xmlWriter.WriteStartElement("Tagging");
                                var publicRequestOutputLocationS3TaggingTagSet = publicRequest.OutputLocation.S3.Tagging.TagSet;
                                if (publicRequest.OutputLocation.S3.Tagging.IsSetTagSet()) 
                                {
                                    xmlWriter.WriteStartElement("TagSet");
                                    foreach (var publicRequestOutputLocationS3TaggingTagSetValue in publicRequestOutputLocationS3TaggingTagSet) 
                                    {
                                        if (publicRequestOutputLocationS3TaggingTagSetValue != null)
                                        {
                                            xmlWriter.WriteStartElement("Tag");
                                            if(publicRequestOutputLocationS3TaggingTagSetValue.IsSetKey())
                                                xmlWriter.WriteElementString("Key", StringUtils.FromString(publicRequestOutputLocationS3TaggingTagSetValue.Key));
                                            if(publicRequestOutputLocationS3TaggingTagSetValue.IsSetValue())
                                                xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestOutputLocationS3TaggingTagSetValue.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                    }            
                                    xmlWriter.WriteEndElement();            
                                }
                                xmlWriter.WriteEndElement();
                            }
                            UserMetadataCustomMarshall(xmlWriter, publicRequest);
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
                    if(publicRequest.IsSetRestoreRequestType())
                        xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.RestoreRequestType));

                    if(publicRequest.IsSetRetrievalTier())
                        xmlWriter.WriteElementString("Tier", StringUtils.FromString(publicRequest.RetrievalTier));

                    if (publicRequest.IsSetSelectParameters())
                    {
                        xmlWriter.WriteStartElement("SelectParameters");
                        if(publicRequest.SelectParameters.IsSetExpression())
                            xmlWriter.WriteElementString("Expression", StringUtils.FromString(publicRequest.SelectParameters.Expression));
                        if(publicRequest.SelectParameters.IsSetExpressionType())
                            xmlWriter.WriteElementString("ExpressionType", StringUtils.FromString(publicRequest.SelectParameters.ExpressionType));
                        if (publicRequest.SelectParameters.IsSetInputSerialization())
                        {
                            xmlWriter.WriteStartElement("InputSerialization");
                            if(publicRequest.SelectParameters.InputSerialization.IsSetCompressionType())
                                xmlWriter.WriteElementString("CompressionType", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CompressionType));
                            if (publicRequest.SelectParameters.InputSerialization.IsSetCSV())
                            {
                                xmlWriter.WriteStartElement("CSV");
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetAllowQuotedRecordDelimiter())
                                    xmlWriter.WriteElementString("AllowQuotedRecordDelimiter", StringUtils.FromBool(publicRequest.SelectParameters.InputSerialization.CSV.AllowQuotedRecordDelimiter.Value));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetComments())
                                    xmlWriter.WriteElementString("Comments", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.Comments));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetFieldDelimiter())
                                    xmlWriter.WriteElementString("FieldDelimiter", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.FieldDelimiter));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetFileHeaderInfo())
                                    xmlWriter.WriteElementString("FileHeaderInfo", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.FileHeaderInfo));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetQuoteCharacter())
                                    xmlWriter.WriteElementString("QuoteCharacter", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.QuoteCharacter));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetQuoteEscapeCharacter())
                                    xmlWriter.WriteElementString("QuoteEscapeCharacter", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.QuoteEscapeCharacter));
                                if(publicRequest.SelectParameters.InputSerialization.CSV.IsSetRecordDelimiter())
                                    xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.CSV.RecordDelimiter));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.SelectParameters.InputSerialization.IsSetJSON())
                            {
                                xmlWriter.WriteStartElement("JSON");
                                if(publicRequest.SelectParameters.InputSerialization.JSON.IsSetJsonType())
                                    xmlWriter.WriteElementString("Type", StringUtils.FromString(publicRequest.SelectParameters.InputSerialization.JSON.JsonType));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.SelectParameters.InputSerialization.IsSetParquet())
                            {
                                xmlWriter.WriteStartElement("Parquet");
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                        if (publicRequest.SelectParameters.IsSetOutputSerialization())
                        {
                            xmlWriter.WriteStartElement("OutputSerialization");
                            if (publicRequest.SelectParameters.OutputSerialization.IsSetCSV())
                            {
                                xmlWriter.WriteStartElement("CSV");
                                if(publicRequest.SelectParameters.OutputSerialization.CSV.IsSetFieldDelimiter())
                                    xmlWriter.WriteElementString("FieldDelimiter", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.CSV.FieldDelimiter));
                                if(publicRequest.SelectParameters.OutputSerialization.CSV.IsSetQuoteCharacter())
                                    xmlWriter.WriteElementString("QuoteCharacter", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.CSV.QuoteCharacter));
                                if(publicRequest.SelectParameters.OutputSerialization.CSV.IsSetQuoteEscapeCharacter())
                                    xmlWriter.WriteElementString("QuoteEscapeCharacter", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.CSV.QuoteEscapeCharacter));
                                if(publicRequest.SelectParameters.OutputSerialization.CSV.IsSetQuoteFields())
                                    xmlWriter.WriteElementString("QuoteFields", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.CSV.QuoteFields));
                                if(publicRequest.SelectParameters.OutputSerialization.CSV.IsSetRecordDelimiter())
                                    xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.CSV.RecordDelimiter));
                                xmlWriter.WriteEndElement();
                            }
                            if (publicRequest.SelectParameters.OutputSerialization.IsSetJSON())
                            {
                                xmlWriter.WriteStartElement("JSON");
                                if(publicRequest.SelectParameters.OutputSerialization.JSON.IsSetRecordDelimiter())
                                    xmlWriter.WriteElementString("RecordDelimiter", StringUtils.FromString(publicRequest.SelectParameters.OutputSerialization.JSON.RecordDelimiter));
                                xmlWriter.WriteEndElement();
                            }
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
                ChecksumUtils.SetChecksumData(
                    request,
                    publicRequest.ChecksumAlgorithm,
                    fallbackToMD5: false,
                    isRequestChecksumRequired: false,
                    headerName: "x-amz-sdk-checksum-algorithm"
                );
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2006-03-01";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            request.UseQueryString = true;
            return request;
        }
        private static RestoreObjectRequestMarshaller _instance = new RestoreObjectRequestMarshaller();        

        internal static RestoreObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, RestoreObjectRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, RestoreObjectRequest publicRequest);
    }    
}