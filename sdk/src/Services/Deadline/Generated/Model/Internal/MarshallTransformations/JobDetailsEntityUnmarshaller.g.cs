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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Deadline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobDetailsEntity Object
    /// </summary>
    public partial class JobDetailsEntityUnmarshaller : IJsonUnmarshaller<JobDetailsEntity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public JobDetailsEntity Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new JobDetailsEntity();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("extensions", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Extensions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("jobAttachmentSettings", targetDepth, ref reader))
                {
                    var unmarshaller = JobDetailsJobAttachmentSettingsUnmarshaller.Instance;
                    unmarshalledObject.JobAttachmentSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("jobId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("jobRunAsUser", targetDepth, ref reader))
                {
                    var unmarshaller = JobRunAsUserUnmarshaller.Instance;
                    unmarshalledObject.JobRunAsUser = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("logGroupName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("parameters", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, JobParameter, StringUnmarshaller, JobParameterUnmarshaller>(StringUnmarshaller.Instance, JobParameterUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("pathMappingRules", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PathMappingRule, PathMappingRuleUnmarshaller>(PathMappingRuleUnmarshaller.Instance);
                    unmarshalledObject.PathMappingRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("queueRoleArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QueueRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("schemaVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static JobDetailsEntityUnmarshaller _instance = new JobDetailsEntityUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static JobDetailsEntityUnmarshaller Instance => _instance;
    }
}
