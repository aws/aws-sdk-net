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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Shield.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Shield.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttackDetail Object
    /// </summary>  
    public class AttackDetailUnmarshaller : IJsonUnmarshaller<AttackDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AttackDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AttackDetail unmarshalledObject = new AttackDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AttackCounters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SummarizedCounter, SummarizedCounterUnmarshaller>(SummarizedCounterUnmarshaller.Instance);
                    unmarshalledObject.AttackCounters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttackId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AttackId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AttackProperties", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttackProperty, AttackPropertyUnmarshaller>(AttackPropertyUnmarshaller.Instance);
                    unmarshalledObject.AttackProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Mitigations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Mitigation, MitigationUnmarshaller>(MitigationUnmarshaller.Instance);
                    unmarshalledObject.Mitigations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SubResources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SubResourceSummary, SubResourceSummaryUnmarshaller>(SubResourceSummaryUnmarshaller.Instance);
                    unmarshalledObject.SubResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AttackDetailUnmarshaller _instance = new AttackDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttackDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}