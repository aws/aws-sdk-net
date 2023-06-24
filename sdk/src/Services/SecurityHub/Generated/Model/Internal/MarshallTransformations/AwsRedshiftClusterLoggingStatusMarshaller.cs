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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRedshiftClusterLoggingStatus Marshaller
    /// </summary>
    public class AwsRedshiftClusterLoggingStatusMarshaller : IRequestMarshaller<AwsRedshiftClusterLoggingStatus, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRedshiftClusterLoggingStatus requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.Write(requestObject.BucketName);
            }

            if(requestObject.IsSetLastFailureMessage())
            {
                context.Writer.WritePropertyName("LastFailureMessage");
                context.Writer.Write(requestObject.LastFailureMessage);
            }

            if(requestObject.IsSetLastFailureTime())
            {
                context.Writer.WritePropertyName("LastFailureTime");
                context.Writer.Write(requestObject.LastFailureTime);
            }

            if(requestObject.IsSetLastSuccessfulDeliveryTime())
            {
                context.Writer.WritePropertyName("LastSuccessfulDeliveryTime");
                context.Writer.Write(requestObject.LastSuccessfulDeliveryTime);
            }

            if(requestObject.IsSetLoggingEnabled())
            {
                context.Writer.WritePropertyName("LoggingEnabled");
                context.Writer.Write(requestObject.LoggingEnabled);
            }

            if(requestObject.IsSetS3KeyPrefix())
            {
                context.Writer.WritePropertyName("S3KeyPrefix");
                context.Writer.Write(requestObject.S3KeyPrefix);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsRedshiftClusterLoggingStatusMarshaller Instance = new AwsRedshiftClusterLoggingStatusMarshaller();

    }
}