/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Request Marshaller for PutAnalyticsConfiguration operation
    /// </summary> 
    public class PutBucketAnalyticsConfigurationRequestMarshaller : IMarshaller<IRequest, PutBucketAnalyticsConfigurationRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBucketAnalyticsConfigurationRequest)input);
        }
        public IRequest Marshall(PutBucketAnalyticsConfigurationRequest putBucketAnalyticsConfigurationRequest)
        {
            IRequest request = new DefaultRequest(putBucketAnalyticsConfigurationRequest, "AmazonS3");

            request.HttpMethod = "PUT";

            request.ResourcePath = string.Concat("/", S3Transforms.ToStringValue(putBucketAnalyticsConfigurationRequest.BucketName));

            request.AddSubResource("analytics");

            if (putBucketAnalyticsConfigurationRequest.IsSetAnalyticsId())
            {
                request.AddSubResource("id", S3Transforms.ToStringValue(putBucketAnalyticsConfigurationRequest.AnalyticsId));
            }

            var stringWriter = new StringWriter(System.Globalization.CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                if (putBucketAnalyticsConfigurationRequest.IsSetAnalyticsConfiguration())
                {
                    var analyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
                    xmlWriter.WriteStartElement("AnalyticsConfiguration", "http://s3.amazonaws.com/doc/2006-03-01/");
                    if (analyticsConfiguration.IsSetAnalyticsId())
                    {
                        xmlWriter.WriteElementString("Id", "http://s3.amazonaws.com/doc/2006-03-01/", analyticsConfiguration.AnalyticsId);
                    }
                    if (analyticsConfiguration.IsSetAnalyticsFilter())
                    {
                        xmlWriter.WriteStartElement("Filter", "http://s3.amazonaws.com/doc/2006-03-01/");
                        var predicate = analyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate;
                        predicate.Accept(new AnalyticsPredicateVisitor(xmlWriter));
                        xmlWriter.WriteEndElement();
                    }
                    if (analyticsConfiguration.IsSetStorageClassAnalysis())
                    {
                        if (analyticsConfiguration.IsSetStorageClassAnalysis())
                        {
                            StorageClassAnalysis storageClassAnalysis = analyticsConfiguration.StorageClassAnalysis;
                            xmlWriter.WriteStartElement("StorageClassAnalysis", "http://s3.amazonaws.com/doc/2006-03-01/");
                            if (storageClassAnalysis.IsSetDataExport())
                            {
                                xmlWriter.WriteStartElement("DataExport", "http://s3.amazonaws.com/doc/2006-03-01/");
                                StorageClassAnalysisDataExport storageClassAnalysisDataExport = storageClassAnalysis.DataExport;
                                if(storageClassAnalysisDataExport.IsSetOutputSchemaVersion())
                                {
                                    StorageClassAnalysisSchemaVersion storageClassAnalysisSchemaVersion = storageClassAnalysisDataExport.OutputSchemaVersion;
                                    if (storageClassAnalysisSchemaVersion != null)
                                    {
                                        xmlWriter.WriteElementString("OutputSchemaVersion", "http://s3.amazonaws.com/doc/2006-03-01/", storageClassAnalysisSchemaVersion);
                                    }
                                }
                                if (storageClassAnalysisDataExport.IsSetDestination())
                                {
                                    xmlWriter.WriteStartElement("Destination", "http://s3.amazonaws.com/doc/2006-03-01/");
                                    AnalyticsExportDestination analyticsExportDestination = storageClassAnalysisDataExport.Destination;
                                    if (analyticsExportDestination.IsSetS3BucketDestination())
                                    {
                                        xmlWriter.WriteStartElement("S3BucketDestination", "http://s3.amazonaws.com/doc/2006-03-01/");
                                        AnalyticsS3BucketDestination analyticsS3BucketDestination = analyticsExportDestination.S3BucketDestination;
                                        if (analyticsS3BucketDestination.IsSetFormat())
                                        {
                                            xmlWriter.WriteElementString("Format", "http://s3.amazonaws.com/doc/2006-03-01/", analyticsS3BucketDestination.Format);
                                        }
                                        if (analyticsS3BucketDestination.IsSetBucketAccountId())
                                        {
                                            xmlWriter.WriteElementString("BucketAccountId", "http://s3.amazonaws.com/doc/2006-03-01/", analyticsS3BucketDestination.BucketAccountId);
                                        }
                                        if (analyticsS3BucketDestination.IsSetBucketName())
                                        {
                                            xmlWriter.WriteElementString("Bucket", "http://s3.amazonaws.com/doc/2006-03-01/", analyticsS3BucketDestination.BucketName);
                                        }
                                        if (analyticsS3BucketDestination.IsSetPrefix())
                                        {
                                            xmlWriter.WriteElementString("Prefix", "http://s3.amazonaws.com/doc/2006-03-01/", analyticsS3BucketDestination.Prefix);
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
            }

            try
            {
                var content = stringWriter.ToString();
                request.Content = Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                var checksum = AmazonS3Util.GenerateChecksumForContent(content, true);
                request.Headers[HeaderKeys.ContentMD5Header] = checksum;

            }
            catch (EncoderFallbackException e)
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }


        private static PutBucketAnalyticsConfigurationRequestMarshaller _instance;

        public static PutBucketAnalyticsConfigurationRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutBucketAnalyticsConfigurationRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
