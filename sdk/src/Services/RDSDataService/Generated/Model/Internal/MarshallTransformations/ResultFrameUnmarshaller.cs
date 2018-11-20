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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResultFrame Object
    /// </summary>  
    public class ResultFrameUnmarshaller : IUnmarshaller<ResultFrame, XmlUnmarshallerContext>, IUnmarshaller<ResultFrame, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResultFrame IUnmarshaller<ResultFrame, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResultFrame Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResultFrame unmarshalledObject = new ResultFrame();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("records", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Record, RecordUnmarshaller>(RecordUnmarshaller.Instance);
                    unmarshalledObject.Records = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resultSetMetadata", targetDepth))
                {
                    var unmarshaller = ResultSetMetadataUnmarshaller.Instance;
                    unmarshalledObject.ResultSetMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResultFrameUnmarshaller _instance = new ResultFrameUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResultFrameUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}