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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingConfigurationOutput Object
    /// </summary>  
    public class ScalingConfigurationOutputUnmarshaller : IUnmarshaller<ScalingConfigurationOutput, XmlUnmarshallerContext>, IUnmarshaller<ScalingConfigurationOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScalingConfigurationOutput IUnmarshaller<ScalingConfigurationOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ScalingConfigurationOutput Unmarshall(JsonUnmarshallerContext context)
        {
            ScalingConfigurationOutput unmarshalledObject = new ScalingConfigurationOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("desiredCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DesiredCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("maxCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("scalingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetTrackingScalingConfigs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TargetTrackingScalingConfiguration, TargetTrackingScalingConfigurationUnmarshaller>(TargetTrackingScalingConfigurationUnmarshaller.Instance);
                    unmarshalledObject.TargetTrackingScalingConfigs = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ScalingConfigurationOutputUnmarshaller _instance = new ScalingConfigurationOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingConfigurationOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}