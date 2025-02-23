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
    /// CreateCapacityReservation Request Marshaller
    /// </summary>       
    public class CreateCapacityReservationRequestMarshaller : IMarshaller<IRequest, CreateCapacityReservationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCapacityReservationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCapacityReservationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateCapacityReservation");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
                if(publicRequest.IsSetAvailabilityZoneId())
                {
                    request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetCommitmentDuration())
                {
                    request.Parameters.Add("CommitmentDuration", StringUtils.FromLong(publicRequest.CommitmentDuration));
                }
                if(publicRequest.IsSetDeliveryPreference())
                {
                    request.Parameters.Add("DeliveryPreference", StringUtils.FromString(publicRequest.DeliveryPreference));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEbsOptimized())
                {
                    request.Parameters.Add("EbsOptimized", StringUtils.FromBool(publicRequest.EbsOptimized));
                }
                if(publicRequest.IsSetEndDate())
                {
                    request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
                }
                if(publicRequest.IsSetEndDateType())
                {
                    request.Parameters.Add("EndDateType", StringUtils.FromString(publicRequest.EndDateType));
                }
                if(publicRequest.IsSetEphemeralStorage())
                {
                    request.Parameters.Add("EphemeralStorage", StringUtils.FromBool(publicRequest.EphemeralStorage));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetInstanceMatchCriteria())
                {
                    request.Parameters.Add("InstanceMatchCriteria", StringUtils.FromString(publicRequest.InstanceMatchCriteria));
                }
                if(publicRequest.IsSetInstancePlatform())
                {
                    request.Parameters.Add("InstancePlatform", StringUtils.FromString(publicRequest.InstancePlatform));
                }
                if(publicRequest.IsSetInstanceType())
                {
                    request.Parameters.Add("InstanceType", StringUtils.FromString(publicRequest.InstanceType));
                }
                if(publicRequest.IsSetOutpostArn())
                {
                    request.Parameters.Add("OutpostArn", StringUtils.FromString(publicRequest.OutpostArn));
                }
                if(publicRequest.IsSetPlacementGroupArn())
                {
                    request.Parameters.Add("PlacementGroupArn", StringUtils.FromString(publicRequest.PlacementGroupArn));
                }
                if(publicRequest.IsSetStartDate())
                {
                    request.Parameters.Add("StartDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartDate));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecifications", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecifications" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
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
            }
            return request;
        }
                    private static CreateCapacityReservationRequestMarshaller _instance = new CreateCapacityReservationRequestMarshaller();        

        internal static CreateCapacityReservationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCapacityReservationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}