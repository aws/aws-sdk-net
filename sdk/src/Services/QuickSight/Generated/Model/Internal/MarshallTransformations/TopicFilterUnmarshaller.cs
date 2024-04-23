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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TopicFilter Object
    /// </summary>  
    public class TopicFilterUnmarshaller : IUnmarshaller<TopicFilter, XmlUnmarshallerContext>, IUnmarshaller<TopicFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TopicFilter IUnmarshaller<TopicFilter, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TopicFilter Unmarshall(JsonUnmarshallerContext context)
        {
            TopicFilter unmarshalledObject = new TopicFilter();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CategoryFilter", targetDepth))
                {
                    var unmarshaller = TopicCategoryFilterUnmarshaller.Instance;
                    unmarshalledObject.CategoryFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DateRangeFilter", targetDepth))
                {
                    var unmarshaller = TopicDateRangeFilterUnmarshaller.Instance;
                    unmarshalledObject.DateRangeFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterClass", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterClass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterSynonyms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.FilterSynonyms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FilterType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumericEqualityFilter", targetDepth))
                {
                    var unmarshaller = TopicNumericEqualityFilterUnmarshaller.Instance;
                    unmarshalledObject.NumericEqualityFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumericRangeFilter", targetDepth))
                {
                    var unmarshaller = TopicNumericRangeFilterUnmarshaller.Instance;
                    unmarshalledObject.NumericRangeFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OperandFieldName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OperandFieldName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelativeDateFilter", targetDepth))
                {
                    var unmarshaller = TopicRelativeDateFilterUnmarshaller.Instance;
                    unmarshalledObject.RelativeDateFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TopicFilterUnmarshaller _instance = new TopicFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TopicFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618