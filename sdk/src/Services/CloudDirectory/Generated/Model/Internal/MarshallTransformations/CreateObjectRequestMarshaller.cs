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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
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
    /// CreateObject Request Marshaller
    /// </summary>       
    public class CreateObjectRequestMarshaller : IMarshaller<IRequest, CreateObjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateObjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateObjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.HttpMethod = "PUT";

            string uriResourcePath = "/amazonclouddirectory/2017-01-11/object";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetLinkName())
                {
                    context.Writer.WritePropertyName("LinkName");
                    context.Writer.Write(publicRequest.LinkName);
                }

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

                if(publicRequest.IsSetParentReference())
                {
                    context.Writer.WritePropertyName("ParentReference");
                    context.Writer.WriteObjectStart();

                    var marshaller = ObjectReferenceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ParentReference, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSchemaFacets())
                {
                    context.Writer.WritePropertyName("SchemaFacets");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSchemaFacetsListValue in publicRequest.SchemaFacets)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SchemaFacetMarshaller.Instance;
                        marshaller.Marshall(publicRequestSchemaFacetsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if(publicRequest.IsSetDirectoryArn())
                request.Headers["x-amz-data-partition"] = publicRequest.DirectoryArn;

            return request;
        }
        private static CreateObjectRequestMarshaller _instance = new CreateObjectRequestMarshaller();        

        internal static CreateObjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateObjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}