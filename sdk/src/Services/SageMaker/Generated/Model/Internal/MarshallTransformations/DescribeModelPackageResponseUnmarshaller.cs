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
    /// Response Unmarshaller for DescribeModelPackage operation
    /// </summary>  
    public class DescribeModelPackageResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeModelPackageResponse response = new DescribeModelPackageResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalInferenceSpecifications", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AdditionalInferenceSpecificationDefinition, AdditionalInferenceSpecificationDefinitionUnmarshaller>(AdditionalInferenceSpecificationDefinitionUnmarshaller.Instance);
                    response.AdditionalInferenceSpecifications = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApprovalDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ApprovalDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CertifyForMarketplace", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.CertifyForMarketplace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerMetadataProperties", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.CustomerMetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Domain", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Domain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DriftCheckBaselines", targetDepth))
                {
                    var unmarshaller = DriftCheckBaselinesUnmarshaller.Instance;
                    response.DriftCheckBaselines = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InferenceSpecification", targetDepth))
                {
                    var unmarshaller = InferenceSpecificationUnmarshaller.Instance;
                    response.InferenceSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedBy", targetDepth))
                {
                    var unmarshaller = UserContextUnmarshaller.Instance;
                    response.LastModifiedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastModifiedTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetadataProperties", targetDepth))
                {
                    var unmarshaller = MetadataPropertiesUnmarshaller.Instance;
                    response.MetadataProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelApprovalStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelApprovalStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelCard", targetDepth))
                {
                    var unmarshaller = ModelPackageModelCardUnmarshaller.Instance;
                    response.ModelCard = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelLifeCycle", targetDepth))
                {
                    var unmarshaller = ModelLifeCycleUnmarshaller.Instance;
                    response.ModelLifeCycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelMetrics", targetDepth))
                {
                    var unmarshaller = ModelMetricsUnmarshaller.Instance;
                    response.ModelMetrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageRegistrationType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageRegistrationType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ModelPackageStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageStatusDetails", targetDepth))
                {
                    var unmarshaller = ModelPackageStatusDetailsUnmarshaller.Instance;
                    response.ModelPackageStatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ModelPackageVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.ModelPackageVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SamplePayloadUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SamplePayloadUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecurityConfig", targetDepth))
                {
                    var unmarshaller = ModelPackageSecurityConfigUnmarshaller.Instance;
                    response.SecurityConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkipModelValidation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SkipModelValidation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceAlgorithmSpecification", targetDepth))
                {
                    var unmarshaller = SourceAlgorithmSpecificationUnmarshaller.Instance;
                    response.SourceAlgorithmSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Task", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Task = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ValidationSpecification", targetDepth))
                {
                    var unmarshaller = ModelPackageValidationSpecificationUnmarshaller.Instance;
                    response.ValidationSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, null))
            {
            }
            return new AmazonSageMakerException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeModelPackageResponseUnmarshaller _instance = new DescribeModelPackageResponseUnmarshaller();        

        internal static DescribeModelPackageResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeModelPackageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}