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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChangeMessageVisibilityBatchRequestEntry Marshaller
    /// </summary>
    public class ChangeMessageVisibilityBatchRequestEntryMarshaller : IRequestMarshaller<ChangeMessageVisibilityBatchRequestEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ChangeMessageVisibilityBatchRequestEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetReceiptHandle())
            {
                context.Writer.WritePropertyName("ReceiptHandle");
                context.Writer.WriteStringValue(requestObject.ReceiptHandle);
            }

            if(requestObject.IsSetVisibilityTimeout())
            {
                context.Writer.WritePropertyName("VisibilityTimeout");
                context.Writer.WriteNumberValue(requestObject.VisibilityTimeout.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ChangeMessageVisibilityBatchRequestEntryMarshaller Instance = new ChangeMessageVisibilityBatchRequestEntryMarshaller();

    }
}