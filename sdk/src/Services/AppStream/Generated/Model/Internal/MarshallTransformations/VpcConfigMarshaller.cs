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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppStream.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.AppStream.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VpcConfig Marshaller
    /// </summary>
    public class VpcConfigMarshaller : IRequestMarshaller<VpcConfig, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VpcConfig requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WriteTextString("SecurityGroupIds");
                context.Writer.WriteStartArray(requestObject.SecurityGroupIds.Count);
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteTextString(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetSubnetIds())
            {
                context.Writer.WriteTextString("SubnetIds");
                context.Writer.WriteStartArray(requestObject.SubnetIds.Count);
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.WriteTextString(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VpcConfigMarshaller Instance = new VpcConfigMarshaller();

    }
}