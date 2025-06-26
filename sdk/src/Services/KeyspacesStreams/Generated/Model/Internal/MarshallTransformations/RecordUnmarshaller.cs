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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyspacesStreams.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.KeyspacesStreams.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Record Object
    /// </summary>  
    public class RecordUnmarshaller : IJsonUnmarshaller<Record, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Record Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Record unmarshalledObject = new Record();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("clusteringKeys", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, KeyspacesCellValue, StringUnmarshaller, KeyspacesCellValueUnmarshaller>(StringUnmarshaller.Instance, KeyspacesCellValueUnmarshaller.Instance);
                    unmarshalledObject.ClusteringKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eventVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("newImage", targetDepth))
                {
                    var unmarshaller = KeyspacesRowUnmarshaller.Instance;
                    unmarshalledObject.NewImage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("oldImage", targetDepth))
                {
                    var unmarshaller = KeyspacesRowUnmarshaller.Instance;
                    unmarshalledObject.OldImage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("origin", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Origin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("partitionKeys", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, KeyspacesCellValue, StringUnmarshaller, KeyspacesCellValueUnmarshaller>(StringUnmarshaller.Instance, KeyspacesCellValueUnmarshaller.Instance);
                    unmarshalledObject.PartitionKeys = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sequenceNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SequenceNumber = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RecordUnmarshaller _instance = new RecordUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecordUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}