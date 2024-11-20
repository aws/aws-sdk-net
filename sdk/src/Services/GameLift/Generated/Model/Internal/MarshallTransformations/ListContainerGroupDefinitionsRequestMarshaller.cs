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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GameLift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GameLift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListContainerGroupDefinitions Request Marshaller
    /// </summary>       
    public class ListContainerGroupDefinitionsRequestMarshaller : IMarshaller<IRequest, ListContainerGroupDefinitionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListContainerGroupDefinitionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListContainerGroupDefinitionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GameLift");
            string target = "GameLift.ListContainerGroupDefinitions";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (MemoryStream memoryStream = new MemoryStream())
            {
<<<<<<< HEAD
                using (StreamWriter streamWriter = new InvariantCultureStreamWriter(memoryStream))
||||||| Commit version number update changes
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLimit())
=======
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetContainerGroupType())
                {
                    context.Writer.WritePropertyName("ContainerGroupType");
                    context.Writer.Write(publicRequest.ContainerGroupType);
                }

                if(publicRequest.IsSetLimit())
>>>>>>> acae479fe47dc2583f625fe9f3d68413573ee15b
                {
                    JsonWriter writer = new JsonWriter(streamWriter);
                    writer.Validate = false;
                    writer.WriteObjectStart();
                    var context = new JsonMarshallerContext(request, writer);
                    if(publicRequest.IsSetLimit())
                    {
                        context.Writer.WritePropertyName("Limit");
                        context.Writer.Write(publicRequest.Limit.Value);
                    }

                    if(publicRequest.IsSetNextToken())
                    {
                        context.Writer.WritePropertyName("NextToken");
                        context.Writer.Write(publicRequest.NextToken);
                    }

<<<<<<< HEAD
                    if(publicRequest.IsSetSchedulingStrategy())
                    {
                        context.Writer.WritePropertyName("SchedulingStrategy");
                        context.Writer.Write(publicRequest.SchedulingStrategy);
                    }

                    writer.WriteObjectEnd();
                }

                request.Content = memoryStream.ToArray();
||||||| Commit version number update changes
                if(publicRequest.IsSetSchedulingStrategy())
                {
                    context.Writer.WritePropertyName("SchedulingStrategy");
                    context.Writer.Write(publicRequest.SchedulingStrategy);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
=======
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
>>>>>>> acae479fe47dc2583f625fe9f3d68413573ee15b
            }


            return request;
        }
        private static ListContainerGroupDefinitionsRequestMarshaller _instance = new ListContainerGroupDefinitionsRequestMarshaller();        

        internal static ListContainerGroupDefinitionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListContainerGroupDefinitionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}