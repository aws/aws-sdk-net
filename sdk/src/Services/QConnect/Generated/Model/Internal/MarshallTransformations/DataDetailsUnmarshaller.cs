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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DataDetails Object
    /// </summary>  
    public class DataDetailsUnmarshaller : IUnmarshaller<DataDetails, XmlUnmarshallerContext>, IUnmarshaller<DataDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DataDetails IUnmarshaller<DataDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DataDetails Unmarshall(JsonUnmarshallerContext context)
        {
            DataDetails unmarshalledObject = new DataDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("contentData", targetDepth))
                {
                    var unmarshaller = ContentDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.ContentData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emailGenerativeAnswerChunkData", targetDepth))
                {
                    var unmarshaller = EmailGenerativeAnswerChunkDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.EmailGenerativeAnswerChunkData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emailOverviewChunkData", targetDepth))
                {
                    var unmarshaller = EmailOverviewChunkDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.EmailOverviewChunkData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("emailResponseChunkData", targetDepth))
                {
                    var unmarshaller = EmailResponseChunkDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.EmailResponseChunkData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("generativeChunkData", targetDepth))
                {
                    var unmarshaller = GenerativeChunkDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.GenerativeChunkData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("generativeData", targetDepth))
                {
                    var unmarshaller = GenerativeDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.GenerativeData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("intentDetectedData", targetDepth))
                {
                    var unmarshaller = IntentDetectedDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.IntentDetectedData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceContentData", targetDepth))
                {
                    var unmarshaller = SourceContentDataDetailsUnmarshaller.Instance;
                    unmarshalledObject.SourceContentData = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DataDetailsUnmarshaller _instance = new DataDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DataDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}