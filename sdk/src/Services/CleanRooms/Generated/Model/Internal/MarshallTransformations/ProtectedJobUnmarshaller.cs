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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CleanRooms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CleanRooms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ProtectedJob Object
    /// </summary>  
    public class ProtectedJobUnmarshaller : IUnmarshaller<ProtectedJob, XmlUnmarshallerContext>, IUnmarshaller<ProtectedJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ProtectedJob IUnmarshaller<ProtectedJob, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ProtectedJob Unmarshall(JsonUnmarshallerContext context)
        {
            ProtectedJob unmarshalledObject = new ProtectedJob();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("createTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("error", targetDepth))
                {
                    var unmarshaller = ProtectedJobErrorUnmarshaller.Instance;
                    unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("jobParameters", targetDepth))
                {
                    var unmarshaller = ProtectedJobParametersUnmarshaller.Instance;
                    unmarshalledObject.JobParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MembershipArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("membershipId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MembershipId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("result", targetDepth))
                {
                    var unmarshaller = ProtectedJobResultUnmarshaller.Instance;
                    unmarshalledObject.Result = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resultConfiguration", targetDepth))
                {
                    var unmarshaller = ProtectedJobResultConfigurationOutputUnmarshaller.Instance;
                    unmarshalledObject.ResultConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("statistics", targetDepth))
                {
                    var unmarshaller = ProtectedJobStatisticsUnmarshaller.Instance;
                    unmarshalledObject.Statistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProtectedJobUnmarshaller _instance = new ProtectedJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProtectedJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}