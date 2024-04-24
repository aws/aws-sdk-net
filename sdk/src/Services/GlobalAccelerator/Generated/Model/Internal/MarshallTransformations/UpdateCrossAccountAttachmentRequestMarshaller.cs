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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlobalAccelerator.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GlobalAccelerator.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCrossAccountAttachment Request Marshaller
    /// </summary>       
    public class UpdateCrossAccountAttachmentRequestMarshaller : IMarshaller<IRequest, UpdateCrossAccountAttachmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCrossAccountAttachmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateCrossAccountAttachmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlobalAccelerator");
            string target = "GlobalAccelerator_V20180706.UpdateCrossAccountAttachment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAddPrincipals())
                {
                    context.Writer.WritePropertyName("AddPrincipals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddPrincipalsListValue in publicRequest.AddPrincipals)
                    {
                            context.Writer.Write(publicRequestAddPrincipalsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAddResources())
                {
                    context.Writer.WritePropertyName("AddResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAddResourcesListValue in publicRequest.AddResources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestAddResourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAttachmentArn())
                {
                    context.Writer.WritePropertyName("AttachmentArn");
                    context.Writer.Write(publicRequest.AttachmentArn);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRemovePrincipals())
                {
                    context.Writer.WritePropertyName("RemovePrincipals");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemovePrincipalsListValue in publicRequest.RemovePrincipals)
                    {
                            context.Writer.Write(publicRequestRemovePrincipalsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRemoveResources())
                {
                    context.Writer.WritePropertyName("RemoveResources");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestRemoveResourcesListValue in publicRequest.RemoveResources)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ResourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestRemoveResourcesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateCrossAccountAttachmentRequestMarshaller _instance = new UpdateCrossAccountAttachmentRequestMarshaller();        

        internal static UpdateCrossAccountAttachmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateCrossAccountAttachmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}