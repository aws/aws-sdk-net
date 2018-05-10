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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParquetSerDe Object
    /// </summary>  
    public class ParquetSerDeUnmarshaller : IUnmarshaller<ParquetSerDe, XmlUnmarshallerContext>, IUnmarshaller<ParquetSerDe, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ParquetSerDe IUnmarshaller<ParquetSerDe, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ParquetSerDe Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ParquetSerDe unmarshalledObject = new ParquetSerDe();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BlockSizeBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BlockSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Compression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Compression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnableDictionaryCompression", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnableDictionaryCompression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxPaddingBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxPaddingBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PageSizeBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PageSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WriterVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WriterVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ParquetSerDeUnmarshaller _instance = new ParquetSerDeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParquetSerDeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}