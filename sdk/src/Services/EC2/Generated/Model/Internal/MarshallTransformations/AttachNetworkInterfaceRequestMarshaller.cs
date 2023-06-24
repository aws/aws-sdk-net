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
    /// AttachNetworkInterface Request Marshaller
    /// </summary>       
    public class AttachNetworkInterfaceRequestMarshaller : IMarshaller<IRequest, AttachNetworkInterfaceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AttachNetworkInterfaceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AttachNetworkInterfaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "AttachNetworkInterface");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDeviceIndex())
                {
                    request.Parameters.Add("DeviceIndex", StringUtils.FromInt(publicRequest.DeviceIndex));
                }
                if(publicRequest.IsSetEnaSrdSpecification())
                {
                    if(publicRequest.EnaSrdSpecification.IsSetEnaSrdEnabled())
                    {
                        request.Parameters.Add("EnaSrdSpecification" + "." + "EnaSrdEnabled", StringUtils.FromBool(publicRequest.EnaSrdSpecification.EnaSrdEnabled));
                    }
                    if(publicRequest.EnaSrdSpecification.IsSetEnaSrdUdpSpecification())
                    {
                        if(publicRequest.EnaSrdSpecification.EnaSrdUdpSpecification.IsSetEnaSrdUdpEnabled())
                        {
                            request.Parameters.Add("EnaSrdSpecification" + "." + "EnaSrdUdpSpecification" + "." + "EnaSrdUdpEnabled", StringUtils.FromBool(publicRequest.EnaSrdSpecification.EnaSrdUdpSpecification.EnaSrdUdpEnabled));
                        }
                    }
                }
                if(publicRequest.IsSetInstanceId())
                {
                    request.Parameters.Add("InstanceId", StringUtils.FromString(publicRequest.InstanceId));
                }
                if(publicRequest.IsSetNetworkCardIndex())
                {
                    request.Parameters.Add("NetworkCardIndex", StringUtils.FromInt(publicRequest.NetworkCardIndex));
                }
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
            }
            return request;
        }
                    private static AttachNetworkInterfaceRequestMarshaller _instance = new AttachNetworkInterfaceRequestMarshaller();        

        internal static AttachNetworkInterfaceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttachNetworkInterfaceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}