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
    /// ModifyInstanceCapacityReservationAttributes Request Marshaller
    /// </summary>       
    public class ModifyInstanceCapacityReservationAttributesRequestMarshaller : IMarshaller<IRequest, ModifyInstanceCapacityReservationAttributesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyInstanceCapacityReservationAttributesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyInstanceCapacityReservationAttributesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyInstanceCapacityReservationAttributes");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCapacityReservationSpecification())
                {
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationPreference())
                    {
                        request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationPreference", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationPreference));
                    }
                    if(publicRequest.CapacityReservationSpecification.IsSetCapacityReservationTarget())
                    {
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationId())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationId", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationId));
                        }
                        if(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.IsSetCapacityReservationResourceGroupArn())
                        {
                            request.Parameters.Add("CapacityReservationSpecification" + "." + "CapacityReservationTarget" + "." + "CapacityReservationResourceGroupArn", StringUtils.FromString(publicRequest.CapacityReservationSpecification.CapacityReservationTarget.CapacityReservationResourceGroupArn));
                        }
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
            }
            return request;
        }
                    private static ModifyInstanceCapacityReservationAttributesRequestMarshaller _instance = new ModifyInstanceCapacityReservationAttributesRequestMarshaller();        

        internal static ModifyInstanceCapacityReservationAttributesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyInstanceCapacityReservationAttributesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}