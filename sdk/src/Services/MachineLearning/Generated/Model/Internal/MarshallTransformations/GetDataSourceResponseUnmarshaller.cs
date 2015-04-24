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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MachineLearning.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MachineLearning.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDataSource operation
    /// </summary>  
    public class GetDataSourceResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetDataSourceResponse response = new GetDataSourceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ComputeStatistics", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.ComputeStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreatedByIamUser", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.CreatedByIamUser = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLocationS3", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataLocationS3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataRearrangement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataRearrangement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.DataSizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataSourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataSourceSchema", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DataSourceSchema = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LogUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Message", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Message = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfFiles", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    response.NumberOfFiles = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RDSMetadata", targetDepth))
                {
                    var unmarshaller = RDSMetadataUnmarshaller.Instance;
                    response.RDSMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftMetadata", targetDepth))
                {
                    var unmarshaller = RedshiftMetadataUnmarshaller.Instance;
                    response.RedshiftMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RoleARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerException"))
            {
                return new InternalServerException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInputException"))
            {
                return new InvalidInputException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonMachineLearningException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetDataSourceResponseUnmarshaller _instance = new GetDataSourceResponseUnmarshaller();        

        internal static GetDataSourceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetDataSourceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}