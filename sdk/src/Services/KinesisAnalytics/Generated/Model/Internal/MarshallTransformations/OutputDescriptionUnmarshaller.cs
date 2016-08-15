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
    /// Response Unmarshaller for OutputDescription Object
    /// </summary>  
    public class OutputDescriptionUnmarshaller : IUnmarshaller<OutputDescription, XmlUnmarshallerContext>, IUnmarshaller<OutputDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OutputDescription IUnmarshaller<OutputDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OutputDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OutputDescription unmarshalledObject = new OutputDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DestinationSchema", targetDepth))
                {
                    var unmarshaller = DestinationSchemaUnmarshaller.Instance;
                    unmarshalledObject.DestinationSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisFirehoseOutputDescription", targetDepth))
                {
                    var unmarshaller = KinesisFirehoseOutputDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KinesisFirehoseOutputDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KinesisStreamsOutputDescription", targetDepth))
                {
                    var unmarshaller = KinesisStreamsOutputDescriptionUnmarshaller.Instance;
                    unmarshalledObject.KinesisStreamsOutputDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OutputDescriptionUnmarshaller _instance = new OutputDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OutputDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}