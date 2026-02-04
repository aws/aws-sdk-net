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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChannelSummary Object
    /// </summary>  
    public class ChannelSummaryUnmarshaller : IUnmarshaller<ChannelSummary, XmlUnmarshallerContext>, IUnmarshaller<ChannelSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ChannelSummary IUnmarshaller<ChannelSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ChannelSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ChannelSummary unmarshalledObject = new ChannelSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("anywhereSettings", targetDepth))
                {
                    var unmarshaller = DescribeAnywhereSettingsUnmarshaller.Instance;
                    unmarshalledObject.AnywhereSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cdiInputSpecification", targetDepth))
                {
                    var unmarshaller = CdiInputSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CdiInputSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChannelClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelEngineVersion", targetDepth))
                {
                    var unmarshaller = ChannelEngineVersionResponseUnmarshaller.Instance;
                    unmarshalledObject.ChannelEngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelSecurityGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ChannelSecurityGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("destinations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OutputDestination, OutputDestinationUnmarshaller>(OutputDestinationUnmarshaller.Instance);
                    unmarshalledObject.Destinations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("egressEndpoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChannelEgressEndpoint, ChannelEgressEndpointUnmarshaller>(ChannelEgressEndpointUnmarshaller.Instance);
                    unmarshalledObject.EgressEndpoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputAttachments", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InputAttachment, InputAttachmentUnmarshaller>(InputAttachmentUnmarshaller.Instance);
                    unmarshalledObject.InputAttachments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputSpecification", targetDepth))
                {
                    var unmarshaller = InputSpecificationUnmarshaller.Instance;
                    unmarshalledObject.InputSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("linkedChannelSettings", targetDepth))
                {
                    var unmarshaller = DescribeLinkedChannelSettingsUnmarshaller.Instance;
                    unmarshalledObject.LinkedChannelSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logLevel", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maintenance", targetDepth))
                {
                    var unmarshaller = MaintenanceStatusUnmarshaller.Instance;
                    unmarshalledObject.Maintenance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelinesRunningCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PipelinesRunningCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("state", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("usedChannelEngineVersions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ChannelEngineVersionResponse, ChannelEngineVersionResponseUnmarshaller>(ChannelEngineVersionResponseUnmarshaller.Instance);
                    unmarshalledObject.UsedChannelEngineVersions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpc", targetDepth))
                {
                    var unmarshaller = VpcOutputSettingsDescriptionUnmarshaller.Instance;
                    unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ChannelSummaryUnmarshaller _instance = new ChannelSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChannelSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}