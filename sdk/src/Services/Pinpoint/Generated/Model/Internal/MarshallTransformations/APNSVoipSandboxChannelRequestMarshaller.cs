/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetBundleId())
            {
                context.Writer.WritePropertyName("BundleId");
                context.Writer.Write(requestObject.BundleId);
            }

            if(requestObject.IsSetCertificate())
            {
                context.Writer.WritePropertyName("Certificate");
                context.Writer.Write(requestObject.Certificate);
            }

            if(requestObject.IsSetDefaultAuthenticationMethod())
            {
                context.Writer.WritePropertyName("DefaultAuthenticationMethod");
                context.Writer.Write(requestObject.DefaultAuthenticationMethod);
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetPrivateKey())
            {
                context.Writer.WritePropertyName("PrivateKey");
                context.Writer.Write(requestObject.PrivateKey);
            }

            if(requestObject.IsSetTeamId())
            {
                context.Writer.WritePropertyName("TeamId");
                context.Writer.Write(requestObject.TeamId);
            }

            if(requestObject.IsSetTokenKey())
            {
                context.Writer.WritePropertyName("TokenKey");
                context.Writer.Write(requestObject.TokenKey);
            }

            if(requestObject.IsSetTokenKeyId())
            {
                context.Writer.WritePropertyName("TokenKeyId");
                context.Writer.Write(requestObject.TokenKeyId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static APNSVoipSandboxChannelRequestMarshaller Instance = new APNSVoipSandboxChannelRequestMarshaller();

    }
}