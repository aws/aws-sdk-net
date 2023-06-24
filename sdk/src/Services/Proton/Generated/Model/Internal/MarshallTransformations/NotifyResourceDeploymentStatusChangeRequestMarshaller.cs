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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NotifyResourceDeploymentStatusChange Request Marshaller
    /// </summary>       
    public class NotifyResourceDeploymentStatusChangeRequestMarshaller : IMarshaller<IRequest, NotifyResourceDeploymentStatusChangeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((NotifyResourceDeploymentStatusChangeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(NotifyResourceDeploymentStatusChangeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Proton");
            string target = "AwsProton20200720.NotifyResourceDeploymentStatusChange";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDeploymentId())
                {
                    context.Writer.WritePropertyName("deploymentId");
                    context.Writer.Write(publicRequest.DeploymentId);
                }

                if(publicRequest.IsSetOutputs())
                {
                    context.Writer.WritePropertyName("outputs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OutputMarshaller.Instance;
                        marshaller.Marshall(publicRequestOutputsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("resourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                if(publicRequest.IsSetStatusMessage())
                {
                    context.Writer.WritePropertyName("statusMessage");
                    context.Writer.Write(publicRequest.StatusMessage);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static NotifyResourceDeploymentStatusChangeRequestMarshaller _instance = new NotifyResourceDeploymentStatusChangeRequestMarshaller();        

        internal static NotifyResourceDeploymentStatusChangeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NotifyResourceDeploymentStatusChangeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}