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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationDetail Object
    /// </summary>  
    public class ApplicationDetailUnmarshaller : IJsonUnmarshaller<ApplicationDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ApplicationDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ApplicationDetail unmarshalledObject = new ApplicationDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ApplicationARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationConfigurationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationMaintenanceConfigurationDescription", targetDepth))
                {
                    var unmarshaller = ApplicationMaintenanceConfigurationDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ApplicationMaintenanceConfigurationDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionCreateTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionCreateTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionId", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionRolledBackFrom", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionRolledBackFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionRolledBackTo", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionRolledBackTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationVersionUpdatedFrom", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.ApplicationVersionUpdatedFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CloudWatchLoggingOptionDescriptions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CloudWatchLoggingOptionDescription, CloudWatchLoggingOptionDescriptionUnmarshaller>(CloudWatchLoggingOptionDescriptionUnmarshaller.Instance);
                    unmarshalledObject.CloudWatchLoggingOptionDescriptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConditionalToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ConditionalToken = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastUpdateTimestamp", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTimestamp = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RuntimeEnvironment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuntimeEnvironment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceExecutionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceExecutionRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ApplicationDetailUnmarshaller _instance = new ApplicationDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}