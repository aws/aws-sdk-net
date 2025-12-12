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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeAlarmHistory Request Marshaller
    /// </summary>       
    public class DescribeAlarmHistoryRequestMarshaller : IMarshaller<IRequest, DescribeAlarmHistoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeAlarmHistoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeAlarmHistoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/DescribeAlarmHistory";
            request.Headers[Amazon.Util.HeaderKeys.XAmzQueryMode] = "true";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2010-08-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAlarmContributorId())
                {
                    context.Writer.WriteTextString("AlarmContributorId");
                    context.Writer.WriteTextString(publicRequest.AlarmContributorId);
                }
                if (publicRequest.IsSetAlarmName())
                {
                    context.Writer.WriteTextString("AlarmName");
                    context.Writer.WriteTextString(publicRequest.AlarmName);
                }
                if (publicRequest.IsSetAlarmTypes())
                {
                    context.Writer.WriteTextString("AlarmTypes");
                    context.Writer.WriteStartArray(publicRequest.AlarmTypes.Count);
                    foreach(var publicRequestAlarmTypesListValue in publicRequest.AlarmTypes)
                    {
                            context.Writer.WriteTextString(publicRequestAlarmTypesListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetEndDate())
                {
                    context.Writer.WriteTextString("EndDate");
                    context.Writer.WriteDateTime(publicRequest.EndDate.Value);
                }
                if (publicRequest.IsSetHistoryItemType())
                {
                    context.Writer.WriteTextString("HistoryItemType");
                    context.Writer.WriteTextString(publicRequest.HistoryItemType);
                }
                if (publicRequest.IsSetMaxRecords())
                {
                    context.Writer.WriteTextString("MaxRecords");
                    context.Writer.WriteInt32(publicRequest.MaxRecords.Value);
                }
                if (publicRequest.IsSetNextToken())
                {
                    context.Writer.WriteTextString("NextToken");
                    context.Writer.WriteTextString(publicRequest.NextToken);
                }
                if (publicRequest.IsSetScanBy())
                {
                    context.Writer.WriteTextString("ScanBy");
                    context.Writer.WriteTextString(publicRequest.ScanBy);
                }
                if (publicRequest.IsSetStartDate())
                {
                    context.Writer.WriteTextString("StartDate");
                    context.Writer.WriteDateTime(publicRequest.StartDate.Value);
                }
                writer.WriteEndMap();
                request.Content = writer.Encode();
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static DescribeAlarmHistoryRequestMarshaller _instance = new DescribeAlarmHistoryRequestMarshaller();        

        internal static DescribeAlarmHistoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAlarmHistoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}