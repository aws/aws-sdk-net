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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartAnnotationImportJob Request Marshaller
    /// </summary>       
    public class StartAnnotationImportJobRequestMarshaller : IMarshaller<IRequest, StartAnnotationImportJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartAnnotationImportJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartAnnotationImportJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/import/annotation";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDestinationName())
                {
                    context.Writer.WritePropertyName("destinationName");
                    context.Writer.Write(publicRequest.DestinationName);
                }

                if(publicRequest.IsSetFormatOptions())
                {
                    context.Writer.WritePropertyName("formatOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = FormatOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.FormatOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetItems())
                {
                    context.Writer.WritePropertyName("items");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestItemsListValue in publicRequest.Items)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AnnotationImportItemSourceMarshaller.Instance;
                        marshaller.Marshall(publicRequestItemsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetRunLeftNormalization())
                {
                    context.Writer.WritePropertyName("runLeftNormalization");
                    context.Writer.Write(publicRequest.RunLeftNormalization);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"analytics-";

            return request;
        }
        private static StartAnnotationImportJobRequestMarshaller _instance = new StartAnnotationImportJobRequestMarshaller();        

        internal static StartAnnotationImportJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartAnnotationImportJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}