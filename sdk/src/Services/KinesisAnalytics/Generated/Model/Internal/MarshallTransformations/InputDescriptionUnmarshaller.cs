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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InputDescription Object
    /// </summary>  
    public class InputDescriptionUnmarshaller : IUnmarshaller<InputDescription, XmlUnmarshallerContext>, IUnmarshaller<InputDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InputDescription IUnmarshaller<InputDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InputDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InputDescription unmarshalledObject = new InputDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("InAppStreamNames", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InAppStreamNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputParallelism", targetDepth))
                {
                    var unmarshaller = InputParallelismUnmarshaller.Instance;
                    unmarshalledObject.InputParallelism = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputSchema", targetDepth))
                {
                    var unmarshaller = SourceSchemaUnmarshaller.Instance;
                    unmarshalledObject.InputSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputStartingPositionConfiguration", targetDepth))
                {
                    var unmarshaller = InputStartingPositionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.InputStartingPositionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisFirehoseInputDescription", targetDepth))
                {
                    var unmarshaller = KinesisFirehoseInputDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KinesisFirehoseInputDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisStreamsInputDescription", targetDepth))
                {
                    var unmarshaller = KinesisStreamsInputDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamsInputDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NamePrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NamePrefix = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InputDescriptionUnmarshaller _instance = new InputDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InputDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}