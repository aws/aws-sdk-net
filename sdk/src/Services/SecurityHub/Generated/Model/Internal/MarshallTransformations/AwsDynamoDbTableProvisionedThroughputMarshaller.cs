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
    /// AwsDynamoDbTableProvisionedThroughput Marshaller
    /// </summary>
    public class AwsDynamoDbTableProvisionedThroughputMarshaller : IRequestMarshaller<AwsDynamoDbTableProvisionedThroughput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDynamoDbTableProvisionedThroughput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLastDecreaseDateTime())
            {
                context.Writer.WritePropertyName("LastDecreaseDateTime");
                context.Writer.WriteStringValue(requestObject.LastDecreaseDateTime);
            }

            if(requestObject.IsSetLastIncreaseDateTime())
            {
                context.Writer.WritePropertyName("LastIncreaseDateTime");
                context.Writer.WriteStringValue(requestObject.LastIncreaseDateTime);
            }

            if(requestObject.IsSetNumberOfDecreasesToday())
            {
                context.Writer.WritePropertyName("NumberOfDecreasesToday");
                context.Writer.WriteNumberValue(requestObject.NumberOfDecreasesToday.Value);
            }

            if(requestObject.IsSetReadCapacityUnits())
            {
                context.Writer.WritePropertyName("ReadCapacityUnits");
                context.Writer.WriteNumberValue(requestObject.ReadCapacityUnits.Value);
            }

            if(requestObject.IsSetWriteCapacityUnits())
            {
                context.Writer.WritePropertyName("WriteCapacityUnits");
                context.Writer.WriteNumberValue(requestObject.WriteCapacityUnits.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDynamoDbTableProvisionedThroughputMarshaller Instance = new AwsDynamoDbTableProvisionedThroughputMarshaller();

    }
}