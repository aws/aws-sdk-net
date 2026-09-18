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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetHlsManifestConfiguration Object
    /// </summary>
    public partial class GetHlsManifestConfigurationUnmarshaller : IJsonUnmarshaller<GetHlsManifestConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public GetHlsManifestConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new GetHlsManifestConfiguration();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ChildManifestName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChildManifestName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("FilterConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = FilterConfigurationUnmarshaller.Instance;
                    unmarshalledObject.FilterConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ManifestName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManifestName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ManifestWindowSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ManifestWindowSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProgramDateTimeIntervalSeconds", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ProgramDateTimeIntervalSeconds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ScteHls", targetDepth, ref reader))
                {
                    var unmarshaller = ScteHlsUnmarshaller.Instance;
                    unmarshalledObject.ScteHls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StartTag", targetDepth, ref reader))
                {
                    var unmarshaller = StartTagUnmarshaller.Instance;
                    unmarshalledObject.StartTag = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("UriPathType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UriPathType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Url", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Url = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("UrlEncodeChildManifest", targetDepth, ref reader))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.UrlEncodeChildManifest = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static GetHlsManifestConfigurationUnmarshaller _instance = new GetHlsManifestConfigurationUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetHlsManifestConfigurationUnmarshaller Instance => _instance;
    }
}
