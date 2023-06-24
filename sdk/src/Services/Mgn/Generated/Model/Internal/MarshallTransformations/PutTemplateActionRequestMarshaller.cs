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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutTemplateAction Request Marshaller
    /// </summary>       
    public class PutTemplateActionRequestMarshaller : IMarshaller<IRequest, PutTemplateActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutTemplateActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutTemplateActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mgn");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/PutTemplateAction";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActionID())
                {
                    context.Writer.WritePropertyName("actionID");
                    context.Writer.Write(publicRequest.ActionID);
                }

                if(publicRequest.IsSetActionName())
                {
                    context.Writer.WritePropertyName("actionName");
                    context.Writer.Write(publicRequest.ActionName);
                }

                if(publicRequest.IsSetActive())
                {
                    context.Writer.WritePropertyName("active");
                    context.Writer.Write(publicRequest.Active);
                }

                if(publicRequest.IsSetCategory())
                {
                    context.Writer.WritePropertyName("category");
                    context.Writer.Write(publicRequest.Category);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDocumentIdentifier())
                {
                    context.Writer.WritePropertyName("documentIdentifier");
                    context.Writer.Write(publicRequest.DocumentIdentifier);
                }

                if(publicRequest.IsSetDocumentVersion())
                {
                    context.Writer.WritePropertyName("documentVersion");
                    context.Writer.Write(publicRequest.DocumentVersion);
                }

                if(publicRequest.IsSetExternalParameters())
                {
                    context.Writer.WritePropertyName("externalParameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestExternalParametersKvp in publicRequest.ExternalParameters)
                    {
                        context.Writer.WritePropertyName(publicRequestExternalParametersKvp.Key);
                        var publicRequestExternalParametersValue = publicRequestExternalParametersKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = SsmExternalParameterMarshaller.Instance;
                        marshaller.Marshall(publicRequestExternalParametersValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLaunchConfigurationTemplateID())
                {
                    context.Writer.WritePropertyName("launchConfigurationTemplateID");
                    context.Writer.Write(publicRequest.LaunchConfigurationTemplateID);
                }

                if(publicRequest.IsSetMustSucceedForCutover())
                {
                    context.Writer.WritePropertyName("mustSucceedForCutover");
                    context.Writer.Write(publicRequest.MustSucceedForCutover);
                }

                if(publicRequest.IsSetOperatingSystem())
                {
                    context.Writer.WritePropertyName("operatingSystem");
                    context.Writer.Write(publicRequest.OperatingSystem);
                }

                if(publicRequest.IsSetOrder())
                {
                    context.Writer.WritePropertyName("order");
                    context.Writer.Write(publicRequest.Order);
                }

                if(publicRequest.IsSetParameters())
                {
                    context.Writer.WritePropertyName("parameters");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestParametersKvp in publicRequest.Parameters)
                    {
                        context.Writer.WritePropertyName(publicRequestParametersKvp.Key);
                        var publicRequestParametersValue = publicRequestParametersKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestParametersValueListValue in publicRequestParametersValue)
                        {
                            context.Writer.WriteObjectStart();

                            var marshaller = SsmParameterStoreParameterMarshaller.Instance;
                            marshaller.Marshall(publicRequestParametersValueListValue, context);

                            context.Writer.WriteObjectEnd();
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("timeoutSeconds");
                    context.Writer.Write(publicRequest.TimeoutSeconds);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutTemplateActionRequestMarshaller _instance = new PutTemplateActionRequestMarshaller();        

        internal static PutTemplateActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutTemplateActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}