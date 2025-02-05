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
 * Do not modify this file. This file is generated from the codeartifact-2018-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeArtifact.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeArtifact.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PackageVersionDescription Object
    /// </summary>  
    public class PackageVersionDescriptionUnmarshaller : IJsonUnmarshaller<PackageVersionDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public PackageVersionDescription Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            PackageVersionDescription unmarshalledObject = new PackageVersionDescription();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("displayName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DisplayName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("format", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Format = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("homePage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HomePage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LicenseInfo, LicenseInfoUnmarshaller>(LicenseInfoUnmarshaller.Instance);
                    unmarshalledObject.Licenses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("namespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Namespace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("origin", targetDepth))
                {
                    var unmarshaller = PackageVersionOriginUnmarshaller.Instance;
                    unmarshalledObject.Origin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("packageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PackageName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("publishedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.PublishedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("revision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Revision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sourceCodeRepository", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceCodeRepository = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("summary", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Summary = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static PackageVersionDescriptionUnmarshaller _instance = new PackageVersionDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PackageVersionDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}