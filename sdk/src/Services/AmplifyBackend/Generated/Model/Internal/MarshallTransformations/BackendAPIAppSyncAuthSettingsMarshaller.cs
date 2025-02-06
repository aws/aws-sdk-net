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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyBackend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyBackend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BackendAPIAppSyncAuthSettings Marshaller
    /// </summary>
    public class BackendAPIAppSyncAuthSettingsMarshaller : IRequestMarshaller<BackendAPIAppSyncAuthSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BackendAPIAppSyncAuthSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCognitoUserPoolId())
            {
                context.Writer.WritePropertyName("cognitoUserPoolId");
                context.Writer.WriteStringValue(requestObject.CognitoUserPoolId);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetExpirationTime())
            {
                context.Writer.WritePropertyName("expirationTime");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ExpirationTime.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ExpirationTime.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ExpirationTime.Value);
                }
            }

            if(requestObject.IsSetOpenIDAuthTTL())
            {
                context.Writer.WritePropertyName("openIDAuthTTL");
                context.Writer.WriteStringValue(requestObject.OpenIDAuthTTL);
            }

            if(requestObject.IsSetOpenIDClientId())
            {
                context.Writer.WritePropertyName("openIDClientId");
                context.Writer.WriteStringValue(requestObject.OpenIDClientId);
            }

            if(requestObject.IsSetOpenIDIatTTL())
            {
                context.Writer.WritePropertyName("openIDIatTTL");
                context.Writer.WriteStringValue(requestObject.OpenIDIatTTL);
            }

            if(requestObject.IsSetOpenIDIssueURL())
            {
                context.Writer.WritePropertyName("openIDIssueURL");
                context.Writer.WriteStringValue(requestObject.OpenIDIssueURL);
            }

            if(requestObject.IsSetOpenIDProviderName())
            {
                context.Writer.WritePropertyName("openIDProviderName");
                context.Writer.WriteStringValue(requestObject.OpenIDProviderName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BackendAPIAppSyncAuthSettingsMarshaller Instance = new BackendAPIAppSyncAuthSettingsMarshaller();

    }
}