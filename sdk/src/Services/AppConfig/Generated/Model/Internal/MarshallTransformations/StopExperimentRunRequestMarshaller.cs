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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
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
namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StopExperimentRun Request Marshaller
    /// </summary>       
    public class StopExperimentRunRequestMarshaller : IMarshaller<IRequest, StopExperimentRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StopExperimentRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StopExperimentRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetApplicationIdentifier())
                throw new AmazonAppConfigException("Request object does not have required field ApplicationIdentifier set");
            request.AddPathResource("{ApplicationIdentifier}", StringUtils.FromString(publicRequest.ApplicationIdentifier));
            if (!publicRequest.IsSetExperimentDefinitionIdentifier())
                throw new AmazonAppConfigException("Request object does not have required field ExperimentDefinitionIdentifier set");
            request.AddPathResource("{ExperimentDefinitionIdentifier}", StringUtils.FromString(publicRequest.ExperimentDefinitionIdentifier));
            if (!publicRequest.IsSetRun())
                throw new AmazonAppConfigException("Request object does not have required field Run set");
            request.AddPathResource("{Run}", StringUtils.FromInt(publicRequest.Run));
            request.ResourcePath = "/applications/{ApplicationIdentifier}/experimentdefinitions/{ExperimentDefinitionIdentifier}/experimentruns/{Run}/stop";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeploymentParameters())
            {
                context.Writer.WritePropertyName("DeploymentParameters");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentParametersMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentParameters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResult())
            {
                context.Writer.WritePropertyName("Result");
                context.Writer.WriteStartObject();

                var marshaller = ExperimentRunResultMarshaller.Instance;
                marshaller.Marshall(publicRequest.Result, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static StopExperimentRunRequestMarshaller _instance = new StopExperimentRunRequestMarshaller();        

        internal static StopExperimentRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StopExperimentRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}