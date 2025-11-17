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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAAServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAAServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DefinitionS3Location Object
    /// </summary>  
    public class DefinitionS3LocationUnmarshaller : IUnmarshaller<DefinitionS3Location, XmlUnmarshallerContext>, IUnmarshaller<DefinitionS3Location, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DefinitionS3Location IUnmarshaller<DefinitionS3Location, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DefinitionS3Location Unmarshall(JsonUnmarshallerContext context)
        {
            DefinitionS3Location unmarshalledObject = new DefinitionS3Location();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Bucket", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ObjectKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VersionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VersionId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DefinitionS3LocationUnmarshaller _instance = new DefinitionS3LocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DefinitionS3LocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}