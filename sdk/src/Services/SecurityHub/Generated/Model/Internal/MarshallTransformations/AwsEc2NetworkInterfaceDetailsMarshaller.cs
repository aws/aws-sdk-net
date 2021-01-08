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
    /// AwsEc2NetworkInterfaceDetails Marshaller
    /// </summary>       
    public class AwsEc2NetworkInterfaceDetailsMarshaller : IRequestMarshaller<AwsEc2NetworkInterfaceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2NetworkInterfaceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttachment())
            {
                context.Writer.WritePropertyName("Attachment");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2NetworkInterfaceAttachmentMarshaller.Instance;
                marshaller.Marshall(requestObject.Attachment, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkInterfaceId())
            {
                context.Writer.WritePropertyName("NetworkInterfaceId");
                context.Writer.Write(requestObject.NetworkInterfaceId);
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEc2NetworkInterfaceSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectSecurityGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceDestCheck())
            {
                context.Writer.WritePropertyName("SourceDestCheck");
                context.Writer.Write(requestObject.SourceDestCheck);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEc2NetworkInterfaceDetailsMarshaller Instance = new AwsEc2NetworkInterfaceDetailsMarshaller();

    }
}