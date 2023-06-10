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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DatasetDetailOrgAttributes Object
    /// </summary>  
    public class DatasetDetailOrgAttributesUnmarshaller : IUnmarshaller<DatasetDetailOrgAttributes, XmlUnmarshallerContext>, IUnmarshaller<DatasetDetailOrgAttributes, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DatasetDetailOrgAttributes IUnmarshaller<DatasetDetailOrgAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DatasetDetailOrgAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DatasetDetailOrgAttributes unmarshalledObject = new DatasetDetailOrgAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("gdg", targetDepth))
                {
                    var unmarshaller = GdgDetailAttributesUnmarshaller.Instance;
                    unmarshalledObject.Gdg = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("po", targetDepth))
                {
                    var unmarshaller = PoDetailAttributesUnmarshaller.Instance;
                    unmarshalledObject.Po = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ps", targetDepth))
                {
                    var unmarshaller = PsDetailAttributesUnmarshaller.Instance;
                    unmarshalledObject.Ps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vsam", targetDepth))
                {
                    var unmarshaller = VsamDetailAttributesUnmarshaller.Instance;
                    unmarshalledObject.Vsam = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DatasetDetailOrgAttributesUnmarshaller _instance = new DatasetDetailOrgAttributesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatasetDetailOrgAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}