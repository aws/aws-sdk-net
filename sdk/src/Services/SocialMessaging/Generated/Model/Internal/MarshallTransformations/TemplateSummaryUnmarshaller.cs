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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TemplateSummary Object
    /// </summary>  
    public class TemplateSummaryUnmarshaller : IUnmarshaller<TemplateSummary, XmlUnmarshallerContext>, IUnmarshaller<TemplateSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TemplateSummary IUnmarshaller<TemplateSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TemplateSummary Unmarshall(JsonUnmarshallerContext context)
        {
            TemplateSummary unmarshalledObject = new TemplateSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("metaTemplateId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetaTemplateId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateCategory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateLanguage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateLanguage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateQualityScore", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateQualityScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("templateStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TemplateStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TemplateSummaryUnmarshaller _instance = new TemplateSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TemplateSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}