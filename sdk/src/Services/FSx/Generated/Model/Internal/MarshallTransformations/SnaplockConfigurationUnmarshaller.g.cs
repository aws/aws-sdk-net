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

using Amazon.FSx.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SnaplockConfiguration Object
    /// </summary>
    public partial class SnaplockConfigurationUnmarshaller : IJsonUnmarshaller<SnaplockConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public SnaplockConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new SnaplockConfiguration();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AuditLogVolume", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.AuditLogVolume = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("AutocommitPeriod", targetDepth, ref reader))
                {
                    var unmarshaller = AutocommitPeriodUnmarshaller.Instance;
                    unmarshalledObject.AutocommitPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("PrivilegedDelete", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivilegedDelete = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RetentionPeriod", targetDepth, ref reader))
                {
                    var unmarshaller = SnaplockRetentionPeriodUnmarshaller.Instance;
                    unmarshalledObject.RetentionPeriod = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnaplockType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnaplockType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VolumeAppendModeEnabled", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.VolumeAppendModeEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static SnaplockConfigurationUnmarshaller _instance = new SnaplockConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SnaplockConfigurationUnmarshaller Instance => _instance;
    }
}
