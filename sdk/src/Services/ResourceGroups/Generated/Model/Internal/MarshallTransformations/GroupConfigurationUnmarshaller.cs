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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceGroups.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ResourceGroups.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GroupConfiguration Object
    /// </summary>  
    public class GroupConfigurationUnmarshaller : IJsonUnmarshaller<GroupConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public GroupConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            GroupConfiguration unmarshalledObject = new GroupConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Configuration", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<GroupConfigurationItem, GroupConfigurationItemUnmarshaller>(GroupConfigurationItemUnmarshaller.Instance);
                    unmarshalledObject.Configuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ProposedConfiguration", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<GroupConfigurationItem, GroupConfigurationItemUnmarshaller>(GroupConfigurationItemUnmarshaller.Instance);
                    unmarshalledObject.ProposedConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static GroupConfigurationUnmarshaller _instance = new GroupConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GroupConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}