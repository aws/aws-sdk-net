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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3DataSourceConfiguration Marshaller
    /// </summary>
    public class S3DataSourceConfigurationMarshaller : IRequestMarshaller<S3DataSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3DataSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucketArn())
            {
                context.Writer.WritePropertyName("bucketArn");
                context.Writer.WriteStringValue(requestObject.BucketArn);
            }

            if(requestObject.IsSetBucketOwnerAccountId())
            {
                context.Writer.WritePropertyName("bucketOwnerAccountId");
                context.Writer.WriteStringValue(requestObject.BucketOwnerAccountId);
            }

            if(requestObject.IsSetInclusionPrefixes())
            {
                context.Writer.WritePropertyName("inclusionPrefixes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionPrefixesListValue in requestObject.InclusionPrefixes)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionPrefixesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3DataSourceConfigurationMarshaller Instance = new S3DataSourceConfigurationMarshaller();

    }
}