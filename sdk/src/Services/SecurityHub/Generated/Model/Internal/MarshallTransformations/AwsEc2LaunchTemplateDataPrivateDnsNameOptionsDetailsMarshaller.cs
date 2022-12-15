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
    /// AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEnableResourceNameDnsAAAARecord())
            {
                context.Writer.WritePropertyName("EnableResourceNameDnsAAAARecord");
                context.Writer.Write(requestObject.EnableResourceNameDnsAAAARecord);
            }

            if(requestObject.IsSetEnableResourceNameDnsARecord())
            {
                context.Writer.WritePropertyName("EnableResourceNameDnsARecord");
                context.Writer.Write(requestObject.EnableResourceNameDnsARecord);
            }

            if(requestObject.IsSetHostnameType())
            {
                context.Writer.WritePropertyName("HostnameType");
                context.Writer.Write(requestObject.HostnameType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetailsMarshaller();

    }
}