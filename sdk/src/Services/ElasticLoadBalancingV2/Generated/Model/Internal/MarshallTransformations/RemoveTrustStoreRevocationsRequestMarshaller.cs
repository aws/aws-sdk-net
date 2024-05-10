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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveTrustStoreRevocations Request Marshaller
    /// </summary>       
    public class RemoveTrustStoreRevocationsRequestMarshaller : IMarshaller<IRequest, RemoveTrustStoreRevocationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveTrustStoreRevocationsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveTrustStoreRevocationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "RemoveTrustStoreRevocations");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetRevocationIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.RevocationIds)
                    {
                        request.Parameters.Add("RevocationIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromLong(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTrustStoreArn())
                {
                    request.Parameters.Add("TrustStoreArn", StringUtils.FromString(publicRequest.TrustStoreArn));
                }
            }
            return request;
        }
                    private static RemoveTrustStoreRevocationsRequestMarshaller _instance = new RemoveTrustStoreRevocationsRequestMarshaller();        

        internal static RemoveTrustStoreRevocationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveTrustStoreRevocationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}