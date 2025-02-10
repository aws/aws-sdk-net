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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EKS.Model;
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
namespace Amazon.EKS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAddon Request Marshaller
    /// </summary>       
    public class DeleteAddonRequestMarshaller : IMarshaller<IRequest, DeleteAddonRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAddonRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAddonRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EKS");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-01";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAddonName())
                throw new AmazonEKSException("Request object does not have required field AddonName set");
            request.AddPathResource("{addonName}", StringUtils.FromString(publicRequest.AddonName));
            if (!publicRequest.IsSetClusterName())
                throw new AmazonEKSException("Request object does not have required field ClusterName set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.ClusterName));
            
            if (publicRequest.IsSetPreserve())
                request.Parameters.Add("preserve", StringUtils.FromBool(publicRequest.Preserve));
            request.ResourcePath = "/clusters/{name}/addons/{addonName}";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteAddonRequestMarshaller _instance = new DeleteAddonRequestMarshaller();        

        internal static DeleteAddonRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAddonRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}