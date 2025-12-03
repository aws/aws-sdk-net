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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModelPackageSummary Object
    /// </summary>  
    public class ModelPackageSummaryUnmarshaller : IUnmarshaller<ModelPackageSummary, XmlUnmarshallerContext>, IUnmarshaller<ModelPackageSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ModelPackageSummary IUnmarshaller<ModelPackageSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ModelPackageSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ModelPackageSummary unmarshalledObject = new ModelPackageSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelApprovalStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelApprovalStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelLifeCycle", targetDepth))
                {
                    var unmarshaller = ModelLifeCycleUnmarshaller.Instance;
                    unmarshalledObject.ModelLifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageRegistrationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageRegistrationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ModelPackageSummaryUnmarshaller _instance = new ModelPackageSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModelPackageSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}