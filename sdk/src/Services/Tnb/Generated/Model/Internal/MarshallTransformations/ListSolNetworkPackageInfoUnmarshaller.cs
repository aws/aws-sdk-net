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
 * Do not modify this file. This file is generated from the tnb-2008-10-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Tnb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Tnb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListSolNetworkPackageInfo Object
    /// </summary>  
    public class ListSolNetworkPackageInfoUnmarshaller : IUnmarshaller<ListSolNetworkPackageInfo, XmlUnmarshallerContext>, IUnmarshaller<ListSolNetworkPackageInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ListSolNetworkPackageInfo IUnmarshaller<ListSolNetworkPackageInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListSolNetworkPackageInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ListSolNetworkPackageInfo unmarshalledObject = new ListSolNetworkPackageInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metadata", targetDepth))
                {
                    var unmarshaller = ListSolNetworkPackageMetadataUnmarshaller.Instance;
                    unmarshalledObject.Metadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdDesigner", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdDesigner = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdInvariantId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdInvariantId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdOnboardingState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdOnboardingState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdOperationalState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdOperationalState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdUsageState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdUsageState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("nsdVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NsdVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vnfPkgIds", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.VnfPkgIds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ListSolNetworkPackageInfoUnmarshaller _instance = new ListSolNetworkPackageInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSolNetworkPackageInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}