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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAnomaly Request Marshaller
    /// </summary>       
    public class UpdateAnomalyRequestMarshaller : IMarshaller<IRequest, UpdateAnomalyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAnomalyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAnomalyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.UpdateAnomaly";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAnomalyDetectorArn())
                {
                    context.Writer.WritePropertyName("anomalyDetectorArn");
                    context.Writer.Write(publicRequest.AnomalyDetectorArn);
                }

                if(publicRequest.IsSetAnomalyId())
                {
                    context.Writer.WritePropertyName("anomalyId");
                    context.Writer.Write(publicRequest.AnomalyId);
                }

                if(publicRequest.IsSetBaseline())
                {
                    context.Writer.WritePropertyName("baseline");
                    context.Writer.Write(publicRequest.Baseline);
                }

                if(publicRequest.IsSetPatternId())
                {
                    context.Writer.WritePropertyName("patternId");
                    context.Writer.Write(publicRequest.PatternId);
                }

                if(publicRequest.IsSetSuppressionPeriod())
                {
                    context.Writer.WritePropertyName("suppressionPeriod");
                    context.Writer.WriteObjectStart();

                    var marshaller = SuppressionPeriodMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SuppressionPeriod, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSuppressionType())
                {
                    context.Writer.WritePropertyName("suppressionType");
                    context.Writer.Write(publicRequest.SuppressionType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAnomalyRequestMarshaller _instance = new UpdateAnomalyRequestMarshaller();        

        internal static UpdateAnomalyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAnomalyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}