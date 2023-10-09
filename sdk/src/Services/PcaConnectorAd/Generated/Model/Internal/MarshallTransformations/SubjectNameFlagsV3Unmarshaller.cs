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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SubjectNameFlagsV3 Object
    /// </summary>  
    public class SubjectNameFlagsV3Unmarshaller : IUnmarshaller<SubjectNameFlagsV3, XmlUnmarshallerContext>, IUnmarshaller<SubjectNameFlagsV3, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SubjectNameFlagsV3 IUnmarshaller<SubjectNameFlagsV3, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SubjectNameFlagsV3 Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SubjectNameFlagsV3 unmarshalledObject = new SubjectNameFlagsV3();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RequireCommonName", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireCommonName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireDirectoryPath", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireDirectoryPath = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireDnsAsCn", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireDnsAsCn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequireEmail", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequireEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireDirectoryGuid", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireDirectoryGuid = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireDns", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireDns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireDomainDns", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireDomainDns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireEmail", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireEmail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireSpn", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireSpn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SanRequireUpn", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SanRequireUpn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SubjectNameFlagsV3Unmarshaller _instance = new SubjectNameFlagsV3Unmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SubjectNameFlagsV3Unmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}