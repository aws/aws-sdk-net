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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InlineRedactionConfiguration Object
    /// </summary>  
    public class InlineRedactionConfigurationUnmarshaller : IUnmarshaller<InlineRedactionConfiguration, XmlUnmarshallerContext>, IUnmarshaller<InlineRedactionConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InlineRedactionConfiguration IUnmarshaller<InlineRedactionConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InlineRedactionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            InlineRedactionConfiguration unmarshalledObject = new InlineRedactionConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("globalConfidenceLevel", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.GlobalConfidenceLevel = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("globalEnforcedUrls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GlobalEnforcedUrls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("globalExemptUrls", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GlobalExemptUrls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inlineRedactionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<InlineRedactionPattern, InlineRedactionPatternUnmarshaller>(InlineRedactionPatternUnmarshaller.Instance);
                    unmarshalledObject.InlineRedactionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InlineRedactionConfigurationUnmarshaller _instance = new InlineRedactionConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InlineRedactionConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}