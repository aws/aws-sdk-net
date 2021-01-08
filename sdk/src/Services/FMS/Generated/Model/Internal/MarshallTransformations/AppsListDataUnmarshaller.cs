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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AppsListData Object
    /// </summary>  
    public class AppsListDataUnmarshaller : IUnmarshaller<AppsListData, XmlUnmarshallerContext>, IUnmarshaller<AppsListData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AppsListData IUnmarshaller<AppsListData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AppsListData Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AppsListData unmarshalledObject = new AppsListData();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AppsList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<App, AppUnmarshaller>(AppUnmarshaller.Instance);
                    unmarshalledObject.AppsList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ListUpdateToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListUpdateToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreviousAppsList", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<App>, StringUnmarshaller, ListUnmarshaller<App, AppUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<App, AppUnmarshaller>(AppUnmarshaller.Instance));
                    unmarshalledObject.PreviousAppsList = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AppsListDataUnmarshaller _instance = new AppsListDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AppsListDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}