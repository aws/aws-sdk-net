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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BatchPermissionsRequestEntry Object
    /// </summary>  
    public class BatchPermissionsRequestEntryUnmarshaller : IUnmarshaller<BatchPermissionsRequestEntry, XmlUnmarshallerContext>, IUnmarshaller<BatchPermissionsRequestEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BatchPermissionsRequestEntry IUnmarshaller<BatchPermissionsRequestEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BatchPermissionsRequestEntry Unmarshall(JsonUnmarshallerContext context)
        {
            BatchPermissionsRequestEntry unmarshalledObject = new BatchPermissionsRequestEntry();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Condition", targetDepth))
                {
                    var unmarshaller = ConditionUnmarshaller.Instance;
                    unmarshalledObject.Condition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Permissions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Permissions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PermissionsWithGrantOption", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PermissionsWithGrantOption = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Principal", targetDepth))
                {
                    var unmarshaller = DataLakePrincipalUnmarshaller.Instance;
                    unmarshalledObject.Principal = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Resource", targetDepth))
                {
                    var unmarshaller = ResourceUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BatchPermissionsRequestEntryUnmarshaller _instance = new BatchPermissionsRequestEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchPermissionsRequestEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}