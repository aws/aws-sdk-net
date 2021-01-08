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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTapes Request Marshaller
    /// </summary>       
    public class CreateTapesRequestMarshaller : IMarshaller<IRequest, CreateTapesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTapesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTapesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.CreateTapes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-06-30";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
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

                if(publicRequest.IsSetGatewayARN())
                {
                    context.Writer.WritePropertyName("GatewayARN");
                    context.Writer.Write(publicRequest.GatewayARN);
                }

                if(publicRequest.IsSetKMSEncrypted())
                {
                    context.Writer.WritePropertyName("KMSEncrypted");
                    context.Writer.Write(publicRequest.KMSEncrypted);
                }

                if(publicRequest.IsSetKMSKey())
                {
                    context.Writer.WritePropertyName("KMSKey");
                    context.Writer.Write(publicRequest.KMSKey);
                }

                if(publicRequest.IsSetNumTapesToCreate())
                {
                    context.Writer.WritePropertyName("NumTapesToCreate");
                    context.Writer.Write(publicRequest.NumTapesToCreate);
                }

                if(publicRequest.IsSetPoolId())
                {
                    context.Writer.WritePropertyName("PoolId");
                    context.Writer.Write(publicRequest.PoolId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTapeBarcodePrefix())
                {
                    context.Writer.WritePropertyName("TapeBarcodePrefix");
                    context.Writer.Write(publicRequest.TapeBarcodePrefix);
                }

                if(publicRequest.IsSetTapeSizeInBytes())
                {
                    context.Writer.WritePropertyName("TapeSizeInBytes");
                    context.Writer.Write(publicRequest.TapeSizeInBytes);
                }

                if(publicRequest.IsSetWorm())
                {
                    context.Writer.WritePropertyName("Worm");
                    context.Writer.Write(publicRequest.Worm);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTapesRequestMarshaller _instance = new CreateTapesRequestMarshaller();        

        internal static CreateTapesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTapesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}