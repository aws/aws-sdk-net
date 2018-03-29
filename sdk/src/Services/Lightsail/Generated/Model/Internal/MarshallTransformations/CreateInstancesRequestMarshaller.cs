/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateInstances Request Marshaller
    /// </summary>       
    public class CreateInstancesRequestMarshaller : IMarshaller<IRequest, CreateInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateInstancesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lightsail");
            string target = "Lightsail_20161128.CreateInstances";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetBlueprintId())
                {
                    context.Writer.WritePropertyName("blueprintId");
                    context.Writer.Write(publicRequest.BlueprintId);
                }

                if(publicRequest.IsSetBundleId())
                {
                    context.Writer.WritePropertyName("bundleId");
                    context.Writer.Write(publicRequest.BundleId);
                }

                if(publicRequest.IsSetCustomImageName())
                {
                    context.Writer.WritePropertyName("customImageName");
                    context.Writer.Write(publicRequest.CustomImageName);
                }

                if(publicRequest.IsSetInstanceNames())
                {
                    context.Writer.WritePropertyName("instanceNames");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInstanceNamesListValue in publicRequest.InstanceNames)
                    {
                            context.Writer.Write(publicRequestInstanceNamesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetKeyPairName())
                {
                    context.Writer.WritePropertyName("keyPairName");
                    context.Writer.Write(publicRequest.KeyPairName);
                }

                if(publicRequest.IsSetUserData())
                {
                    context.Writer.WritePropertyName("userData");
                    context.Writer.Write(publicRequest.UserData);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateInstancesRequestMarshaller _instance = new CreateInstancesRequestMarshaller();        

        internal static CreateInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}