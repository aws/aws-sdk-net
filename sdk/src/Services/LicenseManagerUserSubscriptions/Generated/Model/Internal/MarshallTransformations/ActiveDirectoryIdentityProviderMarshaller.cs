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
#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActiveDirectoryIdentityProvider Marshaller
    /// </summary>
    public class ActiveDirectoryIdentityProviderMarshaller : IRequestMarshaller<ActiveDirectoryIdentityProvider, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActiveDirectoryIdentityProvider requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActiveDirectorySettings())
            {
                context.Writer.WritePropertyName("ActiveDirectorySettings");
                context.Writer.WriteStartObject();

                var marshaller = ActiveDirectorySettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ActiveDirectorySettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetActiveDirectoryType())
            {
                context.Writer.WritePropertyName("ActiveDirectoryType");
                context.Writer.WriteStringValue(requestObject.ActiveDirectoryType);
            }

            if(requestObject.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("DirectoryId");
                context.Writer.WriteStringValue(requestObject.DirectoryId);
            }

            if(requestObject.IsSetIsSharedActiveDirectory())
            {
                context.Writer.WritePropertyName("IsSharedActiveDirectory");
                context.Writer.WriteBooleanValue(requestObject.IsSharedActiveDirectory.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActiveDirectoryIdentityProviderMarshaller Instance = new ActiveDirectoryIdentityProviderMarshaller();

    }
}