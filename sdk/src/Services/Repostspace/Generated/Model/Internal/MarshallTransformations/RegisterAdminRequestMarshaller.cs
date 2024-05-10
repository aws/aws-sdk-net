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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Repostspace.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Repostspace.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterAdmin Request Marshaller
    /// </summary>       
    public class RegisterAdminRequestMarshaller : IMarshaller<IRequest, RegisterAdminRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterAdminRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterAdminRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Repostspace");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-05-13";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAdminId())
                throw new AmazonRepostspaceException("Request object does not have required field AdminId set");
            request.AddPathResource("{adminId}", StringUtils.FromString(publicRequest.AdminId));
            if (!publicRequest.IsSetSpaceId())
                throw new AmazonRepostspaceException("Request object does not have required field SpaceId set");
            request.AddPathResource("{spaceId}", StringUtils.FromString(publicRequest.SpaceId));
            request.ResourcePath = "/spaces/{spaceId}/admins/{adminId}";

            return request;
        }
        private static RegisterAdminRequestMarshaller _instance = new RegisterAdminRequestMarshaller();        

        internal static RegisterAdminRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterAdminRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}