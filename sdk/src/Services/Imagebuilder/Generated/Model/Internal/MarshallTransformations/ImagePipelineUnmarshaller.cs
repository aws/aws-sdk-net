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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ImagePipeline Object
    /// </summary>  
    public class ImagePipelineUnmarshaller : IUnmarshaller<ImagePipeline, XmlUnmarshallerContext>, IUnmarshaller<ImagePipeline, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ImagePipeline IUnmarshaller<ImagePipeline, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ImagePipeline Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ImagePipeline unmarshalledObject = new ImagePipeline();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("containerRecipeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ContainerRecipeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateCreated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateCreated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateLastRun", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateLastRun = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateNextRun", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateNextRun = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dateUpdated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DateUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("distributionConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DistributionConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enhancedImageMetadataEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EnhancedImageMetadataEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageRecipeArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageRecipeArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageScanningConfiguration", targetDepth))
                {
                    var unmarshaller = ImageScanningConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ImageScanningConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("imageTestsConfiguration", targetDepth))
                {
                    var unmarshaller = ImageTestsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ImageTestsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("infrastructureConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InfrastructureConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("platform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Platform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schedule", targetDepth))
                {
                    var unmarshaller = ScheduleUnmarshaller.Instance;
                    unmarshalledObject.Schedule = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ImagePipelineUnmarshaller _instance = new ImagePipelineUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImagePipelineUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}