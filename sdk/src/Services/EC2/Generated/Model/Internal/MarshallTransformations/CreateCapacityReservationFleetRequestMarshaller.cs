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
    /// CreateCapacityReservationFleet Request Marshaller
    /// </summary>       
    public class CreateCapacityReservationFleetRequestMarshaller : IMarshaller<IRequest, CreateCapacityReservationFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCapacityReservationFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCapacityReservationFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateCapacityReservationFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllocationStrategy())
                {
                    request.Parameters.Add("AllocationStrategy", StringUtils.FromString(publicRequest.AllocationStrategy));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEndDate())
                {
                    request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
                }
                if(publicRequest.IsSetInstanceMatchCriteria())
                {
                    request.Parameters.Add("InstanceMatchCriteria", StringUtils.FromString(publicRequest.InstanceMatchCriteria));
                }
                if(publicRequest.IsSetInstanceTypeSpecifications())
                {
                    if (publicRequest.InstanceTypeSpecifications.Count == 0)
                        request.Parameters.Add("InstanceTypeSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.InstanceTypeSpecifications)
                         {
                            if(publicRequestlistValue.IsSetAvailabilityZone())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValue.AvailabilityZone));
                            }
                            if(publicRequestlistValue.IsSetAvailabilityZoneId())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "AvailabilityZoneId", StringUtils.FromString(publicRequestlistValue.AvailabilityZoneId));
                            }
                            if(publicRequestlistValue.IsSetEbsOptimized())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "EbsOptimized", StringUtils.FromBool(publicRequestlistValue.EbsOptimized));
                            }
                            if(publicRequestlistValue.IsSetInstancePlatform())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "InstancePlatform", StringUtils.FromString(publicRequestlistValue.InstancePlatform));
                            }
                            if(publicRequestlistValue.IsSetInstanceType())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValue.InstanceType));
                            }
                            if(publicRequestlistValue.IsSetPriority())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "Priority", StringUtils.FromInt(publicRequestlistValue.Priority));
                            }
                            if(publicRequestlistValue.IsSetWeight())
                            {
                                request.Parameters.Add("InstanceTypeSpecification" + "." + publicRequestlistValueIndex + "." + "Weight", StringUtils.FromDouble(publicRequestlistValue.Weight));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTenancy())
                {
                    request.Parameters.Add("Tenancy", StringUtils.FromString(publicRequest.Tenancy));
                }
                if(publicRequest.IsSetTotalTargetCapacity())
                {
                    request.Parameters.Add("TotalTargetCapacity", StringUtils.FromInt(publicRequest.TotalTargetCapacity));
                }
            }
            return request;
        }
                    private static CreateCapacityReservationFleetRequestMarshaller _instance = new CreateCapacityReservationFleetRequestMarshaller();        

        internal static CreateCapacityReservationFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCapacityReservationFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}