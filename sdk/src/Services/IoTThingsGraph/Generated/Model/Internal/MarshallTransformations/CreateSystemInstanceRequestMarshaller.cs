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
 * Do not modify this file. This file is generated from the iotthingsgraph-2018-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTThingsGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTThingsGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSystemInstance Request Marshaller
    /// </summary>       
    public class CreateSystemInstanceRequestMarshaller : IMarshaller<IRequest, CreateSystemInstanceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSystemInstanceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSystemInstanceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTThingsGraph");
            string target = "IotThingsGraphFrontEndService.CreateSystemInstance";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-09-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDefinition())
                {
                    context.Writer.WritePropertyName("definition");
                    context.Writer.WriteObjectStart();

                    var marshaller = DefinitionDocumentMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Definition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetFlowActionsRoleArn())
                {
                    context.Writer.WritePropertyName("flowActionsRoleArn");
                    context.Writer.Write(publicRequest.FlowActionsRoleArn);
                }

                if(publicRequest.IsSetGreengrassGroupName())
                {
                    context.Writer.WritePropertyName("greengrassGroupName");
                    context.Writer.Write(publicRequest.GreengrassGroupName);
                }

                if(publicRequest.IsSetMetricsConfiguration())
                {
                    context.Writer.WritePropertyName("metricsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = MetricsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MetricsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetS3BucketName())
                {
                    context.Writer.WritePropertyName("s3BucketName");
                    context.Writer.Write(publicRequest.S3BucketName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
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

                if(publicRequest.IsSetTarget())
                {
                    context.Writer.WritePropertyName("target");
                    context.Writer.Write(publicRequest.Target);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateSystemInstanceRequestMarshaller _instance = new CreateSystemInstanceRequestMarshaller();        

        internal static CreateSystemInstanceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSystemInstanceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}