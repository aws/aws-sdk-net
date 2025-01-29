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
    /// AwsSecretsManagerSecretDetails Marshaller
    /// </summary>
    public class AwsSecretsManagerSecretDetailsMarshaller : IRequestMarshaller<AwsSecretsManagerSecretDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSecretsManagerSecretDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeleted())
            {
                context.Writer.WritePropertyName("Deleted");
                context.Writer.WriteBooleanValue(requestObject.Deleted.Value);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRotationEnabled())
            {
                context.Writer.WritePropertyName("RotationEnabled");
                context.Writer.WriteBooleanValue(requestObject.RotationEnabled.Value);
            }

            if(requestObject.IsSetRotationLambdaArn())
            {
                context.Writer.WritePropertyName("RotationLambdaArn");
                context.Writer.WriteStringValue(requestObject.RotationLambdaArn);
            }

            if(requestObject.IsSetRotationOccurredWithinFrequency())
            {
                context.Writer.WritePropertyName("RotationOccurredWithinFrequency");
                context.Writer.WriteBooleanValue(requestObject.RotationOccurredWithinFrequency.Value);
            }

            if(requestObject.IsSetRotationRules())
            {
                context.Writer.WritePropertyName("RotationRules");
                context.Writer.WriteStartObject();

                var marshaller = AwsSecretsManagerSecretRotationRulesMarshaller.Instance;
                marshaller.Marshall(requestObject.RotationRules, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSecretsManagerSecretDetailsMarshaller Instance = new AwsSecretsManagerSecretDetailsMarshaller();

    }
}