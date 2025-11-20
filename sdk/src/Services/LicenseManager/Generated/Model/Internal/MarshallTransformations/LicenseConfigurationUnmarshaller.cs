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

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LicenseConfiguration Object
    /// </summary>  
    public class LicenseConfigurationUnmarshaller : IUnmarshaller<LicenseConfiguration, XmlUnmarshallerContext>, IUnmarshaller<LicenseConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LicenseConfiguration IUnmarshaller<LicenseConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LicenseConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            LicenseConfiguration unmarshalledObject = new LicenseConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AutomatedDiscoveryInformation", targetDepth))
                {
                    var unmarshaller = AutomatedDiscoveryInformationUnmarshaller.Instance;
                    unmarshalledObject.AutomatedDiscoveryInformation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConsumedLicenses", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.ConsumedLicenses = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConsumedLicenseSummaryList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ConsumedLicenseSummary, ConsumedLicenseSummaryUnmarshaller>(ConsumedLicenseSummaryUnmarshaller.Instance);
                    unmarshalledObject.ConsumedLicenseSummaryList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisassociateWhenNotFound", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisassociateWhenNotFound = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseConfigurationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseConfigurationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseCount", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LicenseCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseCountHardLimit", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.LicenseCountHardLimit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseCountingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LicenseCountingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseExpiry", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LicenseExpiry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LicenseRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.LicenseRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManagedResourceSummaryList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ManagedResourceSummary, ManagedResourceSummaryUnmarshaller>(ManagedResourceSummaryUnmarshaller.Instance);
                    unmarshalledObject.ManagedResourceSummaryList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwnerAccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductInformationList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProductInformation, ProductInformationUnmarshaller>(ProductInformationUnmarshaller.Instance);
                    unmarshalledObject.ProductInformationList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LicenseConfigurationUnmarshaller _instance = new LicenseConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LicenseConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}