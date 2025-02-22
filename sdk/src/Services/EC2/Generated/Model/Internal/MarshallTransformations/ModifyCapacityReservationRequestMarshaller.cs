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
    /// ModifyCapacityReservation Request Marshaller
    /// </summary>       
    public class ModifyCapacityReservationRequestMarshaller : IMarshaller<IRequest, ModifyCapacityReservationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyCapacityReservationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyCapacityReservationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyCapacityReservation");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccept())
                {
                    request.Parameters.Add("Accept", StringUtils.FromBool(publicRequest.Accept));
                }
                if(publicRequest.IsSetAdditionalInfo())
                {
                    request.Parameters.Add("AdditionalInfo", StringUtils.FromString(publicRequest.AdditionalInfo));
                }
                if(publicRequest.IsSetCapacityReservationId())
                {
                    request.Parameters.Add("CapacityReservationId", StringUtils.FromString(publicRequest.CapacityReservationId));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEndDate())
                {
                    request.Parameters.Add("EndDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndDate));
                }
                if(publicRequest.IsSetEndDateType())
                {
                    request.Parameters.Add("EndDateType", StringUtils.FromString(publicRequest.EndDateType));
                }
                if(publicRequest.IsSetInstanceCount())
                {
                    request.Parameters.Add("InstanceCount", StringUtils.FromInt(publicRequest.InstanceCount));
                }
                if(publicRequest.IsSetInstanceMatchCriteria())
                {
                    request.Parameters.Add("InstanceMatchCriteria", StringUtils.FromString(publicRequest.InstanceMatchCriteria));
                }
            }
            return request;
        }
                    private static ModifyCapacityReservationRequestMarshaller _instance = new ModifyCapacityReservationRequestMarshaller();        

        internal static ModifyCapacityReservationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyCapacityReservationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}