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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2InstanceDetails Marshaller
    /// </summary>
    public class AwsEc2InstanceDetailsMarshaller : IRequestMarshaller<AwsEc2InstanceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2InstanceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetIamInstanceProfileArn())
            {
                context.Writer.WritePropertyName("IamInstanceProfileArn");
                context.Writer.Write(requestObject.IamInstanceProfileArn);
            }

            if(requestObject.IsSetImageId())
            {
                context.Writer.WritePropertyName("ImageId");
                context.Writer.Write(requestObject.ImageId);
            }

            if(requestObject.IsSetIpV4Addresses())
            {
                context.Writer.WritePropertyName("IpV4Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpV4AddressesListValue in requestObject.IpV4Addresses)
                {
                        context.Writer.Write(requestObjectIpV4AddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIpV6Addresses())
            {
                context.Writer.WritePropertyName("IpV6Addresses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIpV6AddressesListValue in requestObject.IpV6Addresses)
                {
                        context.Writer.Write(requestObjectIpV6AddressesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeyName())
            {
                context.Writer.WritePropertyName("KeyName");
                context.Writer.Write(requestObject.KeyName);
            }

            if(requestObject.IsSetLaunchedAt())
            {
                context.Writer.WritePropertyName("LaunchedAt");
                context.Writer.Write(requestObject.LaunchedAt);
            }

            if(requestObject.IsSetMetadataOptions())
            {
                context.Writer.WritePropertyName("MetadataOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2InstanceMetadataOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.MetadataOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonitoring())
            {
                context.Writer.WritePropertyName("Monitoring");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2InstanceMonitoringDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Monitoring, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkInterfaces())
            {
                context.Writer.WritePropertyName("NetworkInterfaces");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkInterfacesListValue in requestObject.NetworkInterfaces)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2InstanceNetworkInterfacesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkInterfacesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("SubnetId");
                context.Writer.Write(requestObject.SubnetId);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetVirtualizationType())
            {
                context.Writer.WritePropertyName("VirtualizationType");
                context.Writer.Write(requestObject.VirtualizationType);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.Write(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2InstanceDetailsMarshaller Instance = new AwsEc2InstanceDetailsMarshaller();

    }
}