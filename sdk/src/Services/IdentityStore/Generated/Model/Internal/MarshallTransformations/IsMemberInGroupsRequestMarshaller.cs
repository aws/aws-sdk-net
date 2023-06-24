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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityStore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IdentityStore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IsMemberInGroups Request Marshaller
    /// </summary>       
    public class IsMemberInGroupsRequestMarshaller : IMarshaller<IRequest, IsMemberInGroupsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((IsMemberInGroupsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(IsMemberInGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityStore");
            string target = "AWSIdentityStore.IsMemberInGroups";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-06-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetGroupIds())
                {
                    context.Writer.WritePropertyName("GroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestGroupIdsListValue in publicRequest.GroupIds)
                    {
                            context.Writer.Write(publicRequestGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetIdentityStoreId())
                {
                    context.Writer.WritePropertyName("IdentityStoreId");
                    context.Writer.Write(publicRequest.IdentityStoreId);
                }

                if(publicRequest.IsSetMemberId())
                {
                    context.Writer.WritePropertyName("MemberId");
                    context.Writer.WriteObjectStart();

                    var marshaller = MemberIdMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MemberId, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static IsMemberInGroupsRequestMarshaller _instance = new IsMemberInGroupsRequestMarshaller();        

        internal static IsMemberInGroupsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IsMemberInGroupsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}