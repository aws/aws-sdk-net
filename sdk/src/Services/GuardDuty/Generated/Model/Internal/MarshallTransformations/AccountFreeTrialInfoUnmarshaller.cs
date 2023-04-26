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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AccountFreeTrialInfo Object
    /// </summary>  
    public class AccountFreeTrialInfoUnmarshaller : IUnmarshaller<AccountFreeTrialInfo, XmlUnmarshallerContext>, IUnmarshaller<AccountFreeTrialInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AccountFreeTrialInfo IUnmarshaller<AccountFreeTrialInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AccountFreeTrialInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AccountFreeTrialInfo unmarshalledObject = new AccountFreeTrialInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dataSources", targetDepth))
                {
                    var unmarshaller = DataSourcesFreeTrialUnmarshaller.Instance;
                    unmarshalledObject.DataSources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("features", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FreeTrialFeatureConfigurationResult, FreeTrialFeatureConfigurationResultUnmarshaller>(FreeTrialFeatureConfigurationResultUnmarshaller.Instance);
                    unmarshalledObject.Features = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AccountFreeTrialInfoUnmarshaller _instance = new AccountFreeTrialInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AccountFreeTrialInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}