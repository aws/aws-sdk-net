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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BodySectionConfiguration Object
    /// </summary>  
    public class BodySectionConfigurationUnmarshaller : IUnmarshaller<BodySectionConfiguration, XmlUnmarshallerContext>, IUnmarshaller<BodySectionConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BodySectionConfiguration IUnmarshaller<BodySectionConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BodySectionConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BodySectionConfiguration unmarshalledObject = new BodySectionConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Content", targetDepth))
                {
                    var unmarshaller = BodySectionContentUnmarshaller.Instance;
                    unmarshalledObject.Content = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PageBreakConfiguration", targetDepth))
                {
                    var unmarshaller = SectionPageBreakConfigurationUnmarshaller.Instance;
                    unmarshalledObject.PageBreakConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SectionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SectionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Style", targetDepth))
                {
                    var unmarshaller = SectionStyleUnmarshaller.Instance;
                    unmarshalledObject.Style = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BodySectionConfigurationUnmarshaller _instance = new BodySectionConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BodySectionConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}