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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartImportTask Request Marshaller
    /// </summary>       
    public class StartImportTaskRequestMarshaller : IMarshaller<IRequest, StartImportTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartImportTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartImportTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NeptuneGraph");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-29";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetGraphIdentifier())
                throw new AmazonNeptuneGraphException("Request object does not have required field GraphIdentifier set");
            request.AddPathResource("{graphIdentifier}", StringUtils.FromString(publicRequest.GraphIdentifier));
            request.ResourcePath = "/graphs/{graphIdentifier}/importtasks";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlankNodeHandling())
                {
                    context.Writer.WritePropertyName("blankNodeHandling");
                    context.Writer.Write(publicRequest.BlankNodeHandling);
                }

                if(publicRequest.IsSetFailOnError())
                {
                    context.Writer.WritePropertyName("failOnError");
                    context.Writer.Write(publicRequest.FailOnError);
                }

                if(publicRequest.IsSetFormat())
                {
                    context.Writer.WritePropertyName("format");
                    context.Writer.Write(publicRequest.Format);
                }

                if(publicRequest.IsSetImportOptions())
                {
                    context.Writer.WritePropertyName("importOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = ImportOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ImportOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetParquetType())
                {
                    context.Writer.WritePropertyName("parquetType");
                    context.Writer.Write(publicRequest.ParquetType);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetSource())
                {
                    context.Writer.WritePropertyName("source");
                    context.Writer.Write(publicRequest.Source);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartImportTaskRequestMarshaller _instance = new StartImportTaskRequestMarshaller();        

        internal static StartImportTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartImportTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}