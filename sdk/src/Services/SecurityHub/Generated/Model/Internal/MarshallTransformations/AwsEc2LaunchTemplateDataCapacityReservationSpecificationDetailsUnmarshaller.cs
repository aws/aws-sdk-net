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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails Object
    /// </summary>  
    public class AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsUnmarshaller : IUnmarshaller<AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails, XmlUnmarshallerContext>, IUnmarshaller<AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails IUnmarshaller<AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails unmarshalledObject = new AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CapacityReservationPreference", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationPreference = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CapacityReservationTarget", targetDepth))
                {
                    var unmarshaller = AwsEc2LaunchTemplateDataCapacityReservationSpecificationCapacityReservationTargetDetailsUnmarshaller.Instance;
                    unmarshalledObject.CapacityReservationTarget = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsUnmarshaller _instance = new AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}