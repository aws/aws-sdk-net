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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataPipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataPipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListPipelines operation
    /// </summary>  
    public class ListPipelinesResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            ListPipelinesResponse response = new ListPipelinesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("hasMoreResults", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    response.HasMoreResults = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("marker", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Marker = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("pipelineIdList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PipelineIdName, PipelineIdNameUnmarshaller>(PipelineIdNameUnmarshaller.Instance);
                    response.PipelineIdList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServiceError"))
            {
                return new InternalServiceErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonDataPipelineException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListPipelinesResponseUnmarshaller _instance = new ListPipelinesResponseUnmarshaller();        

        internal static ListPipelinesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static ListPipelinesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}