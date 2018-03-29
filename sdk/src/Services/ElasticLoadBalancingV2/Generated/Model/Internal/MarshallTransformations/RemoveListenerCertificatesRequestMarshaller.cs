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
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RemoveListenerCertificates Request Marshaller
    /// </summary>       
    public class RemoveListenerCertificatesRequestMarshaller : IMarshaller<IRequest, RemoveListenerCertificatesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RemoveListenerCertificatesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RemoveListenerCertificatesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancingV2");
            request.Parameters.Add("Action", "RemoveListenerCertificates");
            request.Parameters.Add("Version", "2015-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCertificates())
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
                if(publicRequest.IsSetListenerArn())
                {
                    request.Parameters.Add("ListenerArn", StringUtils.FromString(publicRequest.ListenerArn));
                }
            }
            return request;
        }
                    private static RemoveListenerCertificatesRequestMarshaller _instance = new RemoveListenerCertificatesRequestMarshaller();        

        internal static RemoveListenerCertificatesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RemoveListenerCertificatesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}