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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePackage Request Marshaller
    /// </summary>       
    public class CreatePackageRequestMarshaller : IMarshaller<IRequest, CreatePackageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePackageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePackageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Elasticsearch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-01-01";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/2015-01-01/packages";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetPackageDescription())
                {
                    context.Writer.WritePropertyName("PackageDescription");
                    context.Writer.Write(publicRequest.PackageDescription);
                }

                if(publicRequest.IsSetPackageName())
                {
                    context.Writer.WritePropertyName("PackageName");
                    context.Writer.Write(publicRequest.PackageName);
                }

                if(publicRequest.IsSetPackageSource())
                {
                    context.Writer.WritePropertyName("PackageSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = PackageSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PackageSource, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPackageType())
                {
                    context.Writer.WritePropertyName("PackageType");
                    context.Writer.Write(publicRequest.PackageType);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreatePackageRequestMarshaller _instance = new CreatePackageRequestMarshaller();        

        internal static CreatePackageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePackageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}