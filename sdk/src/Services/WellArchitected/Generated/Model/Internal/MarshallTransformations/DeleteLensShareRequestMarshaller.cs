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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteLensShare Request Marshaller
    /// </summary>       
    public class DeleteLensShareRequestMarshaller : IMarshaller<IRequest, DeleteLensShareRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteLensShareRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteLensShareRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WellArchitected");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-03-31";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetLensAlias())
                throw new AmazonWellArchitectedException("Request object does not have required field LensAlias set");
            request.AddPathResource("{LensAlias}", StringUtils.FromString(publicRequest.LensAlias));
            if (!publicRequest.IsSetShareId())
                throw new AmazonWellArchitectedException("Request object does not have required field ShareId set");
            request.AddPathResource("{ShareId}", StringUtils.FromString(publicRequest.ShareId));
            
            if (publicRequest.IsSetClientRequestToken())
                request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
            else            
                request.Parameters.Add("ClientRequestToken", System.Guid.NewGuid().ToString());
                
            request.ResourcePath = "/lenses/{LensAlias}/shares/{ShareId}";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteLensShareRequestMarshaller _instance = new DeleteLensShareRequestMarshaller();        

        internal static DeleteLensShareRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteLensShareRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}