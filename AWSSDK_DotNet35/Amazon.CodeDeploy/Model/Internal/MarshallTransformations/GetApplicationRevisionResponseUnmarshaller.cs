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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetApplicationRevision operation
    /// </summary>  
    public class GetApplicationRevisionResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetApplicationRevisionResponse response = new GetApplicationRevisionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("applicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ApplicationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revision", targetDepth))
                {
                    var unmarshaller = RevisionLocationUnmarshaller.Instance;
                    response.Revision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("revisionInfo", targetDepth))
                {
                    var unmarshaller = GenericRevisionInfoUnmarshaller.Instance;
                    response.RevisionInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ApplicationDoesNotExistException"))
            {
                return new ApplicationDoesNotExistException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ApplicationNameRequiredException"))
            {
                return new ApplicationNameRequiredException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidApplicationNameException"))
            {
                return new InvalidApplicationNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRevisionException"))
            {
                return new InvalidRevisionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("RevisionDoesNotExistException"))
            {
                return new RevisionDoesNotExistException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("RevisionRequiredException"))
            {
                return new RevisionRequiredException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonCodeDeployException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetApplicationRevisionResponseUnmarshaller _instance = new GetApplicationRevisionResponseUnmarshaller();        

        internal static GetApplicationRevisionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static GetApplicationRevisionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}