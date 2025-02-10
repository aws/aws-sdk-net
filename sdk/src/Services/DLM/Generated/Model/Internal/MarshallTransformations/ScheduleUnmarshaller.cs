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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DLM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DLM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Schedule Object
    /// </summary>  
    public class ScheduleUnmarshaller : IJsonUnmarshaller<Schedule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Schedule Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Schedule unmarshalledObject = new Schedule();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ArchiveRule", targetDepth))
                {
                    var unmarshaller = ArchiveRuleUnmarshaller.Instance;
                    unmarshalledObject.ArchiveRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CopyTags", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.CopyTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreateRule", targetDepth))
                {
                    var unmarshaller = CreateRuleUnmarshaller.Instance;
                    unmarshalledObject.CreateRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CrossRegionCopyRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CrossRegionCopyRule, CrossRegionCopyRuleUnmarshaller>(CrossRegionCopyRuleUnmarshaller.Instance);
                    unmarshalledObject.CrossRegionCopyRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DeprecateRule", targetDepth))
                {
                    var unmarshaller = DeprecateRuleUnmarshaller.Instance;
                    unmarshalledObject.DeprecateRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FastRestoreRule", targetDepth))
                {
                    var unmarshaller = FastRestoreRuleUnmarshaller.Instance;
                    unmarshalledObject.FastRestoreRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetainRule", targetDepth))
                {
                    var unmarshaller = RetainRuleUnmarshaller.Instance;
                    unmarshalledObject.RetainRule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShareRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ShareRule, ShareRuleUnmarshaller>(ShareRuleUnmarshaller.Instance);
                    unmarshalledObject.ShareRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TagsToAdd", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.TagsToAdd = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VariableTags", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.VariableTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScheduleUnmarshaller _instance = new ScheduleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScheduleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}