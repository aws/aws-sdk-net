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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Finding Object
    /// </summary>  
    public class FindingUnmarshaller : IUnmarshaller<Finding, XmlUnmarshallerContext>, IUnmarshaller<Finding, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Finding IUnmarshaller<Finding, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Finding Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Finding unmarshalledObject = new Finding();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetAttributes", targetDepth))
                {
                    var unmarshaller = AssetAttributesUnmarshaller.Instance;
                    unmarshalledObject.AssetAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("assetType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssetType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("attributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Attribute, AttributeUnmarshaller>(AttributeUnmarshaller.Instance);
                    unmarshalledObject.Attributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("confidence", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("indicatorOfCompromise", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.IndicatorOfCompromise = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("numericSeverity", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.NumericSeverity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("recommendation", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Recommendation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("schemaVersion", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.SchemaVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("service", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Service = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceAttributes", targetDepth))
                {
                    var unmarshaller = InspectorServiceAttributesUnmarshaller.Instance;
                    unmarshalledObject.ServiceAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("severity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("updatedAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("userAttributes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Attribute, AttributeUnmarshaller>(AttributeUnmarshaller.Instance);
                    unmarshalledObject.UserAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FindingUnmarshaller _instance = new FindingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}