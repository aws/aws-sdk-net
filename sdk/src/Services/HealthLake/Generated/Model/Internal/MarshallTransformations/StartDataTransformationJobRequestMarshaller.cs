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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.HealthLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartDataTransformationJob Request Marshaller
    /// </summary>       
    public class StartDataTransformationJobRequestMarshaller : IMarshaller<IRequest, StartDataTransformationJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartDataTransformationJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartDataTransformationJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.HealthLake");
            string target = "HealthLake.StartDataTransformationJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetDataAccessRoleArn())
            {
                context.Writer.WritePropertyName("DataAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.DataAccessRoleArn);
            }

            if(publicRequest.IsSetDriftDetectionEnabled())
            {
                context.Writer.WritePropertyName("DriftDetectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DriftDetectionEnabled.Value);
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = TransformationInputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = TransformationOutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetProfileId())
            {
                context.Writer.WritePropertyName("ProfileId");
                context.Writer.WriteStringValue(publicRequest.ProfileId);
            }

            if(publicRequest.IsSetProvenanceEnabled())
            {
                context.Writer.WritePropertyName("ProvenanceEnabled");
                context.Writer.WriteBooleanValue(publicRequest.ProvenanceEnabled.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"datatransformation.";

            return request;
        }
        private static StartDataTransformationJobRequestMarshaller _instance = new StartDataTransformationJobRequestMarshaller();        

        internal static StartDataTransformationJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartDataTransformationJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}