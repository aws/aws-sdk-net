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
    /// Response Unmarshaller for SalesforceConfiguration Object
    /// </summary>  
    public class SalesforceConfigurationUnmarshaller : IUnmarshaller<SalesforceConfiguration, XmlUnmarshallerContext>, IUnmarshaller<SalesforceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SalesforceConfiguration IUnmarshaller<SalesforceConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SalesforceConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SalesforceConfiguration unmarshalledObject = new SalesforceConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ChatterFeedConfiguration", targetDepth))
                {
                    var unmarshaller = SalesforceChatterFeedConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ChatterFeedConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CrawlAttachments", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CrawlAttachments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludeAttachmentFilePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExcludeAttachmentFilePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IncludeAttachmentFilePatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.IncludeAttachmentFilePatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("KnowledgeArticleConfiguration", targetDepth))
                {
                    var unmarshaller = SalesforceKnowledgeArticleConfigurationUnmarshaller.Instance;
                    unmarshalledObject.KnowledgeArticleConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SecretArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SecretArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServerUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StandardObjectAttachmentConfiguration", targetDepth))
                {
                    var unmarshaller = SalesforceStandardObjectAttachmentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.StandardObjectAttachmentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StandardObjectConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<SalesforceStandardObjectConfiguration, SalesforceStandardObjectConfigurationUnmarshaller>(SalesforceStandardObjectConfigurationUnmarshaller.Instance);
                    unmarshalledObject.StandardObjectConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SalesforceConfigurationUnmarshaller _instance = new SalesforceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SalesforceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}