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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateAsset operation
    /// </summary>  
    public class CreateAssetResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateAssetResponse response = new CreateAssetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("domainId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DomainId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("externalIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ExternalIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstRevisionCreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.FirstRevisionCreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("firstRevisionCreatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FirstRevisionCreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("formsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FormOutput, FormOutputUnmarshaller>(FormOutputUnmarshaller.Instance);
                    response.FormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("glossaryTerms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.GlossaryTerms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("governedGlossaryTerms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.GovernedGlossaryTerms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("latestTimeSeriesDataPointFormsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TimeSeriesDataPointSummaryFormOutput, TimeSeriesDataPointSummaryFormOutputUnmarshaller>(TimeSeriesDataPointSummaryFormOutputUnmarshaller.Instance);
                    response.LatestTimeSeriesDataPointFormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listing", targetDepth))
                {
                    var unmarshaller = AssetListingDetailsUnmarshaller.Instance;
                    response.Listing = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("owningProjectId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwningProjectId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("predictionConfiguration", targetDepth))
                {
                    var unmarshaller = PredictionConfigurationUnmarshaller.Instance;
                    response.PredictionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("readOnlyFormsOutput", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FormOutput, FormOutputUnmarshaller>(FormOutputUnmarshaller.Instance);
                    response.ReadOnlyFormsOutput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Revision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("typeIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TypeIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("typeRevision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TypeRevision = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AccessDeniedException"))
                {
                    return AccessDeniedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ConflictException"))
                {
                    return ConflictExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
                {
                    return InternalServerExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceQuotaExceededException"))
                {
                    return ServiceQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnauthorizedException"))
                {
                    return UnauthorizedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                {
                    return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonDataZoneException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static CreateAssetResponseUnmarshaller _instance = new CreateAssetResponseUnmarshaller();        

        internal static CreateAssetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}