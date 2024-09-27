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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLoadBalancer Request Marshaller
    /// </summary>       
    public class CreateLoadBalancerRequestMarshaller : IMarshaller<IRequest, CreateLoadBalancerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLoadBalancerRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLoadBalancerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "CreateLoadBalancer");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAvailabilityZones())
                {
                    if (publicRequest.AvailabilityZones.Count == 0)
                        request.Parameters.Add("AvailabilityZones", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AvailabilityZones)
                         {
                             request.Parameters.Add("AvailabilityZones" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetListeners())
                {
                    if (publicRequest.Listeners.Count == 0)
                        request.Parameters.Add("Listeners", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Listeners)
                         {
                            if(publicRequestlistValue.IsSetInstancePort())
                            {
                                request.Parameters.Add("Listeners" + "." + "member" + "." + publicRequestlistValueIndex + "." + "InstancePort", StringUtils.FromInt(publicRequestlistValue.InstancePort));
                            }
                            if(publicRequestlistValue.IsSetInstanceProtocol())
                            {
                                request.Parameters.Add("Listeners" + "." + "member" + "." + publicRequestlistValueIndex + "." + "InstanceProtocol", StringUtils.FromString(publicRequestlistValue.InstanceProtocol));
                            }
                            if(publicRequestlistValue.IsSetLoadBalancerPort())
                            {
                                request.Parameters.Add("Listeners" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LoadBalancerPort", StringUtils.FromInt(publicRequestlistValue.LoadBalancerPort));
                            }
                            if(publicRequestlistValue.IsSetProtocol())
                            {
                                request.Parameters.Add("Listeners" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Protocol", StringUtils.FromString(publicRequestlistValue.Protocol));
                            }
                            if(publicRequestlistValue.IsSetSSLCertificateId())
                            {
                                request.Parameters.Add("Listeners" + "." + "member" + "." + publicRequestlistValueIndex + "." + "SSLCertificateId", StringUtils.FromString(publicRequestlistValue.SSLCertificateId));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
                if(publicRequest.IsSetScheme())
                {
                    request.Parameters.Add("Scheme", StringUtils.FromString(publicRequest.Scheme));
                }
                if(publicRequest.IsSetSecurityGroups())
                {
                    if (publicRequest.SecurityGroups.Count == 0)
                        request.Parameters.Add("SecurityGroups", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroups)
                         {
                             request.Parameters.Add("SecurityGroups" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSubnets())
                {
                    if (publicRequest.Subnets.Count == 0)
                        request.Parameters.Add("Subnets", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Subnets)
                         {
                             request.Parameters.Add("Subnets" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static CreateLoadBalancerRequestMarshaller _instance = new CreateLoadBalancerRequestMarshaller();        

        internal static CreateLoadBalancerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLoadBalancerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}