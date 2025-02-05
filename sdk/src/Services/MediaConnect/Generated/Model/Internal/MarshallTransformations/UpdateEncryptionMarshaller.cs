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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEncryption Marshaller
    /// </summary>
    public class UpdateEncryptionMarshaller : IRequestMarshaller<UpdateEncryption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateEncryption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithm())
            {
                context.Writer.WritePropertyName("algorithm");
                context.Writer.WriteStringValue(requestObject.Algorithm);
            }

            if(requestObject.IsSetConstantInitializationVector())
            {
                context.Writer.WritePropertyName("constantInitializationVector");
                context.Writer.WriteStringValue(requestObject.ConstantInitializationVector);
            }

            if(requestObject.IsSetDeviceId())
            {
                context.Writer.WritePropertyName("deviceId");
                context.Writer.WriteStringValue(requestObject.DeviceId);
            }

            if(requestObject.IsSetKeyType())
            {
                context.Writer.WritePropertyName("keyType");
                context.Writer.WriteStringValue(requestObject.KeyType);
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetResourceId())
            {
                context.Writer.WritePropertyName("resourceId");
                context.Writer.WriteStringValue(requestObject.ResourceId);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("secretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateEncryptionMarshaller Instance = new UpdateEncryptionMarshaller();

    }
}