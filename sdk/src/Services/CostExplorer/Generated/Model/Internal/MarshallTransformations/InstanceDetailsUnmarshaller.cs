/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceDetails Object
    /// </summary>  
    public class InstanceDetailsUnmarshaller : IUnmarshaller<InstanceDetails, XmlUnmarshallerContext>, IUnmarshaller<InstanceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceDetails IUnmarshaller<InstanceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InstanceDetails unmarshalledObject = new InstanceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("EC2InstanceDetails", targetDepth))
                {
                    var unmarshaller = EC2InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.EC2InstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ElastiCacheInstanceDetails", targetDepth))
                {
                    var unmarshaller = ElastiCacheInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ElastiCacheInstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ESInstanceDetails", targetDepth))
                {
                    var unmarshaller = ESInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.ESInstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RDSInstanceDetails", targetDepth))
                {
                    var unmarshaller = RDSInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.RDSInstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RedshiftInstanceDetails", targetDepth))
                {
                    var unmarshaller = RedshiftInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.RedshiftInstanceDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InstanceDetailsUnmarshaller _instance = new InstanceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}