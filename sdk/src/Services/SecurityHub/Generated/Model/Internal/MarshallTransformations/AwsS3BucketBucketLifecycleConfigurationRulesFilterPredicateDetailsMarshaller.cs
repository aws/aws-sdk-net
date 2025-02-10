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
    /// AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetails Marshaller
    /// </summary>
    public class AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetailsMarshaller : IRequestMarshaller<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOperands())
            {
                context.Writer.WritePropertyName("Operands");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOperandsListValue in requestObject.Operands)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectOperandsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrefix())
            {
                context.Writer.WritePropertyName("Prefix");
                context.Writer.WriteStringValue(requestObject.Prefix);
            }

            if(requestObject.IsSetTag())
            {
                context.Writer.WritePropertyName("Tag");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateTagDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Tag, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetailsMarshaller Instance = new AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetailsMarshaller();

    }
}