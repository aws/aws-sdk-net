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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DefaultRunSetting Marshaller
    /// </summary>
    public class DefaultRunSettingMarshaller : IRequestMarshaller<DefaultRunSetting, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DefaultRunSetting requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCacheBehavior())
            {
                context.Writer.WritePropertyName("cacheBehavior");
                context.Writer.WriteStringValue(requestObject.CacheBehavior);
            }

            if(requestObject.IsSetCacheId())
            {
                context.Writer.WritePropertyName("cacheId");
                context.Writer.WriteStringValue(requestObject.CacheId);
            }

            if(requestObject.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("logLevel");
                context.Writer.WriteStringValue(requestObject.LogLevel);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOutputBucketOwnerId())
            {
                context.Writer.WritePropertyName("outputBucketOwnerId");
                context.Writer.WriteStringValue(requestObject.OutputBucketOwnerId);
            }

            if(requestObject.IsSetOutputUri())
            {
                context.Writer.WritePropertyName("outputUri");
                context.Writer.WriteStringValue(requestObject.OutputUri);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.Parameters);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetRetentionMode())
            {
                context.Writer.WritePropertyName("retentionMode");
                context.Writer.WriteStringValue(requestObject.RetentionMode);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetRunGroupId())
            {
                context.Writer.WritePropertyName("runGroupId");
                context.Writer.WriteStringValue(requestObject.RunGroupId);
            }

            if(requestObject.IsSetRunTags())
            {
                context.Writer.WritePropertyName("runTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectRunTagsKvp in requestObject.RunTags)
                {
                    context.Writer.WritePropertyName(requestObjectRunTagsKvp.Key);
                    var requestObjectRunTagsValue = requestObjectRunTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectRunTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStorageCapacity())
            {
                context.Writer.WritePropertyName("storageCapacity");
                context.Writer.WriteNumberValue(requestObject.StorageCapacity.Value);
            }

            if(requestObject.IsSetStorageType())
            {
                context.Writer.WritePropertyName("storageType");
                context.Writer.WriteStringValue(requestObject.StorageType);
            }

            if(requestObject.IsSetWorkflowId())
            {
                context.Writer.WritePropertyName("workflowId");
                context.Writer.WriteStringValue(requestObject.WorkflowId);
            }

            if(requestObject.IsSetWorkflowOwnerId())
            {
                context.Writer.WritePropertyName("workflowOwnerId");
                context.Writer.WriteStringValue(requestObject.WorkflowOwnerId);
            }

            if(requestObject.IsSetWorkflowType())
            {
                context.Writer.WritePropertyName("workflowType");
                context.Writer.WriteStringValue(requestObject.WorkflowType);
            }

            if(requestObject.IsSetWorkflowVersionName())
            {
                context.Writer.WritePropertyName("workflowVersionName");
                context.Writer.WriteStringValue(requestObject.WorkflowVersionName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DefaultRunSettingMarshaller Instance = new DefaultRunSettingMarshaller();

    }
}