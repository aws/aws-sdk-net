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
                if(publicRequest.IsSetAssociatedSubnetIds())
                {
                    if (publicRequest.AssociatedSubnetIds.Count == 0)
                        request.Parameters.Add("AssociatedSubnetId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AssociatedSubnetIds)
                         {
                             request.Parameters.Add("AssociatedSubnetId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetAssociatePublicIpAddress())
                {
                    request.Parameters.Add("AssociatePublicIpAddress", StringUtils.FromBool(publicRequest.AssociatePublicIpAddress));
                }
                if(publicRequest.IsSetAttachment())
                {
                    if(publicRequest.Attachment.IsSetAttachmentId())
                    {
                        request.Parameters.Add("Attachment" + "." + "AttachmentId", StringUtils.FromString(publicRequest.Attachment.AttachmentId));
                    }
                    if(publicRequest.Attachment.IsSetDefaultEnaQueueCount())
                    {
                        request.Parameters.Add("Attachment" + "." + "DefaultEnaQueueCount", StringUtils.FromBool(publicRequest.Attachment.DefaultEnaQueueCount));
                    }
                    if(publicRequest.Attachment.IsSetDeleteOnTermination())
                    {
                        request.Parameters.Add("Attachment" + "." + "DeleteOnTermination", StringUtils.FromBool(publicRequest.Attachment.DeleteOnTermination));
                    }
                    if(publicRequest.Attachment.IsSetEnaQueueCount())
                    {
                        request.Parameters.Add("Attachment" + "." + "EnaQueueCount", StringUtils.FromInt(publicRequest.Attachment.EnaQueueCount));
                    }
                }
                if(publicRequest.IsSetConnectionTrackingSpecification())
                {
                    if(publicRequest.ConnectionTrackingSpecification.IsSetTcpEstablishedTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "TcpEstablishedTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.TcpEstablishedTimeout));
                    }
                    if(publicRequest.ConnectionTrackingSpecification.IsSetUdpStreamTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "UdpStreamTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpStreamTimeout));
                    }
                    if(publicRequest.ConnectionTrackingSpecification.IsSetUdpTimeout())
                    {
                        request.Parameters.Add("ConnectionTrackingSpecification" + "." + "UdpTimeout", StringUtils.FromInt(publicRequest.ConnectionTrackingSpecification.UdpTimeout));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description.Value", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEnablePrimaryIpv6())
                {
                    request.Parameters.Add("EnablePrimaryIpv6", StringUtils.FromBool(publicRequest.EnablePrimaryIpv6));
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
                    if (publicRequest.Groups.Count == 0)
                        request.Parameters.Add("SecurityGroupId", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Groups)
                         {
                             request.Parameters.Add("SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
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