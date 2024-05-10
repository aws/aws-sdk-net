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

#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAppInputSource Request Marshaller
    /// </summary>       
    public class DeleteAppInputSourceRequestMarshaller : IMarshaller<IRequest, DeleteAppInputSourceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAppInputSourceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAppInputSourceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResilienceHub");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-04-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/delete-app-input-source";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppArn())
                {
                    context.Writer.WritePropertyName("appArn");
                    context.Writer.Write(publicRequest.AppArn);
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
                if(publicRequest.IsSetEksSourceClusterNamespace())
                {
                    context.Writer.WritePropertyName("eksSourceClusterNamespace");
                    context.Writer.WriteObjectStart();

                    var marshaller = EksSourceClusterNamespaceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EksSourceClusterNamespace, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceArn())
                {
                    context.Writer.WritePropertyName("sourceArn");
                    context.Writer.Write(publicRequest.SourceArn);
                }

                if(publicRequest.IsSetTerraformSource())
                {
                    context.Writer.WritePropertyName("terraformSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = TerraformSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TerraformSource, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DeleteAppInputSourceRequestMarshaller _instance = new DeleteAppInputSourceRequestMarshaller();        

        internal static DeleteAppInputSourceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAppInputSourceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}