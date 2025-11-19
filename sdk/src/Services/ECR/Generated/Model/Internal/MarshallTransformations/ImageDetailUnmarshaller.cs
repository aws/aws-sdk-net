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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECR.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ECR.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImageDetail Object
    /// </summary>  
    public class ImageDetailUnmarshaller : IUnmarshaller<ImageDetail, XmlUnmarshallerContext>, IUnmarshaller<ImageDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImageDetail IUnmarshaller<ImageDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ImageDetail Unmarshall(JsonUnmarshallerContext context)
        {
            ImageDetail unmarshalledObject = new ImageDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("artifactMediaType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ArtifactMediaType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageDigest = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageManifestMediaType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageManifestMediaType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imagePushedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ImagePushedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageScanFindingsSummary", targetDepth))
                {
                    var unmarshaller = ImageScanFindingsSummaryUnmarshaller.Instance;
                    unmarshalledObject.ImageScanFindingsSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageScanStatus", targetDepth))
                {
                    var unmarshaller = ImageScanStatusUnmarshaller.Instance;
                    unmarshalledObject.ImageScanStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ImageSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageTags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ImageTags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastActivatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastActivatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastArchivedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastArchivedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastRecordedPullTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastRecordedPullTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("registryId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RegistryId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("repositoryName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RepositoryName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("subjectManifestDigest", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubjectManifestDigest = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ImageDetailUnmarshaller _instance = new ImageDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImageDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}