/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeProvisioningParameters operation
    /// </summary>  
    public class DescribeProvisioningParametersResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeProvisioningParametersResponse response = new DescribeProvisioningParametersResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ConstraintSummaries", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ConstraintSummary, ConstraintSummaryUnmarshaller>(ConstraintSummaryUnmarshaller.Instance);
                    response.ConstraintSummaries = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProvisioningArtifactParameters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProvisioningArtifactParameter, ProvisioningArtifactParameterUnmarshaller>(ProvisioningArtifactParameterUnmarshaller.Instance);
                    response.ProvisioningArtifactParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UsageInstructions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<UsageInstruction, UsageInstructionUnmarshaller>(UsageInstructionUnmarshaller.Instance);
                    response.UsageInstructions = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParametersException"))
            {
                return new InvalidParametersException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonServiceCatalogException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeProvisioningParametersResponseUnmarshaller _instance = new DescribeProvisioningParametersResponseUnmarshaller();        

        internal static DescribeProvisioningParametersResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeProvisioningParametersResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}