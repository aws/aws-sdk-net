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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StepDetail Object
    /// </summary>  
    public class StepDetailUnmarshaller : IUnmarshaller<StepDetail, XmlUnmarshallerContext>, IUnmarshaller<StepDetail, JsonUnmarshallerContext>
    {
        StepDetail IUnmarshaller<StepDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public StepDetail Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StepDetail unmarshalledObject = new StepDetail();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExecutionStatusDetail", targetDepth))
                {
                    var unmarshaller = StepExecutionStatusDetailUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStatusDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StepConfig", targetDepth))
                {
                    var unmarshaller = StepConfigUnmarshaller.Instance;
                    unmarshalledObject.StepConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StepDetailUnmarshaller _instance = new StepDetailUnmarshaller();        

        public static StepDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}