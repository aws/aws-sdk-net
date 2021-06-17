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
    /// Response Unmarshaller for Urls Object
    /// </summary>  
    public class UrlsUnmarshaller : IUnmarshaller<Urls, XmlUnmarshallerContext>, IUnmarshaller<Urls, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Urls IUnmarshaller<Urls, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Urls Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Urls unmarshalledObject = new Urls();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("SeedUrlConfiguration", targetDepth))
                {
                    var unmarshaller = SeedUrlConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SeedUrlConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SiteMapsConfiguration", targetDepth))
                {
                    var unmarshaller = SiteMapsConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SiteMapsConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static UrlsUnmarshaller _instance = new UrlsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UrlsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}