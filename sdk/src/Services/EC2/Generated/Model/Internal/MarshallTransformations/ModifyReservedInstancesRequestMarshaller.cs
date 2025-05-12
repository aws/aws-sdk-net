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
    /// ModifyReservedInstances Request Marshaller
    /// </summary>       
    public class ModifyReservedInstancesRequestMarshaller : IMarshaller<IRequest, ModifyReservedInstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyReservedInstancesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyReservedInstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyReservedInstances");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetReservedInstancesIds())
                {
                    if (publicRequest.ReservedInstancesIds.Count == 0)
                        request.Parameters.Add("ReservedInstancesId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ReservedInstancesIds)
                         {
                             request.Parameters.Add("ReservedInstancesId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTargetConfigurations())
                {
                    if (publicRequest.TargetConfigurations.Count == 0)
                        request.Parameters.Add("ReservedInstancesConfigurationSetItemType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TargetConfigurations)
                         {
                            if(publicRequestlistValue.IsSetAvailabilityZone())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValue.AvailabilityZone));
                            }
                            if(publicRequestlistValue.IsSetAvailabilityZoneId())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestlistValue.AvailabilityZoneId));
                            }
                            if(publicRequestlistValue.IsSetInstanceCount())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "InstanceCount", StringUtils.FromInt(publicRequestlistValue.InstanceCount));
                            }
                            if(publicRequestlistValue.IsSetInstanceType())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValue.InstanceType));
                            }
                            if(publicRequestlistValue.IsSetPlatform())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "Platform", StringUtils.FromString(publicRequestlistValue.Platform));
                            }
                            if(publicRequestlistValue.IsSetScope())
                            {
                                request.Parameters.Add("ReservedInstancesConfigurationSetItemType" + "." + publicRequestlistValueIndex + "." + "Scope", StringUtils.FromString(publicRequestlistValue.Scope));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static ModifyReservedInstancesRequestMarshaller _instance = new ModifyReservedInstancesRequestMarshaller();        

        internal static ModifyReservedInstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyReservedInstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}