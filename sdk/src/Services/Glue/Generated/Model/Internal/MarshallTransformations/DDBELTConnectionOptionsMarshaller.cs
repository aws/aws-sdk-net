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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DDBELTConnectionOptions Marshaller
    /// </summary>
    public class DDBELTConnectionOptionsMarshaller : IRequestMarshaller<DDBELTConnectionOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DDBELTConnectionOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDynamodbExport())
            {
                context.Writer.WritePropertyName("DynamodbExport");
                context.Writer.WriteStringValue(requestObject.DynamodbExport);
            }

            if(requestObject.IsSetDynamodbS3Bucket())
            {
                context.Writer.WritePropertyName("DynamodbS3Bucket");
                context.Writer.WriteStringValue(requestObject.DynamodbS3Bucket);
            }

            if(requestObject.IsSetDynamodbS3BucketOwner())
            {
                context.Writer.WritePropertyName("DynamodbS3BucketOwner");
                context.Writer.WriteStringValue(requestObject.DynamodbS3BucketOwner);
            }

            if(requestObject.IsSetDynamodbS3Prefix())
            {
                context.Writer.WritePropertyName("DynamodbS3Prefix");
                context.Writer.WriteStringValue(requestObject.DynamodbS3Prefix);
            }

            if(requestObject.IsSetDynamodbStsRoleArn())
            {
                context.Writer.WritePropertyName("DynamodbStsRoleArn");
                context.Writer.WriteStringValue(requestObject.DynamodbStsRoleArn);
            }

            if(requestObject.IsSetDynamodbTableArn())
            {
                context.Writer.WritePropertyName("DynamodbTableArn");
                context.Writer.WriteStringValue(requestObject.DynamodbTableArn);
            }

            if(requestObject.IsSetDynamodbUnnestDDBJson())
            {
                context.Writer.WritePropertyName("DynamodbUnnestDDBJson");
                context.Writer.WriteBooleanValue(requestObject.DynamodbUnnestDDBJson.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DDBELTConnectionOptionsMarshaller Instance = new DDBELTConnectionOptionsMarshaller();

    }
}