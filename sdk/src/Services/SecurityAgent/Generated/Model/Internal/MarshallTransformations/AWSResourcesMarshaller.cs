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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AWSResources Marshaller
    /// </summary>
    public class AWSResourcesMarshaller : IRequestMarshaller<AWSResources, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AWSResources requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIamRoles())
            {
                context.Writer.WritePropertyName("iamRoles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIamRolesListValue in requestObject.IamRoles)
                {
                        context.Writer.WriteStringValue(requestObjectIamRolesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLambdaFunctionArns())
            {
                context.Writer.WritePropertyName("lambdaFunctionArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLambdaFunctionArnsListValue in requestObject.LambdaFunctionArns)
                {
                        context.Writer.WriteStringValue(requestObjectLambdaFunctionArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLogGroups())
            {
                context.Writer.WritePropertyName("logGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLogGroupsListValue in requestObject.LogGroups)
                {
                        context.Writer.WriteStringValue(requestObjectLogGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3Buckets())
            {
                context.Writer.WritePropertyName("s3Buckets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectS3BucketsListValue in requestObject.S3Buckets)
                {
                        context.Writer.WriteStringValue(requestObjectS3BucketsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecretArns())
            {
                context.Writer.WritePropertyName("secretArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecretArnsListValue in requestObject.SecretArns)
                {
                        context.Writer.WriteStringValue(requestObjectSecretArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVpcs())
            {
                context.Writer.WritePropertyName("vpcs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVpcsListValue in requestObject.Vpcs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AWSResourcesMarshaller Instance = new AWSResourcesMarshaller();

    }
}