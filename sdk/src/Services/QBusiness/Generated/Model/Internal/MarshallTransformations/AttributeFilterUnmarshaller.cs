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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AttributeFilter Object
    /// </summary>  
    public class AttributeFilterUnmarshaller : IJsonUnmarshaller<AttributeFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AttributeFilter Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AttributeFilter unmarshalledObject = new AttributeFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("andAllFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttributeFilter, AttributeFilterUnmarshaller>(AttributeFilterUnmarshaller.Instance);
                    unmarshalledObject.AndAllFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containsAll", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.ContainsAll = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containsAny", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.ContainsAny = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("equalsTo", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.EqualsTo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThan", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.GreaterThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("greaterThanOrEquals", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.GreaterThanOrEquals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThan", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.LessThan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lessThanOrEquals", targetDepth))
                {
                    var unmarshaller = DocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.LessThanOrEquals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("notFilter", targetDepth))
                {
                    var unmarshaller = AttributeFilterUnmarshaller.Instance;
                    unmarshalledObject.NotFilter = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("orAllFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AttributeFilter, AttributeFilterUnmarshaller>(AttributeFilterUnmarshaller.Instance);
                    unmarshalledObject.OrAllFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AttributeFilterUnmarshaller _instance = new AttributeFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AttributeFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}