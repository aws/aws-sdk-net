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
 * Do not modify this file. This file is generated from the restxmldataplane-1999-12-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RestXmlDataPlane.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

#pragma warning disable CS0612,CS0618
namespace Amazon.RestXmlDataPlane.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutMetricData Request Marshaller
    /// </summary>       
    public partial class PutMetricDataRequestMarshaller : IMarshaller<IRequest, PutMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutMetricDataRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlDataPlane");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.ResourcePath = "/PutMetricData";

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
                xmlWriter.WriteStartElement("PutMetricDataInput", "https://awsrestxmldataplane.amazonaws.com");
                var publicRequestEntityMetricData = publicRequest.EntityMetricData;
                if (publicRequest.IsSetEntityMetricData()) 
                {
                    xmlWriter.WriteStartElement("EntityMetricData");
                    foreach (var publicRequestEntityMetricDataValue in publicRequestEntityMetricData) 
                    {
                        if (publicRequestEntityMetricDataValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            if (publicRequestEntityMetricDataValue.IsSetEntity())
                            {
                                xmlWriter.WriteStartElement("Entity");
                                if (publicRequestEntityMetricDataValue.Entity.IsSetAttributes())
                                {
                                    xmlWriter.WriteStartElement("Attributes");
                                    foreach (var kvp in publicRequestEntityMetricDataValue.Entity.Attributes)
                                    {
                                        xmlWriter.WriteStartElement("entry");

                                        xmlWriter.WriteElementString("key", kvp.Key);
                                        xmlWriter.WriteElementString("value", kvp.Value);
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                if (publicRequestEntityMetricDataValue.Entity.IsSetKeyAttributes())
                                {
                                    xmlWriter.WriteStartElement("KeyAttributes");
                                    foreach (var kvp in publicRequestEntityMetricDataValue.Entity.KeyAttributes)
                                    {
                                        xmlWriter.WriteStartElement("entry");

                                        xmlWriter.WriteElementString("key", kvp.Key);
                                        xmlWriter.WriteElementString("value", kvp.Value);
                                        xmlWriter.WriteEndElement();
                                    }
                                    xmlWriter.WriteEndElement();
                                }
                                xmlWriter.WriteEndElement();
                            }
                            var publicRequestEntityMetricDataValueMetricData = publicRequestEntityMetricDataValue.MetricData;
                            if (publicRequestEntityMetricDataValue.IsSetMetricData()) 
                            {
                                xmlWriter.WriteStartElement("MetricData");
                                foreach (var publicRequestEntityMetricDataValueMetricDataValue in publicRequestEntityMetricDataValueMetricData) 
                                {
                                    if (publicRequestEntityMetricDataValueMetricDataValue != null)
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        var publicRequestEntityMetricDataValueMetricDataValueCounts = publicRequestEntityMetricDataValueMetricDataValue.Counts;
                                        if (publicRequestEntityMetricDataValueMetricDataValue.IsSetCounts()) 
                                        {
                                            xmlWriter.WriteStartElement("Counts");
                                            foreach (var publicRequestEntityMetricDataValueMetricDataValueCountsValue in publicRequestEntityMetricDataValueMetricDataValueCounts) 
                                            {
                                                xmlWriter.WriteStartElement("member");
                                                xmlWriter.WriteValue(publicRequestEntityMetricDataValueMetricDataValueCountsValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        var publicRequestEntityMetricDataValueMetricDataValueDimensions = publicRequestEntityMetricDataValueMetricDataValue.Dimensions;
                                        if (publicRequestEntityMetricDataValueMetricDataValue.IsSetDimensions()) 
                                        {
                                            xmlWriter.WriteStartElement("Dimensions");
                                            foreach (var publicRequestEntityMetricDataValueMetricDataValueDimensionsValue in publicRequestEntityMetricDataValueMetricDataValueDimensions) 
                                            {
                                                if (publicRequestEntityMetricDataValueMetricDataValueDimensionsValue != null)
                                                {
                                                    xmlWriter.WriteStartElement("member");
                                                    if(publicRequestEntityMetricDataValueMetricDataValueDimensionsValue.IsSetName())
                                                        xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestEntityMetricDataValueMetricDataValueDimensionsValue.Name));
                                                    if(publicRequestEntityMetricDataValueMetricDataValueDimensionsValue.IsSetValue())
                                                        xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestEntityMetricDataValueMetricDataValueDimensionsValue.Value));
                                                    xmlWriter.WriteEndElement();
                                                }
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        if(publicRequestEntityMetricDataValueMetricDataValue.IsSetMetricName())
                                            xmlWriter.WriteElementString("MetricName", StringUtils.FromString(publicRequestEntityMetricDataValueMetricDataValue.MetricName));
                                        if (publicRequestEntityMetricDataValueMetricDataValue.IsSetStatisticValues())
                                        {
                                            xmlWriter.WriteStartElement("StatisticValues");
                                            if(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.IsSetMaximum())
                                                xmlWriter.WriteElementString("Maximum", StringUtils.FromDouble(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.Maximum.Value));
                                            if(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.IsSetMinimum())
                                                xmlWriter.WriteElementString("Minimum", StringUtils.FromDouble(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.Minimum.Value));
                                            if(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.IsSetSampleCount())
                                                xmlWriter.WriteElementString("SampleCount", StringUtils.FromDouble(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.SampleCount.Value));
                                            if(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.IsSetSum())
                                                xmlWriter.WriteElementString("Sum", StringUtils.FromDouble(publicRequestEntityMetricDataValueMetricDataValue.StatisticValues.Sum.Value));
                                            xmlWriter.WriteEndElement();
                                        }
                                        if(publicRequestEntityMetricDataValueMetricDataValue.IsSetStorageResolution())
                                            xmlWriter.WriteElementString("StorageResolution", StringUtils.FromInt(publicRequestEntityMetricDataValueMetricDataValue.StorageResolution.Value));
                                        if(publicRequestEntityMetricDataValueMetricDataValue.IsSetTimestamp())
                                            xmlWriter.WriteElementString("Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestEntityMetricDataValueMetricDataValue.Timestamp.Value));
                                        if(publicRequestEntityMetricDataValueMetricDataValue.IsSetUnit())
                                            xmlWriter.WriteElementString("Unit", StringUtils.FromString(publicRequestEntityMetricDataValueMetricDataValue.Unit));
                                        if(publicRequestEntityMetricDataValueMetricDataValue.IsSetValue())
                                            xmlWriter.WriteElementString("Value", StringUtils.FromDouble(publicRequestEntityMetricDataValueMetricDataValue.Value.Value));
                                        var publicRequestEntityMetricDataValueMetricDataValueValues = publicRequestEntityMetricDataValueMetricDataValue.Values;
                                        if (publicRequestEntityMetricDataValueMetricDataValue.IsSetValues()) 
                                        {
                                            xmlWriter.WriteStartElement("Values");
                                            foreach (var publicRequestEntityMetricDataValueMetricDataValueValuesValue in publicRequestEntityMetricDataValueMetricDataValueValues) 
                                            {
                                                xmlWriter.WriteStartElement("member");
                                                xmlWriter.WriteValue(publicRequestEntityMetricDataValueMetricDataValueValuesValue);
                                                xmlWriter.WriteEndElement();
                                            }            
                                            xmlWriter.WriteEndElement();            
                                        }
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                var publicRequestMetricData = publicRequest.MetricData;
                if (publicRequest.IsSetMetricData()) 
                {
                    xmlWriter.WriteStartElement("MetricData");
                    foreach (var publicRequestMetricDataValue in publicRequestMetricData) 
                    {
                        if (publicRequestMetricDataValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            var publicRequestMetricDataValueCounts = publicRequestMetricDataValue.Counts;
                            if (publicRequestMetricDataValue.IsSetCounts()) 
                            {
                                xmlWriter.WriteStartElement("Counts");
                                foreach (var publicRequestMetricDataValueCountsValue in publicRequestMetricDataValueCounts) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestMetricDataValueCountsValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            var publicRequestMetricDataValueDimensions = publicRequestMetricDataValue.Dimensions;
                            if (publicRequestMetricDataValue.IsSetDimensions()) 
                            {
                                xmlWriter.WriteStartElement("Dimensions");
                                foreach (var publicRequestMetricDataValueDimensionsValue in publicRequestMetricDataValueDimensions) 
                                {
                                    if (publicRequestMetricDataValueDimensionsValue != null)
                                    {
                                        xmlWriter.WriteStartElement("member");
                                        if(publicRequestMetricDataValueDimensionsValue.IsSetName())
                                            xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestMetricDataValueDimensionsValue.Name));
                                        if(publicRequestMetricDataValueDimensionsValue.IsSetValue())
                                            xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestMetricDataValueDimensionsValue.Value));
                                        xmlWriter.WriteEndElement();
                                    }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequestMetricDataValue.IsSetMetricName())
                                xmlWriter.WriteElementString("MetricName", StringUtils.FromString(publicRequestMetricDataValue.MetricName));
                            if (publicRequestMetricDataValue.IsSetStatisticValues())
                            {
                                xmlWriter.WriteStartElement("StatisticValues");
                                if(publicRequestMetricDataValue.StatisticValues.IsSetMaximum())
                                    xmlWriter.WriteElementString("Maximum", StringUtils.FromDouble(publicRequestMetricDataValue.StatisticValues.Maximum.Value));
                                if(publicRequestMetricDataValue.StatisticValues.IsSetMinimum())
                                    xmlWriter.WriteElementString("Minimum", StringUtils.FromDouble(publicRequestMetricDataValue.StatisticValues.Minimum.Value));
                                if(publicRequestMetricDataValue.StatisticValues.IsSetSampleCount())
                                    xmlWriter.WriteElementString("SampleCount", StringUtils.FromDouble(publicRequestMetricDataValue.StatisticValues.SampleCount.Value));
                                if(publicRequestMetricDataValue.StatisticValues.IsSetSum())
                                    xmlWriter.WriteElementString("Sum", StringUtils.FromDouble(publicRequestMetricDataValue.StatisticValues.Sum.Value));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestMetricDataValue.IsSetStorageResolution())
                                xmlWriter.WriteElementString("StorageResolution", StringUtils.FromInt(publicRequestMetricDataValue.StorageResolution.Value));
                            if(publicRequestMetricDataValue.IsSetTimestamp())
                                xmlWriter.WriteElementString("Timestamp", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestMetricDataValue.Timestamp.Value));
                            if(publicRequestMetricDataValue.IsSetUnit())
                                xmlWriter.WriteElementString("Unit", StringUtils.FromString(publicRequestMetricDataValue.Unit));
                            if(publicRequestMetricDataValue.IsSetValue())
                                xmlWriter.WriteElementString("Value", StringUtils.FromDouble(publicRequestMetricDataValue.Value.Value));
                            var publicRequestMetricDataValueValues = publicRequestMetricDataValue.Values;
                            if (publicRequestMetricDataValue.IsSetValues()) 
                            {
                                xmlWriter.WriteStartElement("Values");
                                foreach (var publicRequestMetricDataValueValuesValue in publicRequestMetricDataValueValues) 
                                {
                                    xmlWriter.WriteStartElement("member");
                                    xmlWriter.WriteValue(publicRequestMetricDataValueValuesValue);
                                    xmlWriter.WriteEndElement();
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetNamespace())
                    xmlWriter.WriteElementString("Namespace", StringUtils.FromString(publicRequest.Namespace));

                if(publicRequest.IsSetStrictEntityValidation())
                    xmlWriter.WriteElementString("StrictEntityValidation", StringUtils.FromBool(publicRequest.StrictEntityValidation.Value));


                xmlWriter.WriteEndElement();
            }
            PostMarshallCustomization(request, publicRequest);
            try 
            {
#if NETFRAMEWORK // For non .NET Framework targets the request payload is stored in the ContentStream via the PooledContentStream.
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
#endif
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "1999-12-31";
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }
            return request;
        }
        private static PutMetricDataRequestMarshaller _instance = new PutMetricDataRequestMarshaller();        

        internal static PutMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutMetricDataRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, PutMetricDataRequest publicRequest);
    }    
}