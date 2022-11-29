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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSettings Marshaller
    /// </summary>
    public class UpdateSettingsMarshaller : IRequestMarshaller<UpdateSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAddSubnets())
            {
                context.Writer.WritePropertyName("AddSubnets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAddSubnetsListValue in requestObject.AddSubnets)
                {
                        context.Writer.Write(requestObjectAddSubnetsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRemoveSubnets())
            {
                context.Writer.WritePropertyName("RemoveSubnets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRemoveSubnetsListValue in requestObject.RemoveSubnets)
                {
                        context.Writer.Write(requestObjectRemoveSubnetsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecurityGroupId())
            {
                context.Writer.WritePropertyName("SecurityGroupId");
                context.Writer.Write(requestObject.SecurityGroupId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateSettingsMarshaller Instance = new UpdateSettingsMarshaller();

    }
}