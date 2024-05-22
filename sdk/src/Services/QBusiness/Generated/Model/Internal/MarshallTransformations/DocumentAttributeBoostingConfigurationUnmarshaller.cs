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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DocumentAttributeBoostingConfiguration Object
    /// </summary>  
    public class DocumentAttributeBoostingConfigurationUnmarshaller : IUnmarshaller<DocumentAttributeBoostingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<DocumentAttributeBoostingConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DocumentAttributeBoostingConfiguration IUnmarshaller<DocumentAttributeBoostingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public DocumentAttributeBoostingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            DocumentAttributeBoostingConfiguration unmarshalledObject = new DocumentAttributeBoostingConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dateConfiguration", targetDepth))
                {
                    var unmarshaller = DateAttributeBoostingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.DateConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numberConfiguration", targetDepth))
                {
                    var unmarshaller = NumberAttributeBoostingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.NumberConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stringConfiguration", targetDepth))
                {
                    var unmarshaller = StringAttributeBoostingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StringConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stringListConfiguration", targetDepth))
                {
                    var unmarshaller = StringListAttributeBoostingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StringListConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DocumentAttributeBoostingConfigurationUnmarshaller _instance = new DocumentAttributeBoostingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DocumentAttributeBoostingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}