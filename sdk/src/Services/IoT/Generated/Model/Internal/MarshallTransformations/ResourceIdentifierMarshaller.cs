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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceIdentifier Marshaller
    /// </summary>       
    public class ResourceIdentifierMarshaller : IRequestMarshaller<ResourceIdentifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceIdentifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccount())
            {
                context.Writer.WritePropertyName("account");
                context.Writer.Write(requestObject.Account);
            }

            if(requestObject.IsSetCaCertificateId())
            {
                context.Writer.WritePropertyName("caCertificateId");
                context.Writer.Write(requestObject.CaCertificateId);
            }

            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.Write(requestObject.ClientId);
            }

            if(requestObject.IsSetCognitoIdentityPoolId())
            {
                context.Writer.WritePropertyName("cognitoIdentityPoolId");
                context.Writer.Write(requestObject.CognitoIdentityPoolId);
            }

            if(requestObject.IsSetDeviceCertificateId())
            {
                context.Writer.WritePropertyName("deviceCertificateId");
                context.Writer.Write(requestObject.DeviceCertificateId);
            }

            if(requestObject.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("iamRoleArn");
                context.Writer.Write(requestObject.IamRoleArn);
            }

            if(requestObject.IsSetPolicyVersionIdentifier())
            {
                context.Writer.WritePropertyName("policyVersionIdentifier");
                context.Writer.WriteObjectStart();

                var marshaller = PolicyVersionIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.PolicyVersionIdentifier, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleAliasArn())
            {
                context.Writer.WritePropertyName("roleAliasArn");
                context.Writer.Write(requestObject.RoleAliasArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ResourceIdentifierMarshaller Instance = new ResourceIdentifierMarshaller();

    }
}