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
    /// AwsCloudTrailTrailDetails Marshaller
    /// </summary>
    public class AwsCloudTrailTrailDetailsMarshaller : IRequestMarshaller<AwsCloudTrailTrailDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudTrailTrailDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLogsLogGroupArn())
            {
                context.Writer.WritePropertyName("CloudWatchLogsLogGroupArn");
                context.Writer.WriteStringValue(requestObject.CloudWatchLogsLogGroupArn);
            }

            if(requestObject.IsSetCloudWatchLogsRoleArn())
            {
                context.Writer.WritePropertyName("CloudWatchLogsRoleArn");
                context.Writer.WriteStringValue(requestObject.CloudWatchLogsRoleArn);
            }

            if(requestObject.IsSetHasCustomEventSelectors())
            {
                context.Writer.WritePropertyName("HasCustomEventSelectors");
                context.Writer.WriteBooleanValue(requestObject.HasCustomEventSelectors.Value);
            }

            if(requestObject.IsSetHomeRegion())
            {
                context.Writer.WritePropertyName("HomeRegion");
                context.Writer.WriteStringValue(requestObject.HomeRegion);
            }

            if(requestObject.IsSetIncludeGlobalServiceEvents())
            {
                context.Writer.WritePropertyName("IncludeGlobalServiceEvents");
                context.Writer.WriteBooleanValue(requestObject.IncludeGlobalServiceEvents.Value);
            }

            if(requestObject.IsSetIsMultiRegionTrail())
            {
                context.Writer.WritePropertyName("IsMultiRegionTrail");
                context.Writer.WriteBooleanValue(requestObject.IsMultiRegionTrail.Value);
            }

            if(requestObject.IsSetIsOrganizationTrail())
            {
                context.Writer.WritePropertyName("IsOrganizationTrail");
                context.Writer.WriteBooleanValue(requestObject.IsOrganizationTrail.Value);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLogFileValidationEnabled())
            {
                context.Writer.WritePropertyName("LogFileValidationEnabled");
                context.Writer.WriteBooleanValue(requestObject.LogFileValidationEnabled.Value);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetS3BucketName())
            {
                context.Writer.WritePropertyName("S3BucketName");
                context.Writer.WriteStringValue(requestObject.S3BucketName);
            }

            if(requestObject.IsSetS3KeyPrefix())
            {
                context.Writer.WritePropertyName("S3KeyPrefix");
                context.Writer.WriteStringValue(requestObject.S3KeyPrefix);
            }

            if(requestObject.IsSetSnsTopicArn())
            {
                context.Writer.WritePropertyName("SnsTopicArn");
                context.Writer.WriteStringValue(requestObject.SnsTopicArn);
            }

            if(requestObject.IsSetSnsTopicName())
            {
                context.Writer.WritePropertyName("SnsTopicName");
                context.Writer.WriteStringValue(requestObject.SnsTopicName);
            }

            if(requestObject.IsSetTrailArn())
            {
                context.Writer.WritePropertyName("TrailArn");
                context.Writer.WriteStringValue(requestObject.TrailArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudTrailTrailDetailsMarshaller Instance = new AwsCloudTrailTrailDetailsMarshaller();

    }
}