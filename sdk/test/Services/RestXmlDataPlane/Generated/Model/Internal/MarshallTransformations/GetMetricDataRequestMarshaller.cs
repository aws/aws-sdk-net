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
    /// GetMetricData Request Marshaller
    /// </summary>       
    public partial class GetMetricDataRequestMarshaller : IMarshaller<IRequest, GetMetricDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetMetricDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetMetricDataRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.RestXmlDataPlane");
            PreMarshallCustomization(request, publicRequest);
            request.HttpMethod = "POST";
            request.ResourcePath = "/GetMetricData";

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
                xmlWriter.WriteStartElement("GetMetricDataInput", "https://awsrestxmldataplane.amazonaws.com");
                if(publicRequest.IsSetEndTime())
                    xmlWriter.WriteElementString("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime.Value));

                if (publicRequest.IsSetLabelOptions())
                {
                    xmlWriter.WriteStartElement("LabelOptions");
                    if(publicRequest.LabelOptions.IsSetTimezone())
                        xmlWriter.WriteElementString("Timezone", StringUtils.FromString(publicRequest.LabelOptions.Timezone));
                    xmlWriter.WriteEndElement();
                }
                if(publicRequest.IsSetMaxDatapoints())
                    xmlWriter.WriteElementString("MaxDatapoints", StringUtils.FromInt(publicRequest.MaxDatapoints.Value));

                var publicRequestMetricDataQueries = publicRequest.MetricDataQueries;
                if (publicRequest.IsSetMetricDataQueries()) 
                {
                    xmlWriter.WriteStartElement("MetricDataQueries");
                    foreach (var publicRequestMetricDataQueriesValue in publicRequestMetricDataQueries) 
                    {
                        if (publicRequestMetricDataQueriesValue != null)
                        {
                            xmlWriter.WriteStartElement("member");
                            if(publicRequestMetricDataQueriesValue.IsSetAccountId())
                                xmlWriter.WriteElementString("AccountId", StringUtils.FromString(publicRequestMetricDataQueriesValue.AccountId));
                            if(publicRequestMetricDataQueriesValue.IsSetExpression())
                                xmlWriter.WriteElementString("Expression", StringUtils.FromString(publicRequestMetricDataQueriesValue.Expression));
                            if(publicRequestMetricDataQueriesValue.IsSetId())
                                xmlWriter.WriteElementString("Id", StringUtils.FromString(publicRequestMetricDataQueriesValue.Id));
                            if(publicRequestMetricDataQueriesValue.IsSetLabel())
                                xmlWriter.WriteElementString("Label", StringUtils.FromString(publicRequestMetricDataQueriesValue.Label));
                            if (publicRequestMetricDataQueriesValue.IsSetMetricStat())
                            {
                                xmlWriter.WriteStartElement("MetricStat");
                                if (publicRequestMetricDataQueriesValue.MetricStat.IsSetMetric())
                                {
                                    xmlWriter.WriteStartElement("Metric");
                                    var publicRequestMetricDataQueriesValueMetricStatMetricDimensions = publicRequestMetricDataQueriesValue.MetricStat.Metric.Dimensions;
                                    if (publicRequestMetricDataQueriesValue.MetricStat.Metric.IsSetDimensions()) 
                                    {
                                        xmlWriter.WriteStartElement("Dimensions");
                                        foreach (var publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue in publicRequestMetricDataQueriesValueMetricStatMetricDimensions) 
                                        {
                                            if (publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue != null)
                                            {
                                                xmlWriter.WriteStartElement("member");
                                                if(publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue.IsSetName())
                                                    xmlWriter.WriteElementString("Name", StringUtils.FromString(publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue.Name));
                                                if(publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue.IsSetValue())
                                                    xmlWriter.WriteElementString("Value", StringUtils.FromString(publicRequestMetricDataQueriesValueMetricStatMetricDimensionsValue.Value));
                                                xmlWriter.WriteEndElement();
                                            }
                                        }            
                                        xmlWriter.WriteEndElement();            
                                    }
                                    if(publicRequestMetricDataQueriesValue.MetricStat.Metric.IsSetMetricName())
                                        xmlWriter.WriteElementString("MetricName", StringUtils.FromString(publicRequestMetricDataQueriesValue.MetricStat.Metric.MetricName));
                                    if(publicRequestMetricDataQueriesValue.MetricStat.Metric.IsSetNamespace())
                                        xmlWriter.WriteElementString("Namespace", StringUtils.FromString(publicRequestMetricDataQueriesValue.MetricStat.Metric.Namespace));
                                    xmlWriter.WriteEndElement();
                                }
                                if(publicRequestMetricDataQueriesValue.MetricStat.IsSetPeriod())
                                    xmlWriter.WriteElementString("Period", StringUtils.FromInt(publicRequestMetricDataQueriesValue.MetricStat.Period.Value));
                                if(publicRequestMetricDataQueriesValue.MetricStat.IsSetStat())
                                    xmlWriter.WriteElementString("Stat", StringUtils.FromString(publicRequestMetricDataQueriesValue.MetricStat.Stat));
                                if(publicRequestMetricDataQueriesValue.MetricStat.IsSetUnit())
                                    xmlWriter.WriteElementString("Unit", StringUtils.FromString(publicRequestMetricDataQueriesValue.MetricStat.Unit));
                                xmlWriter.WriteEndElement();
                            }
                            if(publicRequestMetricDataQueriesValue.IsSetPeriod())
                                xmlWriter.WriteElementString("Period", StringUtils.FromInt(publicRequestMetricDataQueriesValue.Period.Value));
                            if(publicRequestMetricDataQueriesValue.IsSetReturnData())
                                xmlWriter.WriteElementString("ReturnData", StringUtils.FromBool(publicRequestMetricDataQueriesValue.ReturnData.Value));
                            xmlWriter.WriteEndElement();
                        }
                    }            
                    xmlWriter.WriteEndElement();            
                }
                if(publicRequest.IsSetNextToken())
                    xmlWriter.WriteElementString("NextToken", StringUtils.FromString(publicRequest.NextToken));

                if(publicRequest.IsSetScanBy())
                    xmlWriter.WriteElementString("ScanBy", StringUtils.FromString(publicRequest.ScanBy));

                if(publicRequest.IsSetStartTime())
                    xmlWriter.WriteElementString("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime.Value));


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
        private static GetMetricDataRequestMarshaller _instance = new GetMetricDataRequestMarshaller();        

        internal static GetMetricDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetMetricDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetMetricDataRequest publicRequest);
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, GetMetricDataRequest publicRequest);
    }    
}