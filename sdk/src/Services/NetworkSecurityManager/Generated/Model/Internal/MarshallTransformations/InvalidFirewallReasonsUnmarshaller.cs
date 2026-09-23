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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkSecurityManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkSecurityManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvalidFirewallReasons Object
    /// </summary>  
    public class InvalidFirewallReasonsUnmarshaller : IJsonUnmarshaller<InvalidFirewallReasons, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InvalidFirewallReasons Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InvalidFirewallReasons unmarshalledObject = new InvalidFirewallReasons();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("incorrectAppendableConfigurationOrder", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.IncorrectAppendableConfigurationOrder = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("incorrectSingleValueConfigurations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.IncorrectSingleValueConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingAppendableConfigurationValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.MissingAppendableConfigurationValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("missingMergeableConfigurationValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.MissingMergeableConfigurationValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unexpectedAppendableConfigurationValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.UnexpectedAppendableConfigurationValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unexpectedMergeableConfigurationValues", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ConfigurationIssue, ConfigurationIssueUnmarshaller>(ConfigurationIssueUnmarshaller.Instance);
                    unmarshalledObject.UnexpectedMergeableConfigurationValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InvalidFirewallReasonsUnmarshaller _instance = new InvalidFirewallReasonsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvalidFirewallReasonsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}