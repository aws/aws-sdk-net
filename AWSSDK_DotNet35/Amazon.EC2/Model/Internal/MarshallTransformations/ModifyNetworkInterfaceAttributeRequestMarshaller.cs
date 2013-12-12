/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Modify Network Interface Attribute Request Marshaller
    /// </summary>       
    public class ModifyNetworkInterfaceAttributeRequestMarshaller : IMarshaller<IRequest, ModifyNetworkInterfaceAttributeRequest>
    {
        public IRequest Marshall(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest)
        {
            IRequest request = new DefaultRequest(modifyNetworkInterfaceAttributeRequest, "AmazonEC2");
            request.Parameters.Add("Action", "ModifyNetworkInterfaceAttribute");
            request.Parameters.Add("Version", "2013-10-15");
            if (modifyNetworkInterfaceAttributeRequest != null && modifyNetworkInterfaceAttributeRequest.IsSetNetworkInterfaceId())
            {
                request.Parameters.Add("NetworkInterfaceId", StringUtils.FromString(modifyNetworkInterfaceAttributeRequest.NetworkInterfaceId));
            }
            if (modifyNetworkInterfaceAttributeRequest != null && modifyNetworkInterfaceAttributeRequest.IsSetDescription())
            {
                request.Parameters.Add("Description.Value", StringUtils.FromString(modifyNetworkInterfaceAttributeRequest.Description));
            }
            if (modifyNetworkInterfaceAttributeRequest != null && modifyNetworkInterfaceAttributeRequest.IsSetSourceDestCheck())
            {
                request.Parameters.Add("SourceDestCheck.Value", StringUtils.FromBool(modifyNetworkInterfaceAttributeRequest.SourceDestCheck));
            }
            if (modifyNetworkInterfaceAttributeRequest != null)
            {
                List<string> groupsList = modifyNetworkInterfaceAttributeRequest.Groups;

                int groupsListIndex = 1;
                foreach (string groupsListValue in groupsList)
                { 
                    request.Parameters.Add("SecurityGroupId." + groupsListIndex, StringUtils.FromString(groupsListValue));
                    groupsListIndex++;
                }
            }
            if (modifyNetworkInterfaceAttributeRequest != null)
            {
                NetworkInterfaceAttachmentChanges attachment = modifyNetworkInterfaceAttributeRequest.Attachment;
                if (attachment != null && attachment.IsSetAttachmentId())
                {
                    request.Parameters.Add("Attachment.AttachmentId", StringUtils.FromString(attachment.AttachmentId));
                }
                if (attachment != null && attachment.IsSetDeleteOnTermination())
                {
                    request.Parameters.Add("Attachment.DeleteOnTermination", StringUtils.FromBool(attachment.DeleteOnTermination));
                }
            }

            return request;
        }
    }
}
