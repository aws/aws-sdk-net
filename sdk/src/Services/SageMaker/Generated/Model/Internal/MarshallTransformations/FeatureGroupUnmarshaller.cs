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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FeatureGroup Object
    /// </summary>  
    public class FeatureGroupUnmarshaller : IUnmarshaller<FeatureGroup, XmlUnmarshallerContext>, IUnmarshaller<FeatureGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FeatureGroup IUnmarshaller<FeatureGroup, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FeatureGroup Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FeatureGroup unmarshalledObject = new FeatureGroup();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EventTimeFeatureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EventTimeFeatureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureDefinitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FeatureDefinition, FeatureDefinitionUnmarshaller>(FeatureDefinitionUnmarshaller.Instance);
                    unmarshalledObject.FeatureDefinitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeatureGroupArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeatureGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FeatureGroupStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FeatureGroupStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfflineStoreConfig", targetDepth))
                {
                    var unmarshaller = OfflineStoreConfigUnmarshaller.Instance;
                    unmarshalledObject.OfflineStoreConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfflineStoreStatus", targetDepth))
                {
                    var unmarshaller = OfflineStoreStatusUnmarshaller.Instance;
                    unmarshalledObject.OfflineStoreStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnlineStoreConfig", targetDepth))
                {
                    var unmarshaller = OnlineStoreConfigUnmarshaller.Instance;
                    unmarshalledObject.OnlineStoreConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecordIdentifierFeatureName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RecordIdentifierFeatureName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Tags", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FeatureGroupUnmarshaller _instance = new FeatureGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FeatureGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}