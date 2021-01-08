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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DirectoryConnectSettings Marshaller
    /// </summary>       
    public class DirectoryConnectSettingsMarshaller : IRequestMarshaller<DirectoryConnectSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DirectoryConnectSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomerDnsIps())
            {
                context.Writer.WritePropertyName("CustomerDnsIps");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomerDnsIpsListValue in requestObject.CustomerDnsIps)
                {
                        context.Writer.Write(requestObjectCustomerDnsIpsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCustomerUserName())
            {
                context.Writer.WritePropertyName("CustomerUserName");
                context.Writer.Write(requestObject.CustomerUserName);
            }

            if(requestObject.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("SubnetIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubnetIdsListValue in requestObject.SubnetIds)
                {
                        context.Writer.Write(requestObjectSubnetIdsListValue);
                }
                context.Writer.WriteArrayEnd();
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
        public readonly static DirectoryConnectSettingsMarshaller Instance = new DirectoryConnectSettingsMarshaller();

    }
}