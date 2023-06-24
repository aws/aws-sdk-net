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
    /// ModifyNetworkInterfaceAttribute Request Marshaller
    /// </summary>       
    public class ModifyNetworkInterfaceAttributeRequestMarshaller : IMarshaller<IRequest, ModifyNetworkInterfaceAttributeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyNetworkInterfaceAttributeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyNetworkInterfaceAttributeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyNetworkInterfaceAttribute");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAttachment())
                {
                    if(publicRequest.Attachment.IsSetAttachmentId())
                    {
                        request.Parameters.Add("Attachment" + "." + "AttachmentId", StringUtils.FromString(publicRequest.Attachment.AttachmentId));
                    }
                    if(publicRequest.Attachment.IsSetDeleteOnTermination())
                    {
                        request.Parameters.Add("Attachment" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequest.Attachment.DeleteOnTermination));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description.Value", StringUtils.FromString(publicRequest.Description));
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
                if(publicRequest.IsSetGroups())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Groups)
                    {
                        request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetNetworkInterfaceId())
                {
                    request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(publicRequest.NetworkInterfaceId));
                }
                if(publicRequest.IsSetSourceDestCheck())
                {
                    request.Parameters.Add("SourceDestCheck.Value", StringUtils.FromBool(publicRequest.SourceDestCheck));
                }
            }
            return request;
        }
                    private static ModifyNetworkInterfaceAttributeRequestMarshaller _instance = new ModifyNetworkInterfaceAttributeRequestMarshaller();        

        internal static ModifyNetworkInterfaceAttributeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyNetworkInterfaceAttributeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}