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

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrganizationStatistics Object
    /// </summary>  
    public class OrganizationStatisticsUnmarshaller : IUnmarshaller<OrganizationStatistics, XmlUnmarshallerContext>, IUnmarshaller<OrganizationStatistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OrganizationStatistics IUnmarshaller<OrganizationStatistics, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OrganizationStatistics Unmarshall(JsonUnmarshallerContext context)
        {
            OrganizationStatistics unmarshalledObject = new OrganizationStatistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("activeAccountsCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ActiveAccountsCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("countByFeature", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<OrganizationFeatureStatistics, OrganizationFeatureStatisticsUnmarshaller>(OrganizationFeatureStatisticsUnmarshaller.Instance);
                    unmarshalledObject.CountByFeature = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("enabledAccountsCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EnabledAccountsCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memberAccountsCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MemberAccountsCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("totalAccountsCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TotalAccountsCount = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OrganizationStatisticsUnmarshaller _instance = new OrganizationStatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrganizationStatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}