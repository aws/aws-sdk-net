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
    /// Response Unmarshaller for ModelPackage Object
    /// </summary>  
    public class ModelPackageUnmarshaller : IUnmarshaller<ModelPackage, XmlUnmarshallerContext>, IUnmarshaller<ModelPackage, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ModelPackage IUnmarshaller<ModelPackage, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ModelPackage Unmarshall(JsonUnmarshallerContext context)
        {
            ModelPackage unmarshalledObject = new ModelPackage();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalInferenceSpecifications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AdditionalInferenceSpecificationDefinition, AdditionalInferenceSpecificationDefinitionUnmarshaller>(AdditionalInferenceSpecificationDefinitionUnmarshaller.Instance);
                    unmarshalledObject.AdditionalInferenceSpecifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApprovalDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApprovalDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CertifyForMarketplace", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CertifyForMarketplace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerMetadataProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.CustomerMetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Domain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Domain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DriftCheckBaselines", targetDepth))
                {
                    var unmarshaller = DriftCheckBaselinesUnmarshaller.Instance;
                    unmarshalledObject.DriftCheckBaselines = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceSpecification", targetDepth))
                {
                    var unmarshaller = InferenceSpecificationUnmarshaller.Instance;
                    unmarshalledObject.InferenceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetadataProperties", targetDepth))
                {
                    var unmarshaller = MetadataPropertiesUnmarshaller.Instance;
                    unmarshalledObject.MetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelApprovalStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ModelApprovalStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelCard", targetDepth))
                {
                    var unmarshaller = ModelPackageModelCardUnmarshaller.Instance;
                    unmarshalledObject.ModelCard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelLifeCycle", targetDepth))
                {
                    var unmarshaller = ModelLifeCycleUnmarshaller.Instance;
                    unmarshalledObject.ModelLifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelMetrics", targetDepth))
                {
                    var unmarshaller = ModelMetricsUnmarshaller.Instance;
                    unmarshalledObject.ModelMetrics = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("ModelPackageStatusDetails", targetDepth))
                {
                    var unmarshaller = ModelPackageStatusDetailsUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ModelPackageVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SamplePayloadUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SamplePayloadUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityConfig", targetDepth))
                {
                    var unmarshaller = ModelPackageSecurityConfigUnmarshaller.Instance;
                    unmarshalledObject.SecurityConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkipModelValidation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SkipModelValidation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceAlgorithmSpecification", targetDepth))
                {
                    var unmarshaller = SourceAlgorithmSpecificationUnmarshaller.Instance;
                    unmarshalledObject.SourceAlgorithmSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Task", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Task = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationSpecification", targetDepth))
                {
                    var unmarshaller = ModelPackageValidationSpecificationUnmarshaller.Instance;
                    unmarshalledObject.ValidationSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ModelPackageUnmarshaller _instance = new ModelPackageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModelPackageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}