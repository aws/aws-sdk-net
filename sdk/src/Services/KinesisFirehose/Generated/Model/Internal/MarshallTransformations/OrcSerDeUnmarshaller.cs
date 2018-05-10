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
    /// Response Unmarshaller for OrcSerDe Object
    /// </summary>  
    public class OrcSerDeUnmarshaller : IUnmarshaller<OrcSerDe, XmlUnmarshallerContext>, IUnmarshaller<OrcSerDe, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrcSerDe IUnmarshaller<OrcSerDe, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public OrcSerDe Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            OrcSerDe unmarshalledObject = new OrcSerDe();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BlockSizeBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BlockSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BloomFilterColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BloomFilterColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BloomFilterFalsePositiveProbability", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.BloomFilterFalsePositiveProbability = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Compression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Compression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DictionaryKeyThreshold", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.DictionaryKeyThreshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EnablePadding", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnablePadding = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FormatVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FormatVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaddingTolerance", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.PaddingTolerance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RowIndexStride", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RowIndexStride = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StripeSizeBytes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StripeSizeBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static OrcSerDeUnmarshaller _instance = new OrcSerDeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrcSerDeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}