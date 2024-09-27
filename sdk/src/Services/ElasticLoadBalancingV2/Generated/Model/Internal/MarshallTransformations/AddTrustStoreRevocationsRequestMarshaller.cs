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
    /// AddTrustStoreRevocations Request Marshaller
    /// </summary>       
    public class AddTrustStoreRevocationsRequestMarshaller : IMarshaller<IRequest, AddTrustStoreRevocationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddTrustStoreRevocationsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddTrustStoreRevocationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "AddTrustStoreRevocations");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetRevocationContents())
                {
                    if (publicRequest.RevocationContents.Count == 0)
                        request.Parameters.Add("RevocationContents", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RevocationContents)
                         {
                            if(publicRequestlistValue.IsSetRevocationType())
                            {
                                request.Parameters.Add("RevocationContents" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RevocationType", StringUtils.FromString(publicRequestlistValue.RevocationType));
                            }
                            if(publicRequestlistValue.IsSetS3Bucket())
                            {
                                request.Parameters.Add("RevocationContents" + "." + "member" + "." + publicRequestlistValueIndex + "." + "S3Bucket", StringUtils.FromString(publicRequestlistValue.S3Bucket));
                            }
                            if(publicRequestlistValue.IsSetS3Key())
                            {
                                request.Parameters.Add("RevocationContents" + "." + "member" + "." + publicRequestlistValueIndex + "." + "S3Key", StringUtils.FromString(publicRequestlistValue.S3Key));
                            }
                            if(publicRequestlistValue.IsSetS3ObjectVersion())
                            {
                                request.Parameters.Add("RevocationContents" + "." + "member" + "." + publicRequestlistValueIndex + "." + "S3ObjectVersion", StringUtils.FromString(publicRequestlistValue.S3ObjectVersion));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTrustStoreArn())
                {
                    request.Parameters.Add("TrustStoreArn", StringUtils.FromString(publicRequest.TrustStoreArn));
                }
            }
            return request;
        }
                    private static AddTrustStoreRevocationsRequestMarshaller _instance = new AddTrustStoreRevocationsRequestMarshaller();        

        internal static AddTrustStoreRevocationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddTrustStoreRevocationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}