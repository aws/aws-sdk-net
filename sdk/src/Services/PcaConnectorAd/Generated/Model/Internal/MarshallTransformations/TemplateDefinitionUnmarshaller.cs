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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TemplateDefinition Object
    /// </summary>  
    public class TemplateDefinitionUnmarshaller : IUnmarshaller<TemplateDefinition, XmlUnmarshallerContext>, IUnmarshaller<TemplateDefinition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TemplateDefinition IUnmarshaller<TemplateDefinition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TemplateDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TemplateDefinition unmarshalledObject = new TemplateDefinition();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("TemplateV2", targetDepth))
                {
                    var unmarshaller = TemplateV2Unmarshaller.Instance;
                    unmarshalledObject.TemplateV2 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemplateV3", targetDepth))
                {
                    var unmarshaller = TemplateV3Unmarshaller.Instance;
                    unmarshalledObject.TemplateV3 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TemplateV4", targetDepth))
                {
                    var unmarshaller = TemplateV4Unmarshaller.Instance;
                    unmarshalledObject.TemplateV4 = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TemplateDefinitionUnmarshaller _instance = new TemplateDefinitionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}