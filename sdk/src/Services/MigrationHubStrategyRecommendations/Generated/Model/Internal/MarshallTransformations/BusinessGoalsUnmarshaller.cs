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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHubStrategyRecommendations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MigrationHubStrategyRecommendations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BusinessGoals Object
    /// </summary>  
    public class BusinessGoalsUnmarshaller : IUnmarshaller<BusinessGoals, XmlUnmarshallerContext>, IUnmarshaller<BusinessGoals, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        BusinessGoals IUnmarshaller<BusinessGoals, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BusinessGoals Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            BusinessGoals unmarshalledObject = new BusinessGoals();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("licenseCostReduction", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.LicenseCostReduction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("modernizeInfrastructureWithCloudNativeTechnologies", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ModernizeInfrastructureWithCloudNativeTechnologies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("reduceOperationalOverheadWithManagedServices", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ReduceOperationalOverheadWithManagedServices = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("speedOfMigration", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SpeedOfMigration = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static BusinessGoalsUnmarshaller _instance = new BusinessGoalsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BusinessGoalsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}