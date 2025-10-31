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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ParentChildFieldOptionsMapping Object
    /// </summary>  
    public class ParentChildFieldOptionsMappingUnmarshaller : IUnmarshaller<ParentChildFieldOptionsMapping, XmlUnmarshallerContext>, IUnmarshaller<ParentChildFieldOptionsMapping, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ParentChildFieldOptionsMapping IUnmarshaller<ParentChildFieldOptionsMapping, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ParentChildFieldOptionsMapping Unmarshall(JsonUnmarshallerContext context)
        {
            ParentChildFieldOptionsMapping unmarshalledObject = new ParentChildFieldOptionsMapping();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("childFieldOptionValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ChildFieldOptionValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parentFieldOptionValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ParentFieldOptionValue = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ParentChildFieldOptionsMappingUnmarshaller _instance = new ParentChildFieldOptionsMappingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ParentChildFieldOptionsMappingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}