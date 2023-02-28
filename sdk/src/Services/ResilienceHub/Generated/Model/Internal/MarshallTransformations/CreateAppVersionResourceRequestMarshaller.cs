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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAppVersionResource Request Marshaller
    /// </summary>       
    public class CreateAppVersionResourceRequestMarshaller : IMarshaller<IRequest, CreateAppVersionResourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppVersionResourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAppVersionResourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-app-version-resource";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalInfo())
                {
                    context.Writer.WritePropertyName("additionalInfo");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAdditionalInfoKvp in publicRequest.AdditionalInfo)
                    {
                        context.Writer.WritePropertyName(publicRequestAdditionalInfoKvp.Key);
                        var publicRequestAdditionalInfoValue = publicRequestAdditionalInfoKvp.Value;

                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestAdditionalInfoValueListValue in publicRequestAdditionalInfoValue)
                        {
                                context.Writer.Write(publicRequestAdditionalInfoValueListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAppArn())
                {
                    context.Writer.WritePropertyName("appArn");
                    context.Writer.Write(publicRequest.AppArn);
                }

                if(publicRequest.IsSetAppComponents())
                {
                    context.Writer.WritePropertyName("appComponents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAppComponentsListValue in publicRequest.AppComponents)
                    {
                            context.Writer.Write(publicRequestAppComponentsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAwsAccountId())
                {
                    context.Writer.WritePropertyName("awsAccountId");
                    context.Writer.Write(publicRequest.AwsAccountId);
                }

                if(publicRequest.IsSetAwsRegion())
                {
                    context.Writer.WritePropertyName("awsRegion");
                    context.Writer.Write(publicRequest.AwsRegion);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetLogicalResourceId())
                {
                    context.Writer.WritePropertyName("logicalResourceId");
                    context.Writer.WriteObjectStart();

                    var marshaller = LogicalResourceIdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogicalResourceId, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPhysicalResourceId())
                {
                    context.Writer.WritePropertyName("physicalResourceId");
                    context.Writer.Write(publicRequest.PhysicalResourceId);
                }

                if(publicRequest.IsSetResourceName())
                {
                    context.Writer.WritePropertyName("resourceName");
                    context.Writer.Write(publicRequest.ResourceName);
                }

                if(publicRequest.IsSetResourceType())
                {
                    context.Writer.WritePropertyName("resourceType");
                    context.Writer.Write(publicRequest.ResourceType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAppVersionResourceRequestMarshaller _instance = new CreateAppVersionResourceRequestMarshaller();        

        internal static CreateAppVersionResourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAppVersionResourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}