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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddFacetToObject Request Marshaller
    /// </summary>       
    public class AddFacetToObjectRequestMarshaller : IMarshaller<IRequest, AddFacetToObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddFacetToObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddFacetToObjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-11";            
            request.HttpMethod = "PUT";

            request.ResourcePath = "/amazonclouddirectory/2017-01-11/object/facets";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetObjectAttributeList())
                {
                    context.Writer.WritePropertyName("ObjectAttributeList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestObjectAttributeListListValue in publicRequest.ObjectAttributeList)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AttributeKeyAndValueMarshaller.Instance;
                        marshaller.Marshall(publicRequestObjectAttributeListListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetObjectReference())
                {
                    context.Writer.WritePropertyName("ObjectReference");
                    context.Writer.WriteObjectStart();

                    var marshaller = ObjectReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ObjectReference, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSchemaFacet())
                {
                    context.Writer.WritePropertyName("SchemaFacet");
                    context.Writer.WriteObjectStart();

                    var marshaller = SchemaFacetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchemaFacet, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetDirectoryArn())
                request.Headers["x-amz-data-partition"] = publicRequest.DirectoryArn;

            return request;
        }
        private static AddFacetToObjectRequestMarshaller _instance = new AddFacetToObjectRequestMarshaller();        

        internal static AddFacetToObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddFacetToObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}