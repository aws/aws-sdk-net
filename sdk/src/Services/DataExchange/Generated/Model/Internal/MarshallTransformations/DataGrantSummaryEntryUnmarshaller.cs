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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataGrantSummaryEntry Object
    /// </summary>  
    public class DataGrantSummaryEntryUnmarshaller : IJsonUnmarshaller<DataGrantSummaryEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DataGrantSummaryEntry Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DataGrantSummaryEntry unmarshalledObject = new DataGrantSummaryEntry();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AcceptanceState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AcceptanceState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AcceptedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.AcceptedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataSetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndsAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndsAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ReceiverPrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReceiverPrincipal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SenderPrincipal", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SenderPrincipal = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SourceDataSetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceDataSetId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UpdatedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataGrantSummaryEntryUnmarshaller _instance = new DataGrantSummaryEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataGrantSummaryEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}