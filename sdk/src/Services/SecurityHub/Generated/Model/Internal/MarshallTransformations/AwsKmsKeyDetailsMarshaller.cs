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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsKmsKeyDetails Marshaller
    /// </summary>
    public class AwsKmsKeyDetailsMarshaller : IRequestMarshaller<AwsKmsKeyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsKmsKeyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAWSAccountId())
            {
                context.Writer.WritePropertyName("AWSAccountId");
                context.Writer.WriteStringValue(requestObject.AWSAccountId);
            }

            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.CreationDate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.CreationDate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.CreationDate.Value);
                }
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetKeyId())
            {
                context.Writer.WritePropertyName("KeyId");
                context.Writer.WriteStringValue(requestObject.KeyId);
            }

            if(requestObject.IsSetKeyManager())
            {
                context.Writer.WritePropertyName("KeyManager");
                context.Writer.WriteStringValue(requestObject.KeyManager);
            }

            if(requestObject.IsSetKeyRotationStatus())
            {
                context.Writer.WritePropertyName("KeyRotationStatus");
                context.Writer.WriteBooleanValue(requestObject.KeyRotationStatus.Value);
            }

            if(requestObject.IsSetKeyState())
            {
                context.Writer.WritePropertyName("KeyState");
                context.Writer.WriteStringValue(requestObject.KeyState);
            }

            if(requestObject.IsSetOrigin())
            {
                context.Writer.WritePropertyName("Origin");
                context.Writer.WriteStringValue(requestObject.Origin);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsKmsKeyDetailsMarshaller Instance = new AwsKmsKeyDetailsMarshaller();

    }
}