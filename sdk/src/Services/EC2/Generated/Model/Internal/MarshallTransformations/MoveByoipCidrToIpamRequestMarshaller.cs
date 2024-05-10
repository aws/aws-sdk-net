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
    /// MoveByoipCidrToIpam Request Marshaller
    /// </summary>       
    public class MoveByoipCidrToIpamRequestMarshaller : IMarshaller<IRequest, MoveByoipCidrToIpamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((MoveByoipCidrToIpamRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(MoveByoipCidrToIpamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "MoveByoipCidrToIpam");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCidr())
                {
                    request.Parameters.Add("Cidr", StringUtils.FromString(publicRequest.Cidr));
                }
                if(publicRequest.IsSetIpamPoolId())
                {
                    request.Parameters.Add("IpamPoolId", StringUtils.FromString(publicRequest.IpamPoolId));
                }
                if(publicRequest.IsSetIpamPoolOwner())
                {
                    request.Parameters.Add("IpamPoolOwner", StringUtils.FromString(publicRequest.IpamPoolOwner));
                }
            }
            return request;
        }
                    private static MoveByoipCidrToIpamRequestMarshaller _instance = new MoveByoipCidrToIpamRequestMarshaller();        

        internal static MoveByoipCidrToIpamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MoveByoipCidrToIpamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}