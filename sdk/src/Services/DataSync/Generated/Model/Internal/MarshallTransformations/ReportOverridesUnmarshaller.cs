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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReportOverrides Object
    /// </summary>  
    public class ReportOverridesUnmarshaller : IUnmarshaller<ReportOverrides, XmlUnmarshallerContext>, IUnmarshaller<ReportOverrides, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ReportOverrides IUnmarshaller<ReportOverrides, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReportOverrides Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ReportOverrides unmarshalledObject = new ReportOverrides();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Deleted", targetDepth))
                {
                    var unmarshaller = ReportOverrideUnmarshaller.Instance;
                    unmarshalledObject.Deleted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Skipped", targetDepth))
                {
                    var unmarshaller = ReportOverrideUnmarshaller.Instance;
                    unmarshalledObject.Skipped = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Transferred", targetDepth))
                {
                    var unmarshaller = ReportOverrideUnmarshaller.Instance;
                    unmarshalledObject.Transferred = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Verified", targetDepth))
                {
                    var unmarshaller = ReportOverrideUnmarshaller.Instance;
                    unmarshalledObject.Verified = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ReportOverridesUnmarshaller _instance = new ReportOverridesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReportOverridesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}