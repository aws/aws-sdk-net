/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Ingestion Object
    /// </summary>  
    public class IngestionUnmarshaller : IUnmarshaller<Ingestion, XmlUnmarshallerContext>, IUnmarshaller<Ingestion, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Ingestion IUnmarshaller<Ingestion, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Ingestion Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Ingestion unmarshalledObject = new Ingestion();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ErrorInfo", targetDepth))
                {
                    var unmarshaller = ErrorInfoUnmarshaller.Instance;
                    unmarshalledObject.ErrorInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IngestionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IngestionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IngestionSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.IngestionSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IngestionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IngestionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IngestionTimeInSeconds", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.IngestionTimeInSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QueueInfo", targetDepth))
                {
                    var unmarshaller = QueueInfoUnmarshaller.Instance;
                    unmarshalledObject.QueueInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequestSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequestType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RequestType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowInfo", targetDepth))
                {
                    var unmarshaller = RowInfoUnmarshaller.Instance;
                    unmarshalledObject.RowInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static IngestionUnmarshaller _instance = new IngestionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IngestionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}