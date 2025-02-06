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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccount())
            {
                context.Writer.WritePropertyName("account");
                context.Writer.WriteStringValue(requestObject.Account);
            }

            if(requestObject.IsSetCaCertificateId())
            {
                context.Writer.WritePropertyName("caCertificateId");
                context.Writer.WriteStringValue(requestObject.CaCertificateId);
            }

            if(requestObject.IsSetClientId())
            {
                context.Writer.WritePropertyName("clientId");
                context.Writer.WriteStringValue(requestObject.ClientId);
            }

            if(requestObject.IsSetCognitoIdentityPoolId())
            {
                context.Writer.WritePropertyName("cognitoIdentityPoolId");
                context.Writer.WriteStringValue(requestObject.CognitoIdentityPoolId);
            }

            if(requestObject.IsSetDeviceCertificateArn())
            {
                context.Writer.WritePropertyName("deviceCertificateArn");
                context.Writer.WriteStringValue(requestObject.DeviceCertificateArn);
            }

            if(requestObject.IsSetDeviceCertificateId())
            {
                context.Writer.WritePropertyName("deviceCertificateId");
                context.Writer.WriteStringValue(requestObject.DeviceCertificateId);
            }

            if(requestObject.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("iamRoleArn");
                context.Writer.WriteStringValue(requestObject.IamRoleArn);
            }

            if(requestObject.IsSetIssuerCertificateIdentifier())
            {
                context.Writer.WritePropertyName("issuerCertificateIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = IssuerCertificateIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.IssuerCertificateIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPolicyVersionIdentifier())
            {
                context.Writer.WritePropertyName("policyVersionIdentifier");
                context.Writer.WriteStartObject();

                var marshaller = PolicyVersionIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.PolicyVersionIdentifier, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleAliasArn())
            {
                context.Writer.WritePropertyName("roleAliasArn");
                context.Writer.WriteStringValue(requestObject.RoleAliasArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceIdentifierMarshaller Instance = new ResourceIdentifierMarshaller();

    }
}