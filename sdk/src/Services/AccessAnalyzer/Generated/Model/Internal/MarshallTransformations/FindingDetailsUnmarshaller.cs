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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindingDetails Object
    /// </summary>  
    public class FindingDetailsUnmarshaller : IJsonUnmarshaller<FindingDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FindingDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FindingDetails unmarshalledObject = new FindingDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("externalAccessDetails", targetDepth))
                {
                    var unmarshaller = ExternalAccessDetailsUnmarshaller.Instance;
                    unmarshalledObject.ExternalAccessDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("internalAccessDetails", targetDepth))
                {
                    var unmarshaller = InternalAccessDetailsUnmarshaller.Instance;
                    unmarshalledObject.InternalAccessDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unusedIamRoleDetails", targetDepth))
                {
                    var unmarshaller = UnusedIamRoleDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnusedIamRoleDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unusedIamUserAccessKeyDetails", targetDepth))
                {
                    var unmarshaller = UnusedIamUserAccessKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnusedIamUserAccessKeyDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unusedIamUserPasswordDetails", targetDepth))
                {
                    var unmarshaller = UnusedIamUserPasswordDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnusedIamUserPasswordDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("unusedPermissionDetails", targetDepth))
                {
                    var unmarshaller = UnusedPermissionDetailsUnmarshaller.Instance;
                    unmarshalledObject.UnusedPermissionDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FindingDetailsUnmarshaller _instance = new FindingDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}