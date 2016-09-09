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
    /// Response Unmarshaller for SourceSchema Object
    /// </summary>  
    public class SourceSchemaUnmarshaller : IUnmarshaller<SourceSchema, XmlUnmarshallerContext>, IUnmarshaller<SourceSchema, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceSchema IUnmarshaller<SourceSchema, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceSchema Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceSchema unmarshalledObject = new SourceSchema();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RecordColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RecordColumn, RecordColumnUnmarshaller>(RecordColumnUnmarshaller.Instance);
                    unmarshalledObject.RecordColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordEncoding", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordEncoding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordFormat", targetDepth))
                {
                    var unmarshaller = RecordFormatUnmarshaller.Instance;
                    unmarshalledObject.RecordFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceSchemaUnmarshaller _instance = new SourceSchemaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceSchemaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}