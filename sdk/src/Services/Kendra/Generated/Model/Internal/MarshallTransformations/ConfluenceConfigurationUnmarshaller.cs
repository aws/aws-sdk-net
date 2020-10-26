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
    /// Response Unmarshaller for ConfluenceConfiguration Object
    /// </summary>  
    public class ConfluenceConfigurationUnmarshaller : IUnmarshaller<ConfluenceConfiguration, XmlUnmarshallerContext>, IUnmarshaller<ConfluenceConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ConfluenceConfiguration IUnmarshaller<ConfluenceConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ConfluenceConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ConfluenceConfiguration unmarshalledObject = new ConfluenceConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AttachmentConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluenceAttachmentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AttachmentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("BlogConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluenceBlogConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BlogConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InclusionPatterns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InclusionPatterns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PageConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluencePageConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PageConfiguration = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("SpaceConfiguration", targetDepth))
                {
                    var unmarshaller = ConfluenceSpaceConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SpaceConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcConfiguration", targetDepth))
                {
                    var unmarshaller = DataSourceVpcConfigurationUnmarshaller.Instance;
                    unmarshalledObject.VpcConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ConfluenceConfigurationUnmarshaller _instance = new ConfluenceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfluenceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}