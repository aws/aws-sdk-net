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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpenLineageRunEventSummary Object
    /// </summary>  
    public class OpenLineageRunEventSummaryUnmarshaller : IUnmarshaller<OpenLineageRunEventSummary, XmlUnmarshallerContext>, IUnmarshaller<OpenLineageRunEventSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OpenLineageRunEventSummary IUnmarshaller<OpenLineageRunEventSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OpenLineageRunEventSummary Unmarshall(JsonUnmarshallerContext context)
        {
            OpenLineageRunEventSummary unmarshalledObject = new OpenLineageRunEventSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("eventType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NameIdentifier, NameIdentifierUnmarshaller>(NameIdentifierUnmarshaller.Instance);
                    unmarshalledObject.Inputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("job", targetDepth))
                {
                    var unmarshaller = NameIdentifierUnmarshaller.Instance;
                    unmarshalledObject.Job = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<NameIdentifier, NameIdentifierUnmarshaller>(NameIdentifierUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("runId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OpenLineageRunEventSummaryUnmarshaller _instance = new OpenLineageRunEventSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenLineageRunEventSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}