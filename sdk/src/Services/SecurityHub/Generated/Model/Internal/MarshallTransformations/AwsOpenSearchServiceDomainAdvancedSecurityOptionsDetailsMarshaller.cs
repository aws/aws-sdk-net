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

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails Marshaller
    /// </summary>
    public class AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetailsMarshaller : IRequestMarshaller<AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetInternalUserDatabaseEnabled())
            {
                context.Writer.WritePropertyName("InternalUserDatabaseEnabled");
                context.Writer.Write(requestObject.InternalUserDatabaseEnabled);
            }

            if(requestObject.IsSetMasterUserOptions())
            {
                context.Writer.WritePropertyName("MasterUserOptions");
                context.Writer.WriteObjectStart();

                var marshaller = AwsOpenSearchServiceDomainMasterUserOptionsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MasterUserOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetailsMarshaller Instance = new AwsOpenSearchServiceDomainAdvancedSecurityOptionsDetailsMarshaller();

    }
}
#pragma warning restore CS0612,CS0618