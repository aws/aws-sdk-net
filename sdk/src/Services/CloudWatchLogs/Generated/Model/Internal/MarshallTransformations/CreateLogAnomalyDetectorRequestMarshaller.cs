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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLogAnomalyDetector Request Marshaller
    /// </summary>       
    public class CreateLogAnomalyDetectorRequestMarshaller : IMarshaller<IRequest, CreateLogAnomalyDetectorRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLogAnomalyDetectorRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLogAnomalyDetectorRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/Logs_20140328/operation/CreateLogAnomalyDetector";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetAnomalyVisibilityTime())
                {
                    context.Writer.WriteTextString("anomalyVisibilityTime");
                    context.Writer.WriteInt64(publicRequest.AnomalyVisibilityTime.Value);
                }
                if (publicRequest.IsSetDetectorName())
                {
                    context.Writer.WriteTextString("detectorName");
                    context.Writer.WriteTextString(publicRequest.DetectorName);
                }
                if (publicRequest.IsSetEvaluationFrequency())
                {
                    context.Writer.WriteTextString("evaluationFrequency");
                    context.Writer.WriteTextString(publicRequest.EvaluationFrequency);
                }
                if (publicRequest.IsSetFilterPattern())
                {
                    context.Writer.WriteTextString("filterPattern");
                    context.Writer.WriteTextString(publicRequest.FilterPattern);
                }
                if (publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WriteTextString("kmsKeyId");
                    context.Writer.WriteTextString(publicRequest.KmsKeyId);
                }
                if (publicRequest.IsSetLogGroupArnList())
                {
                    context.Writer.WriteTextString("logGroupArnList");
                    context.Writer.WriteStartArray(publicRequest.LogGroupArnList.Count);
                    foreach(var publicRequestLogGroupArnListListValue in publicRequest.LogGroupArnList)
                    {
                            context.Writer.WriteTextString(publicRequestLogGroupArnListListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                if (publicRequest.IsSetTags())
                {
                    context.Writer.WriteTextString("tags");
                    context.Writer.WriteStartMap(null);
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WriteTextString(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.WriteTextString(publicRequestTagsValue);
                    }
                    context.Writer.WriteEndMap();
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
        private static CreateLogAnomalyDetectorRequestMarshaller _instance = new CreateLogAnomalyDetectorRequestMarshaller();        

        internal static CreateLogAnomalyDetectorRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLogAnomalyDetectorRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}