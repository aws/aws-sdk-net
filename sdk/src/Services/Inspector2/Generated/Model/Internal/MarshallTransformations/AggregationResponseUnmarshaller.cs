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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AggregationResponse Object
    /// </summary>  
    public class AggregationResponseUnmarshaller : IJsonUnmarshaller<AggregationResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AggregationResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AggregationResponse unmarshalledObject = new AggregationResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountAggregation", targetDepth))
                {
                    var unmarshaller = AccountAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.AccountAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("amiAggregation", targetDepth))
                {
                    var unmarshaller = AmiAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.AmiAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("awsEcrContainerAggregation", targetDepth))
                {
                    var unmarshaller = AwsEcrContainerAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.AwsEcrContainerAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("codeRepositoryAggregation", targetDepth))
                {
                    var unmarshaller = CodeRepositoryAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.CodeRepositoryAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2InstanceAggregation", targetDepth))
                {
                    var unmarshaller = Ec2InstanceAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("findingTypeAggregation", targetDepth))
                {
                    var unmarshaller = FindingTypeAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.FindingTypeAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageLayerAggregation", targetDepth))
                {
                    var unmarshaller = ImageLayerAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.ImageLayerAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaFunctionAggregation", targetDepth))
                {
                    var unmarshaller = LambdaFunctionAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunctionAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaLayerAggregation", targetDepth))
                {
                    var unmarshaller = LambdaLayerAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.LambdaLayerAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("packageAggregation", targetDepth))
                {
                    var unmarshaller = PackageAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.PackageAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("repositoryAggregation", targetDepth))
                {
                    var unmarshaller = RepositoryAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.RepositoryAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("titleAggregation", targetDepth))
                {
                    var unmarshaller = TitleAggregationResponseUnmarshaller.Instance;
                    unmarshalledObject.TitleAggregation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AggregationResponseUnmarshaller _instance = new AggregationResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AggregationResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}