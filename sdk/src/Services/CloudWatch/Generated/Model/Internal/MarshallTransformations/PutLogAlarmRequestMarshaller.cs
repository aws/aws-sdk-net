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
    /// PutLogAlarm Request Marshaller
    /// </summary>       
    public class PutLogAlarmRequestMarshaller : IMarshaller<IRequest, PutLogAlarmRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutLogAlarmRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutLogAlarmRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatch");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/GraniteServiceVersion20100801/operation/PutLogAlarm";
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
                if (publicRequest.IsSetActionLogLineCount())
                {
                    context.Writer.WriteTextString("ActionLogLineCount");
                    context.Writer.WriteInt32(publicRequest.ActionLogLineCount.Value);
                }
                if (publicRequest.IsSetActionLogLineRoleArn())
                {
                    context.Writer.WriteTextString("ActionLogLineRoleArn");
                    context.Writer.WriteTextString(publicRequest.ActionLogLineRoleArn);
                }
                if (publicRequest.IsSetActionsEnabled())
                {
                    context.Writer.WriteTextString("ActionsEnabled");
                    context.Writer.WriteBoolean(publicRequest.ActionsEnabled.Value);
                }
                if (publicRequest.IsSetAlarmActions())
                {
                    context.Writer.WriteTextString("AlarmActions");
                    context.Writer.WriteStartArray(publicRequest.AlarmActions.Count);
                    foreach(var publicRequestAlarmActionsListValue in publicRequest.AlarmActions)
                    {
                            context.Writer.WriteTextString(publicRequestAlarmActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetAlarmDescription())
                {
                    context.Writer.WriteTextString("AlarmDescription");
                    context.Writer.WriteTextString(publicRequest.AlarmDescription);
                }
                if (publicRequest.IsSetAlarmName())
                {
                    context.Writer.WriteTextString("AlarmName");
                    context.Writer.WriteTextString(publicRequest.AlarmName);
                }
                if (publicRequest.IsSetComparisonOperator())
                {
                    context.Writer.WriteTextString("ComparisonOperator");
                    context.Writer.WriteTextString(publicRequest.ComparisonOperator);
                }
                if (publicRequest.IsSetInsufficientDataActions())
                {
                    context.Writer.WriteTextString("InsufficientDataActions");
                    context.Writer.WriteStartArray(publicRequest.InsufficientDataActions.Count);
                    foreach(var publicRequestInsufficientDataActionsListValue in publicRequest.InsufficientDataActions)
                    {
                            context.Writer.WriteTextString(publicRequestInsufficientDataActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetOKActions())
                {
                    context.Writer.WriteTextString("OKActions");
                    context.Writer.WriteStartArray(publicRequest.OKActions.Count);
                    foreach(var publicRequestOKActionsListValue in publicRequest.OKActions)
                    {
                            context.Writer.WriteTextString(publicRequestOKActionsListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetQueryResultsToAlarm())
                {
                    context.Writer.WriteTextString("QueryResultsToAlarm");
                    context.Writer.WriteInt32(publicRequest.QueryResultsToAlarm.Value);
                }
                if (publicRequest.IsSetQueryResultsToEvaluate())
                {
                    context.Writer.WriteTextString("QueryResultsToEvaluate");
                    context.Writer.WriteInt32(publicRequest.QueryResultsToEvaluate.Value);
                }
                if (publicRequest.IsSetScheduledQueryConfiguration())
                {
                    context.Writer.WriteTextString("ScheduledQueryConfiguration");
                    context.Writer.WriteStartMap(null);

                    var marshaller = ScheduledQueryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ScheduledQueryConfiguration, context);

                    context.Writer.WriteEndMap();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("Tags");
                    context.Writer.WriteStartArray(publicRequest.Tags.Count);
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteStartMap(null);

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteEndMap();
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetThreshold())
                {
                    context.Writer.WriteTextString("Threshold");
                    context.Writer.WriteOptimizedNumber(publicRequest.Threshold.Value);
                }
                if (publicRequest.IsSetTreatMissingData())
                {
                    context.Writer.WriteTextString("TreatMissingData");
                    context.Writer.WriteTextString(publicRequest.TreatMissingData);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static PutLogAlarmRequestMarshaller _instance = new PutLogAlarmRequestMarshaller();        

        internal static PutLogAlarmRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutLogAlarmRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}