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
 * Do not modify this file. This file is generated from the voice-id-2021-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VoiceID.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VoiceID.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSpeakerEnrollmentJob Request Marshaller
    /// </summary>       
    public class StartSpeakerEnrollmentJobRequestMarshaller : IMarshaller<IRequest, StartSpeakerEnrollmentJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSpeakerEnrollmentJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSpeakerEnrollmentJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VoiceID");
            string target = "VoiceID.StartSpeakerEnrollmentJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-09-27";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("ClientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDataAccessRoleArn())
                {
                    context.Writer.WritePropertyName("DataAccessRoleArn");
                    context.Writer.Write(publicRequest.DataAccessRoleArn);
                }

                if(publicRequest.IsSetDomainId())
                {
                    context.Writer.WritePropertyName("DomainId");
                    context.Writer.Write(publicRequest.DomainId);
                }

                if(publicRequest.IsSetEnrollmentConfig())
                {
                    context.Writer.WritePropertyName("EnrollmentConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = EnrollmentConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EnrollmentConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputDataConfig())
                {
                    context.Writer.WritePropertyName("InputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("JobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetOutputDataConfig())
                {
                    context.Writer.WritePropertyName("OutputDataConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputDataConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OutputDataConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartSpeakerEnrollmentJobRequestMarshaller _instance = new StartSpeakerEnrollmentJobRequestMarshaller();        

        internal static StartSpeakerEnrollmentJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSpeakerEnrollmentJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}