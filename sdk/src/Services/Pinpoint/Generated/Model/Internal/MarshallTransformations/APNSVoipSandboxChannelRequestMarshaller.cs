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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// APNSVoipSandboxChannelRequest Marshaller
    /// </summary>
    public class APNSVoipSandboxChannelRequestMarshaller : IRequestMarshaller<APNSVoipSandboxChannelRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(APNSVoipSandboxChannelRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBundleId())
            {
                context.Writer.WritePropertyName("BundleId");
                context.Writer.WriteStringValue(requestObject.BundleId);
            }

            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.WriteStringValue(requestObject.Certificate);
            }

            if(requestObject.IsSetDefaultAuthenticationMethod())
            {
                context.Writer.WritePropertyName("DefaultAuthenticationMethod");
                context.Writer.WriteStringValue(requestObject.DefaultAuthenticationMethod);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetPrivateKey())
            {
                context.Writer.WritePropertyName("PrivateKey");
                context.Writer.WriteStringValue(requestObject.PrivateKey);
            }

            if(requestObject.IsSetTeamId())
            {
                context.Writer.WritePropertyName("TeamId");
                context.Writer.WriteStringValue(requestObject.TeamId);
            }

            if(requestObject.IsSetTokenKey())
            {
                context.Writer.WritePropertyName("TokenKey");
                context.Writer.WriteStringValue(requestObject.TokenKey);
            }

            if(requestObject.IsSetTokenKeyId())
            {
                context.Writer.WritePropertyName("TokenKeyId");
                context.Writer.WriteStringValue(requestObject.TokenKeyId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static APNSVoipSandboxChannelRequestMarshaller Instance = new APNSVoipSandboxChannelRequestMarshaller();

    }
}