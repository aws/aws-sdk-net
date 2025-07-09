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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CompositeFilter Object
    /// </summary>  
    public class CompositeFilterUnmarshaller : IJsonUnmarshaller<CompositeFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CompositeFilter Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CompositeFilter unmarshalledObject = new CompositeFilter();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BooleanFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OcsfBooleanFilter, OcsfBooleanFilterUnmarshaller>(OcsfBooleanFilterUnmarshaller.Instance);
                    unmarshalledObject.BooleanFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DateFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OcsfDateFilter, OcsfDateFilterUnmarshaller>(OcsfDateFilterUnmarshaller.Instance);
                    unmarshalledObject.DateFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MapFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OcsfMapFilter, OcsfMapFilterUnmarshaller>(OcsfMapFilterUnmarshaller.Instance);
                    unmarshalledObject.MapFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumberFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OcsfNumberFilter, OcsfNumberFilterUnmarshaller>(OcsfNumberFilterUnmarshaller.Instance);
                    unmarshalledObject.NumberFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Operator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Operator = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StringFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<OcsfStringFilter, OcsfStringFilterUnmarshaller>(OcsfStringFilterUnmarshaller.Instance);
                    unmarshalledObject.StringFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CompositeFilterUnmarshaller _instance = new CompositeFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CompositeFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}