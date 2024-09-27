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
    /// AddListenerCertificates Request Marshaller
    /// </summary>       
    public class AddListenerCertificatesRequestMarshaller : IMarshaller<IRequest, AddListenerCertificatesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AddListenerCertificatesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AddListenerCertificatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "AddListenerCertificates");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCertificates())
                {
                    if (publicRequest.Certificates.Count == 0)
                        request.Parameters.Add("Certificates", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Certificates)
                         {
                            if(publicRequestlistValue.IsSetCertificateArn())
                            {
                                request.Parameters.Add("Certificates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "CertificateArn", StringUtils.FromString(publicRequestlistValue.CertificateArn));
                            }
                            if(publicRequestlistValue.IsSetIsDefault())
                            {
                                request.Parameters.Add("Certificates" + "." + "member" + "." + publicRequestlistValueIndex + "." + "IsDefault", StringUtils.FromBool(publicRequestlistValue.IsDefault));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetListenerArn())
                {
                    request.Parameters.Add("ListenerArn", StringUtils.FromString(publicRequest.ListenerArn));
                }
            }
            return request;
        }
                    private static AddListenerCertificatesRequestMarshaller _instance = new AddListenerCertificatesRequestMarshaller();        

        internal static AddListenerCertificatesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddListenerCertificatesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}