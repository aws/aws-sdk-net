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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Configuration Marshaller
    /// </summary>
    public class ConfigurationMarshaller : IRequestMarshaller<Configuration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Configuration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDynamodbStream())
            {
                context.Writer.WritePropertyName("dynamodbStream");
                context.Writer.WriteStartObject();

                var marshaller = DynamodbStreamConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamodbStream, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDynamodbTable())
            {
                context.Writer.WritePropertyName("dynamodbTable");
                context.Writer.WriteStartObject();

                var marshaller = DynamodbTableConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DynamodbTable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEbsSnapshot())
            {
                context.Writer.WritePropertyName("ebsSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = EbsSnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EbsSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEcrRepository())
            {
                context.Writer.WritePropertyName("ecrRepository");
                context.Writer.WriteStartObject();

                var marshaller = EcrRepositoryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EcrRepository, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEfsFileSystem())
            {
                context.Writer.WritePropertyName("efsFileSystem");
                context.Writer.WriteStartObject();

                var marshaller = EfsFileSystemConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.EfsFileSystem, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIamRole())
            {
                context.Writer.WritePropertyName("iamRole");
                context.Writer.WriteStartObject();

                var marshaller = IamRoleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.IamRole, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKmsKey())
            {
                context.Writer.WritePropertyName("kmsKey");
                context.Writer.WriteStartObject();

                var marshaller = KmsKeyConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.KmsKey, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRdsDbClusterSnapshot())
            {
                context.Writer.WritePropertyName("rdsDbClusterSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = RdsDbClusterSnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RdsDbClusterSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRdsDbSnapshot())
            {
                context.Writer.WritePropertyName("rdsDbSnapshot");
                context.Writer.WriteStartObject();

                var marshaller = RdsDbSnapshotConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RdsDbSnapshot, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("s3Bucket");
                context.Writer.WriteStartObject();

                var marshaller = S3BucketConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Bucket, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3ExpressDirectoryBucket())
            {
                context.Writer.WritePropertyName("s3ExpressDirectoryBucket");
                context.Writer.WriteStartObject();

                var marshaller = S3ExpressDirectoryBucketConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3ExpressDirectoryBucket, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretsManagerSecret())
            {
                context.Writer.WritePropertyName("secretsManagerSecret");
                context.Writer.WriteStartObject();

                var marshaller = SecretsManagerSecretConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SecretsManagerSecret, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnsTopic())
            {
                context.Writer.WritePropertyName("snsTopic");
                context.Writer.WriteStartObject();

                var marshaller = SnsTopicConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsTopic, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqsQueue())
            {
                context.Writer.WritePropertyName("sqsQueue");
                context.Writer.WriteStartObject();

                var marshaller = SqsQueueConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsQueue, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfigurationMarshaller Instance = new ConfigurationMarshaller();

    }
}