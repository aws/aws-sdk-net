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
    /// AwsDynamoDbTableRestoreSummary Marshaller
    /// </summary>
    public class AwsDynamoDbTableRestoreSummaryMarshaller : IRequestMarshaller<AwsDynamoDbTableRestoreSummary, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDynamoDbTableRestoreSummary requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRestoreDateTime())
            {
                context.Writer.WritePropertyName("RestoreDateTime");
                context.Writer.WriteStringValue(requestObject.RestoreDateTime);
            }

            if(requestObject.IsSetRestoreInProgress())
            {
                context.Writer.WritePropertyName("RestoreInProgress");
                context.Writer.WriteBooleanValue(requestObject.RestoreInProgress.Value);
            }

            if(requestObject.IsSetSourceBackupArn())
            {
                context.Writer.WritePropertyName("SourceBackupArn");
                context.Writer.WriteStringValue(requestObject.SourceBackupArn);
            }

            if(requestObject.IsSetSourceTableArn())
            {
                context.Writer.WritePropertyName("SourceTableArn");
                context.Writer.WriteStringValue(requestObject.SourceTableArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDynamoDbTableRestoreSummaryMarshaller Instance = new AwsDynamoDbTableRestoreSummaryMarshaller();

    }
}