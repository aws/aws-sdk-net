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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Distribution Object
    /// </summary>  
    public class DistributionUnmarshaller : IJsonUnmarshaller<Distribution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Distribution Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Distribution unmarshalledObject = new Distribution();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("amiDistributionConfiguration", targetDepth))
                {
                    var unmarshaller = AmiDistributionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AmiDistributionConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containerDistributionConfiguration", targetDepth))
                {
                    var unmarshaller = ContainerDistributionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ContainerDistributionConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("fastLaunchConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FastLaunchConfiguration, FastLaunchConfigurationUnmarshaller>(FastLaunchConfigurationUnmarshaller.Instance);
                    unmarshalledObject.FastLaunchConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("launchTemplateConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<LaunchTemplateConfiguration, LaunchTemplateConfigurationUnmarshaller>(LaunchTemplateConfigurationUnmarshaller.Instance);
                    unmarshalledObject.LaunchTemplateConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("licenseConfigurationArns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LicenseConfigurationArns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3ExportConfiguration", targetDepth))
                {
                    var unmarshaller = S3ExportConfigurationUnmarshaller.Instance;
                    unmarshalledObject.S3ExportConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ssmParameterConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<SsmParameterConfiguration, SsmParameterConfigurationUnmarshaller>(SsmParameterConfigurationUnmarshaller.Instance);
                    unmarshalledObject.SsmParameterConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DistributionUnmarshaller _instance = new DistributionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DistributionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}