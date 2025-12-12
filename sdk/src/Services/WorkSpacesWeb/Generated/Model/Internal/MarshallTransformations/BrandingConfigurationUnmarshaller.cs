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
    /// Response Unmarshaller for BrandingConfiguration Object
    /// </summary>  
    public class BrandingConfigurationUnmarshaller : IUnmarshaller<BrandingConfiguration, XmlUnmarshallerContext>, IUnmarshaller<BrandingConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BrandingConfiguration IUnmarshaller<BrandingConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public BrandingConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            BrandingConfiguration unmarshalledObject = new BrandingConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("colorTheme", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ColorTheme = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("favicon", targetDepth))
                {
                    var unmarshaller = ImageMetadataUnmarshaller.Instance;
                    unmarshalledObject.Favicon = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localizedStrings", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, LocalizedBrandingStrings, StringUnmarshaller, LocalizedBrandingStringsUnmarshaller>(StringUnmarshaller.Instance, LocalizedBrandingStringsUnmarshaller.Instance);
                    unmarshalledObject.LocalizedStrings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logo", targetDepth))
                {
                    var unmarshaller = ImageMetadataUnmarshaller.Instance;
                    unmarshalledObject.Logo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("termsOfService", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TermsOfService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("wallpaper", targetDepth))
                {
                    var unmarshaller = ImageMetadataUnmarshaller.Instance;
                    unmarshalledObject.Wallpaper = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static BrandingConfigurationUnmarshaller _instance = new BrandingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BrandingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}