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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for License Object
    /// </summary>  
    public class LicenseUnmarshaller : IUnmarshaller<License, XmlUnmarshallerContext>, IUnmarshaller<License, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        License IUnmarshaller<License, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public License Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            License unmarshalledObject = new License();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Beneficiary", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Beneficiary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConsumptionConfiguration", targetDepth))
                {
                    var unmarshaller = ConsumptionConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ConsumptionConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateTime", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Entitlements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Entitlement, EntitlementUnmarshaller>(EntitlementUnmarshaller.Instance);
                    unmarshalledObject.Entitlements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HomeRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HomeRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Issuer", targetDepth))
                {
                    var unmarshaller = IssuerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Issuer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseMetadata", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Metadata, MetadataUnmarshaller>(MetadataUnmarshaller.Instance);
                    unmarshalledObject.LicenseMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductSKU", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductSKU = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Validity", targetDepth))
                {
                    var unmarshaller = DatetimeRangeUnmarshaller.Instance;
                    unmarshalledObject.Validity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static LicenseUnmarshaller _instance = new LicenseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LicenseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}