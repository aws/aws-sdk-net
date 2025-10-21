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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CodecMetadata Object
    /// </summary>  
    public class CodecMetadataUnmarshaller : IUnmarshaller<CodecMetadata, XmlUnmarshallerContext>, IUnmarshaller<CodecMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CodecMetadata IUnmarshaller<CodecMetadata, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public CodecMetadata Unmarshall(JsonUnmarshallerContext context)
        {
            CodecMetadata unmarshalledObject = new CodecMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("bitDepth", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.BitDepth = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("chromaSubsampling", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChromaSubsampling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("codedFrameRate", targetDepth))
                {
                    var unmarshaller = FrameRateUnmarshaller.Instance;
                    unmarshalledObject.CodedFrameRate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("colorPrimaries", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorPrimaries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("height", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Height = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("level", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Level = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("matrixCoefficients", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MatrixCoefficients = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("profile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Profile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scanType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScanType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("transferCharacteristics", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TransferCharacteristics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("width", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Width = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CodecMetadataUnmarshaller _instance = new CodecMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CodecMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}