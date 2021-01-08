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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDetectorModel Request Marshaller
    /// </summary>       
    public class UpdateDetectorModelRequestMarshaller : IMarshaller<IRequest, UpdateDetectorModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDetectorModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDetectorModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTEvents");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-07-27";            
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDetectorModelName())
                throw new AmazonIoTEventsException("Request object does not have required field DetectorModelName set");
            request.AddPathResource("{detectorModelName}", StringUtils.FromString(publicRequest.DetectorModelName));
            request.ResourcePath = "/detector-models/{detectorModelName}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDetectorModelDefinition())
                {
                    context.Writer.WritePropertyName("detectorModelDefinition");
                    context.Writer.WriteObjectStart();

                    var marshaller = DetectorModelDefinitionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DetectorModelDefinition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDetectorModelDescription())
                {
                    context.Writer.WritePropertyName("detectorModelDescription");
                    context.Writer.Write(publicRequest.DetectorModelDescription);
                }

                if(publicRequest.IsSetEvaluationMethod())
                {
                    context.Writer.WritePropertyName("evaluationMethod");
                    context.Writer.Write(publicRequest.EvaluationMethod);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDetectorModelRequestMarshaller _instance = new UpdateDetectorModelRequestMarshaller();        

        internal static UpdateDetectorModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDetectorModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}