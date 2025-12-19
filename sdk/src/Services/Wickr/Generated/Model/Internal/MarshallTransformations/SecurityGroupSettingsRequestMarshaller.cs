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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SecurityGroupSettingsRequest Marshaller
    /// </summary>
    public class SecurityGroupSettingsRequestMarshaller : IRequestMarshaller<SecurityGroupSettingsRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SecurityGroupSettingsRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnableGuestFederation())
            {
                context.Writer.WritePropertyName("enableGuestFederation");
                context.Writer.Write(requestObject.EnableGuestFederation);
            }

            if(requestObject.IsSetEnableRestrictedGlobalFederation())
            {
                context.Writer.WritePropertyName("enableRestrictedGlobalFederation");
                context.Writer.Write(requestObject.EnableRestrictedGlobalFederation);
            }

            if(requestObject.IsSetFederationMode())
            {
                context.Writer.WritePropertyName("federationMode");
                context.Writer.Write(requestObject.FederationMode);
            }

            if(requestObject.IsSetGlobalFederation())
            {
                context.Writer.WritePropertyName("globalFederation");
                context.Writer.Write(requestObject.GlobalFederation);
            }

            if(requestObject.IsSetLockoutThreshold())
            {
                context.Writer.WritePropertyName("lockoutThreshold");
                context.Writer.Write(requestObject.LockoutThreshold);
            }

            if(requestObject.IsSetPermittedNetworks())
            {
                context.Writer.WritePropertyName("permittedNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedNetworksListValue in requestObject.PermittedNetworks)
                {
                        context.Writer.Write(requestObjectPermittedNetworksListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPermittedWickrAwsNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrAwsNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedWickrAwsNetworksListValue in requestObject.PermittedWickrAwsNetworks)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WickrAwsNetworksMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrAwsNetworksListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPermittedWickrEnterpriseNetworks())
            {
                context.Writer.WritePropertyName("permittedWickrEnterpriseNetworks");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPermittedWickrEnterpriseNetworksListValue in requestObject.PermittedWickrEnterpriseNetworks)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PermittedWickrEnterpriseNetworkMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedWickrEnterpriseNetworksListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SecurityGroupSettingsRequestMarshaller Instance = new SecurityGroupSettingsRequestMarshaller();

    }
}