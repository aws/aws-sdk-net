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
    /// AwsSqsQueueDetails Marshaller
    /// </summary>
    public class AwsSqsQueueDetailsMarshaller : IRequestMarshaller<AwsSqsQueueDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsSqsQueueDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeadLetterTargetArn())
            {
                context.Writer.WritePropertyName("DeadLetterTargetArn");
                context.Writer.WriteStringValue(requestObject.DeadLetterTargetArn);
            }

            if(requestObject.IsSetKmsDataKeyReusePeriodSeconds())
            {
                context.Writer.WritePropertyName("KmsDataKeyReusePeriodSeconds");
                context.Writer.WriteNumberValue(requestObject.KmsDataKeyReusePeriodSeconds.Value);
            }

            if(requestObject.IsSetKmsMasterKeyId())
            {
                context.Writer.WritePropertyName("KmsMasterKeyId");
                context.Writer.WriteStringValue(requestObject.KmsMasterKeyId);
            }

            if(requestObject.IsSetQueueName())
            {
                context.Writer.WritePropertyName("QueueName");
                context.Writer.WriteStringValue(requestObject.QueueName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsSqsQueueDetailsMarshaller Instance = new AwsSqsQueueDetailsMarshaller();

    }
}