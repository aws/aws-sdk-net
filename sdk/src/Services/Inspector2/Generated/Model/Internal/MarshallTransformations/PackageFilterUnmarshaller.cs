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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PackageFilter Object
    /// </summary>  
    public class PackageFilterUnmarshaller : IUnmarshaller<PackageFilter, XmlUnmarshallerContext>, IUnmarshaller<PackageFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PackageFilter IUnmarshaller<PackageFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PackageFilter Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PackageFilter unmarshalledObject = new PackageFilter();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("architecture", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("epoch", targetDepth))
                {
                    var unmarshaller = NumberFilterUnmarshaller.Instance;
                    unmarshalledObject.Epoch = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("release", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.Release = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceLambdaLayerArn", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.SourceLambdaLayerArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceLayerHash", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.SourceLayerHash = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("version", targetDepth))
                {
                    var unmarshaller = StringFilterUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PackageFilterUnmarshaller _instance = new PackageFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PackageFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}