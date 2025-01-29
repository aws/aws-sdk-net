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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InvalidCloudWatchLogsRoleArnException Object
    /// </summary>  
    public class InvalidCloudWatchLogsRoleArnExceptionUnmarshaller : IJsonErrorResponseUnmarshaller<InvalidCloudWatchLogsRoleArnException, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        public InvalidCloudWatchLogsRoleArnException Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            return this.Unmarshall(context, new Amazon.Runtime.Internal.ErrorResponse(), ref reader);
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="errorResponse"></param>
        /// <param name="reader"></param>
        /// <returns></returns>
        public InvalidCloudWatchLogsRoleArnException Unmarshall(JsonUnmarshallerContext context, Amazon.Runtime.Internal.ErrorResponse errorResponse, ref StreamingUtf8JsonReader reader)
        {
            if (context.Stream.Length > 0)
            {
                context.Read(ref reader);
            }

            InvalidCloudWatchLogsRoleArnException unmarshalledObject = new InvalidCloudWatchLogsRoleArnException(errorResponse.Message, errorResponse.InnerException,
                errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        
            int targetDepth = context.CurrentDepth;
            if (context.Stream.Length > 0)
            {
                while (context.ReadAtDepth(targetDepth, ref reader))
                {
                }
            }
          
            return unmarshalledObject;
        }

        private static InvalidCloudWatchLogsRoleArnExceptionUnmarshaller _instance = new InvalidCloudWatchLogsRoleArnExceptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvalidCloudWatchLogsRoleArnExceptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}