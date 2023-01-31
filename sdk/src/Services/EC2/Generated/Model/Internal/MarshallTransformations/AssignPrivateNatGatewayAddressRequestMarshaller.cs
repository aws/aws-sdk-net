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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssignPrivateNatGatewayAddress Request Marshaller
    /// </summary>       
    public class AssignPrivateNatGatewayAddressRequestMarshaller : IMarshaller<IRequest, AssignPrivateNatGatewayAddressRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssignPrivateNatGatewayAddressRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssignPrivateNatGatewayAddressRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AssignPrivateNatGatewayAddress");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetNatGatewayId())
                {
                    request.Parameters.Add("NatGatewayId", StringUtils.FromString(publicRequest.NatGatewayId));
                }
                if(publicRequest.IsSetPrivateIpAddressCount())
                {
                    request.Parameters.Add("PrivateIpAddressCount", StringUtils.FromInt(publicRequest.PrivateIpAddressCount));
                }
                if(publicRequest.IsSetPrivateIpAddresses())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.PrivateIpAddresses)
                    {
                        request.Parameters.Add("PrivateIpAddress" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static AssignPrivateNatGatewayAddressRequestMarshaller _instance = new AssignPrivateNatGatewayAddressRequestMarshaller();        

        internal static AssignPrivateNatGatewayAddressRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssignPrivateNatGatewayAddressRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}