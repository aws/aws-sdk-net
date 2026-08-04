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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyApplicationStatusCheck Request Marshaller
    /// </summary>       
    public class ModifyApplicationStatusCheckRequestMarshaller : IMarshaller<IRequest, ModifyApplicationStatusCheckRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyApplicationStatusCheckRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyApplicationStatusCheckRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyApplicationStatusCheck");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAggregation())
                {
                    request.Parameters.Add("Aggregation", StringUtils.FromString(publicRequest.Aggregation));
                }
                if(publicRequest.IsSetApplicationStatusCheckId())
                {
                    request.Parameters.Add("ApplicationStatusCheckId", StringUtils.FromString(publicRequest.ApplicationStatusCheckId));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDeviceIndex())
                {
                    request.Parameters.Add("DeviceIndex", StringUtils.FromInt(publicRequest.DeviceIndex));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetFailureThreshold())
                {
                    request.Parameters.Add("FailureThreshold", StringUtils.FromInt(publicRequest.FailureThreshold));
                }
                if(publicRequest.IsSetHealthCheckPaths())
                {
                    if (publicRequest.HealthCheckPaths.Count == 0)
                        request.Parameters.Add("HealthCheckPath", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.HealthCheckPaths)
                         {
                            if(publicRequestlistValue.IsSetDestinations())
                            {
                                if (publicRequestlistValue.Destinations.Count == 0)
                                    request.Parameters.Add("HealthCheckPath" + "." + publicRequestlistValueIndex + "." + "Destination", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Destinations)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetSecurityGroupId())
                                        {
                                            request.Parameters.Add("HealthCheckPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + publicRequestlistValuelistValueIndex + "." + "SecurityGroupId", StringUtils.FromString(publicRequestlistValuelistValue.SecurityGroupId));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetSubnetId())
                                        {
                                            request.Parameters.Add("HealthCheckPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetSource())
                            {
                                if(publicRequestlistValue.Source.IsSetSecurityGroupId())
                                {
                                    request.Parameters.Add("HealthCheckPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "SecurityGroupId", StringUtils.FromString(publicRequestlistValue.Source.SecurityGroupId));
                                }
                                if(publicRequestlistValue.Source.IsSetSubnetId())
                                {
                                    request.Parameters.Add("HealthCheckPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "SubnetId", StringUtils.FromString(publicRequestlistValue.Source.SubnetId));
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetInitializationGracePeriodSeconds())
                {
                    request.Parameters.Add("InitializationGracePeriodSeconds", StringUtils.FromInt(publicRequest.InitializationGracePeriodSeconds));
                }
                if(publicRequest.IsSetInterval())
                {
                    request.Parameters.Add("Interval", StringUtils.FromInt(publicRequest.Interval));
                }
                if(publicRequest.IsSetIpScope())
                {
                    request.Parameters.Add("IpScope", StringUtils.FromString(publicRequest.IpScope));
                }
                if(publicRequest.IsSetIpVersion())
                {
                    request.Parameters.Add("IpVersion", StringUtils.FromString(publicRequest.IpVersion));
                }
                if(publicRequest.IsSetPath())
                {
                    request.Parameters.Add("Path", StringUtils.FromString(publicRequest.Path));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetStatusCodeMatcher())
                {
                    request.Parameters.Add("StatusCodeMatcher", StringUtils.FromString(publicRequest.StatusCodeMatcher));
                }
                if(publicRequest.IsSetSuccessThreshold())
                {
                    request.Parameters.Add("SuccessThreshold", StringUtils.FromInt(publicRequest.SuccessThreshold));
                }
                if(publicRequest.IsSetTimeout())
                {
                    request.Parameters.Add("Timeout", StringUtils.FromInt(publicRequest.Timeout));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static ModifyApplicationStatusCheckRequestMarshaller _instance = new ModifyApplicationStatusCheckRequestMarshaller();        

        internal static ModifyApplicationStatusCheckRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyApplicationStatusCheckRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}