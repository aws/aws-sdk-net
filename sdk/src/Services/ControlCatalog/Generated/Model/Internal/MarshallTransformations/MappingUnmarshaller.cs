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
 * Do not modify this file. This file is generated from the controlcatalog-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ControlCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Mapping Object
    /// </summary>  
    public class MappingUnmarshaller : IUnmarshaller<Mapping, XmlUnmarshallerContext>, IUnmarshaller<Mapping, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Mapping IUnmarshaller<Mapping, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Mapping Unmarshall(JsonUnmarshallerContext context)
        {
            Mapping unmarshalledObject = new Mapping();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CommonControl", targetDepth))
                {
                    var unmarshaller = CommonControlMappingDetailsUnmarshaller.Instance;
                    unmarshalledObject.CommonControl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Framework", targetDepth))
                {
                    var unmarshaller = FrameworkMappingDetailsUnmarshaller.Instance;
                    unmarshalledObject.Framework = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MappingUnmarshaller _instance = new MappingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MappingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}