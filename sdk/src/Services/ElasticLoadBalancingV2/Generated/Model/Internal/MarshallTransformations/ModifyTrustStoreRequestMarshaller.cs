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
    /// ModifyTrustStore Request Marshaller
    /// </summary>       
    public class ModifyTrustStoreRequestMarshaller : IMarshaller<IRequest, ModifyTrustStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTrustStoreRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyTrustStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "ModifyTrustStore");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCaCertificatesBundleS3Bucket())
                {
                    request.Parameters.Add("CaCertificatesBundleS3Bucket", StringUtils.FromString(publicRequest.CaCertificatesBundleS3Bucket));
                }
                if(publicRequest.IsSetCaCertificatesBundleS3Key())
                {
                    request.Parameters.Add("CaCertificatesBundleS3Key", StringUtils.FromString(publicRequest.CaCertificatesBundleS3Key));
                }
                if(publicRequest.IsSetCaCertificatesBundleS3ObjectVersion())
                {
                    request.Parameters.Add("CaCertificatesBundleS3ObjectVersion", StringUtils.FromString(publicRequest.CaCertificatesBundleS3ObjectVersion));
                }
                if(publicRequest.IsSetTrustStoreArn())
                {
                    request.Parameters.Add("TrustStoreArn", StringUtils.FromString(publicRequest.TrustStoreArn));
                }
            }
            return request;
        }
                    private static ModifyTrustStoreRequestMarshaller _instance = new ModifyTrustStoreRequestMarshaller();        

        internal static ModifyTrustStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyTrustStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}