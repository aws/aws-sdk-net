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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudTrail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AggregationConfiguration Object
    /// </summary>  
    public class AggregationConfigurationUnmarshaller : IUnmarshaller<AggregationConfiguration, XmlUnmarshallerContext>, IUnmarshaller<AggregationConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AggregationConfiguration IUnmarshaller<AggregationConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AggregationConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            AggregationConfiguration unmarshalledObject = new AggregationConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EventCategory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Templates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Templates = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AggregationConfigurationUnmarshaller _instance = new AggregationConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AggregationConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}