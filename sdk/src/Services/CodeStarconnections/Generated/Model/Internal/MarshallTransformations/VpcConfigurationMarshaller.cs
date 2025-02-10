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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeStarconnections.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeStarconnections.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VpcConfiguration Marshaller
    /// </summary>
    public class VpcConfigurationMarshaller : IRequestMarshaller<VpcConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VpcConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("SecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.WriteStringValue(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTlsCertificate())
            {
                context.Writer.WritePropertyName("TlsCertificate");
                context.Writer.WriteStringValue(requestObject.TlsCertificate);
            }

            if(requestObject.IsSetVpcId())
            {
                context.Writer.WritePropertyName("VpcId");
                context.Writer.WriteStringValue(requestObject.VpcId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VpcConfigurationMarshaller Instance = new VpcConfigurationMarshaller();

    }
}