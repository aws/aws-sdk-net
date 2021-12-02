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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomDocumentEnrichmentConfiguration Object
    /// </summary>  
    public class CustomDocumentEnrichmentConfigurationUnmarshaller : IUnmarshaller<CustomDocumentEnrichmentConfiguration, XmlUnmarshallerContext>, IUnmarshaller<CustomDocumentEnrichmentConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CustomDocumentEnrichmentConfiguration IUnmarshaller<CustomDocumentEnrichmentConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomDocumentEnrichmentConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CustomDocumentEnrichmentConfiguration unmarshalledObject = new CustomDocumentEnrichmentConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("InlineConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InlineCustomDocumentEnrichmentConfiguration, InlineCustomDocumentEnrichmentConfigurationUnmarshaller>(InlineCustomDocumentEnrichmentConfigurationUnmarshaller.Instance);
                    unmarshalledObject.InlineConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostExtractionHookConfiguration", targetDepth))
                {
                    var unmarshaller = HookConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PostExtractionHookConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreExtractionHookConfiguration", targetDepth))
                {
                    var unmarshaller = HookConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PreExtractionHookConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CustomDocumentEnrichmentConfigurationUnmarshaller _instance = new CustomDocumentEnrichmentConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomDocumentEnrichmentConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}