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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Sequence Object
    /// </summary>  
    public class SequenceUnmarshaller : IJsonUnmarshaller<Sequence, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Sequence Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Sequence unmarshalledObject = new Sequence();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("actors", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Actor, ActorUnmarshaller>(ActorUnmarshaller.Instance);
                    unmarshalledObject.Actors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("additionalSequenceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdditionalSequenceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("endpoints", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<NetworkEndpoint, NetworkEndpointUnmarshaller>(NetworkEndpointUnmarshaller.Instance);
                    unmarshalledObject.Endpoints = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resources", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceV2, ResourceV2Unmarshaller>(ResourceV2Unmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sequenceIndicators", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Indicator, IndicatorUnmarshaller>(IndicatorUnmarshaller.Instance);
                    unmarshalledObject.SequenceIndicators = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("signals", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Signal, SignalUnmarshaller>(SignalUnmarshaller.Instance);
                    unmarshalledObject.Signals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uid", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Uid = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SequenceUnmarshaller _instance = new SequenceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SequenceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}