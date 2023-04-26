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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RAM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListPermissionAssociations Request Marshaller
    /// </summary>       
    public class ListPermissionAssociationsRequestMarshaller : IMarshaller<IRequest, ListPermissionAssociationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListPermissionAssociationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListPermissionAssociationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RAM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-01-04";
            request.HttpMethod = "POST";

            request.ResourcePath = "/listpermissionassociations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociationStatus())
                {
                    context.Writer.WritePropertyName("associationStatus");
                    context.Writer.Write(publicRequest.AssociationStatus);
                }

                if(publicRequest.IsSetDefaultVersion())
                {
                    context.Writer.WritePropertyName("defaultVersion");
                    context.Writer.Write(publicRequest.DefaultVersion);
                }

                if(publicRequest.IsSetFeatureSet())
                {
                    context.Writer.WritePropertyName("featureSet");
                    context.Writer.Write(publicRequest.FeatureSet);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetPermissionArn())
                {
                    context.Writer.WritePropertyName("permissionArn");
                    context.Writer.Write(publicRequest.PermissionArn);
                }

                if(publicRequest.IsSetPermissionVersion())
                {
                    context.Writer.WritePropertyName("permissionVersion");
                    context.Writer.Write(publicRequest.PermissionVersion);
                }

                if(publicRequest.IsSetResourceType())
                {
                    context.Writer.WritePropertyName("resourceType");
                    context.Writer.Write(publicRequest.ResourceType);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListPermissionAssociationsRequestMarshaller _instance = new ListPermissionAssociationsRequestMarshaller();        

        internal static ListPermissionAssociationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListPermissionAssociationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}