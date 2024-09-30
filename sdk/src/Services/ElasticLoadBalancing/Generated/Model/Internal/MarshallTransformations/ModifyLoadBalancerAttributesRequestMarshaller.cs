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
    /// ModifyLoadBalancerAttributes Request Marshaller
    /// </summary>       
    public class ModifyLoadBalancerAttributesRequestMarshaller : IMarshaller<IRequest, ModifyLoadBalancerAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyLoadBalancerAttributesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyLoadBalancerAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticLoadBalancing");
            request.Parameters.Add("Action", "ModifyLoadBalancerAttributes");
            request.Parameters.Add("Version", "2012-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetLoadBalancerAttributes())
                {
                    if(publicRequest.LoadBalancerAttributes.IsSetAccessLog())
                    {
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetEmitInterval())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "EmitInterval", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.AccessLog.EmitInterval));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.AccessLog.Enabled));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketName())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "S3BucketName", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketName));
                        }
                        if(publicRequest.LoadBalancerAttributes.AccessLog.IsSetS3BucketPrefix())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AccessLog" + "." + "S3BucketPrefix", StringUtils.FromString(publicRequest.LoadBalancerAttributes.AccessLog.S3BucketPrefix));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetAdditionalAttributes())
                    {
                        if (publicRequest.LoadBalancerAttributes.AdditionalAttributes.Count == 0)
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "AdditionalAttributes", "");
                        else
                        {
                             int publicRequestLoadBalancerAttributeslistValueIndex = 1;
                             foreach(var publicRequestLoadBalancerAttributeslistValue in publicRequest.LoadBalancerAttributes.AdditionalAttributes)
                             {
                                if(publicRequestLoadBalancerAttributeslistValue.IsSetKey())
                                {
                                    request.Parameters.Add("LoadBalancerAttributes" + "." + "AdditionalAttributes" + "." + "member" + "." + publicRequestLoadBalancerAttributeslistValueIndex + "." + "Key", StringUtils.FromString(publicRequestLoadBalancerAttributeslistValue.Key));
                                }
                                if(publicRequestLoadBalancerAttributeslistValue.IsSetValue())
                                {
                                    request.Parameters.Add("LoadBalancerAttributes" + "." + "AdditionalAttributes" + "." + "member" + "." + publicRequestLoadBalancerAttributeslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestLoadBalancerAttributeslistValue.Value));
                                }
                                 publicRequestLoadBalancerAttributeslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetConnectionDraining())
                    {
                        if(publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionDraining" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.ConnectionDraining.Enabled));
                        }
                        if(publicRequest.LoadBalancerAttributes.ConnectionDraining.IsSetTimeout())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionDraining" + "." + "Timeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionDraining.Timeout));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetConnectionSettings())
                    {
                        if(publicRequest.LoadBalancerAttributes.ConnectionSettings.IsSetIdleTimeout())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "ConnectionSettings" + "." + "IdleTimeout", StringUtils.FromInt(publicRequest.LoadBalancerAttributes.ConnectionSettings.IdleTimeout));
                        }
                    }
                    if(publicRequest.LoadBalancerAttributes.IsSetCrossZoneLoadBalancing())
                    {
                        if(publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.IsSetEnabled())
                        {
                            request.Parameters.Add("LoadBalancerAttributes" + "." + "CrossZoneLoadBalancing" + "." + "Enabled", StringUtils.FromBool(publicRequest.LoadBalancerAttributes.CrossZoneLoadBalancing.Enabled));
                        }
                    }
                }
                if(publicRequest.IsSetLoadBalancerName())
                {
                    request.Parameters.Add("LoadBalancerName", StringUtils.FromString(publicRequest.LoadBalancerName));
                }
            }
            return request;
        }
                    private static ModifyLoadBalancerAttributesRequestMarshaller _instance = new ModifyLoadBalancerAttributesRequestMarshaller();        

        internal static ModifyLoadBalancerAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyLoadBalancerAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}