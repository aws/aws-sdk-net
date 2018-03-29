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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGroupVersion Request Marshaller
    /// </summary>       
    public class CreateGroupVersionRequestMarshaller : IMarshaller<IRequest, CreateGroupVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGroupVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGroupVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Greengrass");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/greengrass/groups/{GroupId}/versions";
            if (!publicRequest.IsSetGroupId())
                throw new AmazonGreengrassException("Request object does not have required field GroupId set");
            uriResourcePath = uriResourcePath.Replace("{GroupId}", StringUtils.FromString(publicRequest.GroupId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCoreDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("CoreDefinitionVersionArn");
                    context.Writer.Write(publicRequest.CoreDefinitionVersionArn);
                }

                if(publicRequest.IsSetDeviceDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("DeviceDefinitionVersionArn");
                    context.Writer.Write(publicRequest.DeviceDefinitionVersionArn);
                }

                if(publicRequest.IsSetFunctionDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("FunctionDefinitionVersionArn");
                    context.Writer.Write(publicRequest.FunctionDefinitionVersionArn);
                }

                if(publicRequest.IsSetLoggerDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("LoggerDefinitionVersionArn");
                    context.Writer.Write(publicRequest.LoggerDefinitionVersionArn);
                }

                if(publicRequest.IsSetResourceDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("ResourceDefinitionVersionArn");
                    context.Writer.Write(publicRequest.ResourceDefinitionVersionArn);
                }

                if(publicRequest.IsSetSubscriptionDefinitionVersionArn())
                {
                    context.Writer.WritePropertyName("SubscriptionDefinitionVersionArn");
                    context.Writer.Write(publicRequest.SubscriptionDefinitionVersionArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetAmznClientToken())
                request.Headers["X-Amzn-Client-Token"] = publicRequest.AmznClientToken;

            return request;
        }
        private static CreateGroupVersionRequestMarshaller _instance = new CreateGroupVersionRequestMarshaller();        

        internal static CreateGroupVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGroupVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}