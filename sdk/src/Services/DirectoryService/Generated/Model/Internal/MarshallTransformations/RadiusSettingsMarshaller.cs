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

#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RadiusSettings Marshaller
    /// </summary>
    public class RadiusSettingsMarshaller : IRequestMarshaller<RadiusSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RadiusSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationProtocol())
            {
                context.Writer.WritePropertyName("AuthenticationProtocol");
                context.Writer.Write(requestObject.AuthenticationProtocol);
            }

            if(requestObject.IsSetDisplayLabel())
            {
                context.Writer.WritePropertyName("DisplayLabel");
                context.Writer.Write(requestObject.DisplayLabel);
            }

            if(requestObject.IsSetRadiusPort())
            {
                context.Writer.WritePropertyName("RadiusPort");
                context.Writer.Write(requestObject.RadiusPort);
            }

            if(requestObject.IsSetRadiusRetries())
            {
                context.Writer.WritePropertyName("RadiusRetries");
                context.Writer.Write(requestObject.RadiusRetries);
            }

            if(requestObject.IsSetRadiusServers())
            {
                context.Writer.WritePropertyName("RadiusServers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRadiusServersListValue in requestObject.RadiusServers)
                {
                        context.Writer.Write(requestObjectRadiusServersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRadiusServersIpv6())
            {
                context.Writer.WritePropertyName("RadiusServersIpv6");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRadiusServersIpv6ListValue in requestObject.RadiusServersIpv6)
                {
                        context.Writer.Write(requestObjectRadiusServersIpv6ListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRadiusTimeout())
            {
                context.Writer.WritePropertyName("RadiusTimeout");
                context.Writer.Write(requestObject.RadiusTimeout);
            }

            if(requestObject.IsSetSharedSecret())
            {
                context.Writer.WritePropertyName("SharedSecret");
                context.Writer.Write(requestObject.SharedSecret);
            }

            if(requestObject.IsSetUseSameUsername())
            {
                context.Writer.WritePropertyName("UseSameUsername");
                context.Writer.Write(requestObject.UseSameUsername);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RadiusSettingsMarshaller Instance = new RadiusSettingsMarshaller();

    }
}