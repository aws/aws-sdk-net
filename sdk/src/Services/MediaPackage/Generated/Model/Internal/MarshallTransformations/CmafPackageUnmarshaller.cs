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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CmafPackage Object
    /// </summary>  
    public class CmafPackageUnmarshaller : IJsonUnmarshaller<CmafPackage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CmafPackage Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CmafPackage unmarshalledObject = new CmafPackage();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("encryption", targetDepth))
                {
                    var unmarshaller = CmafEncryptionUnmarshaller.Instance;
                    unmarshalledObject.Encryption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hlsManifests", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HlsManifest, HlsManifestUnmarshaller>(HlsManifestUnmarshaller.Instance);
                    unmarshalledObject.HlsManifests = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentDurationSeconds", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.SegmentDurationSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("segmentPrefix", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SegmentPrefix = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("streamSelection", targetDepth))
                {
                    var unmarshaller = StreamSelectionUnmarshaller.Instance;
                    unmarshalledObject.StreamSelection = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CmafPackageUnmarshaller _instance = new CmafPackageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CmafPackageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}