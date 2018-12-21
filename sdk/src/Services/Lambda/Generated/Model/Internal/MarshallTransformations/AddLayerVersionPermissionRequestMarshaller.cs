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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddLayerVersionPermission Request Marshaller
    /// </summary>       
    public class AddLayerVersionPermissionRequestMarshaller : IMarshaller<IRequest, AddLayerVersionPermissionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddLayerVersionPermissionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddLayerVersionPermissionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Lambda");
            request.Headers["Content-Type"] = "application/x-amz-json-";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-03-31";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/2018-10-31/layers/{LayerName}/versions/{VersionNumber}/policy";
            if (!publicRequest.IsSetLayerName())
                throw new AmazonLambdaException("Request object does not have required field LayerName set");
            uriResourcePath = uriResourcePath.Replace("{LayerName}", StringUtils.FromStringWithSlashEncoding(publicRequest.LayerName));
            if (!publicRequest.IsSetVersionNumber())
                throw new AmazonLambdaException("Request object does not have required field VersionNumber set");
            uriResourcePath = uriResourcePath.Replace("{VersionNumber}", StringUtils.FromLong(publicRequest.VersionNumber));
            
            if (publicRequest.IsSetRevisionId())
                request.Parameters.Add("RevisionId", StringUtils.FromString(publicRequest.RevisionId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAction())
                {
                    context.Writer.WritePropertyName("Action");
                    context.Writer.Write(publicRequest.Action);
                }

                if(publicRequest.IsSetOrganizationId())
                {
                    context.Writer.WritePropertyName("OrganizationId");
                    context.Writer.Write(publicRequest.OrganizationId);
                }

                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("Principal");
                    context.Writer.Write(publicRequest.Principal);
                }

                if(publicRequest.IsSetStatementId())
                {
                    context.Writer.WritePropertyName("StatementId");
                    context.Writer.Write(publicRequest.StatementId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            request.UseQueryString = true;

            return request;
        }
        private static AddLayerVersionPermissionRequestMarshaller _instance = new AddLayerVersionPermissionRequestMarshaller();        

        internal static AddLayerVersionPermissionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddLayerVersionPermissionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}