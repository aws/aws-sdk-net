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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kinesis.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kinesis.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Record Object
    /// </summary>  
    public class RecordUnmarshaller : IUnmarshaller<Record, XmlUnmarshallerContext>, IUnmarshaller<Record, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Record IUnmarshaller<Record, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Record Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Record unmarshalledObject = new Record();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApproximateArrivalTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ApproximateArrivalTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Data", targetDepth))
                {
                    var unmarshaller = MemoryStreamUnmarshaller.Instance;
                    unmarshalledObject.Data = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PartitionKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PartitionKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SequenceNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SequenceNumber = unmarshaller.Unmarshall(context);
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