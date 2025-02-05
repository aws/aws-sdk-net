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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CustomDocumentEnrichmentConfiguration Object
    /// </summary>  
    public class CustomDocumentEnrichmentConfigurationUnmarshaller : IJsonUnmarshaller<CustomDocumentEnrichmentConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CustomDocumentEnrichmentConfiguration Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CustomDocumentEnrichmentConfiguration unmarshalledObject = new CustomDocumentEnrichmentConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("InlineConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InlineCustomDocumentEnrichmentConfiguration, InlineCustomDocumentEnrichmentConfigurationUnmarshaller>(InlineCustomDocumentEnrichmentConfigurationUnmarshaller.Instance);
                    unmarshalledObject.InlineConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PostExtractionHookConfiguration", targetDepth))
                {
                    var unmarshaller = HookConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PostExtractionHookConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PreExtractionHookConfiguration", targetDepth))
                {
                    var unmarshaller = HookConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PreExtractionHookConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context, ref reader);
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