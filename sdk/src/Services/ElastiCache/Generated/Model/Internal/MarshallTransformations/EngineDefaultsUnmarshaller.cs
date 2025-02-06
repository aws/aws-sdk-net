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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EngineDefaults Object
    /// </summary>  
    public class EngineDefaultsUnmarshaller : IXmlUnmarshaller<EngineDefaults, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EngineDefaults Unmarshall(XmlUnmarshallerContext context)
        {
            EngineDefaults unmarshalledObject = new EngineDefaults();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CacheNodeTypeSpecificParameters/CacheNodeTypeSpecificParameter", targetDepth))
                    {
                        var unmarshaller = CacheNodeTypeSpecificParameterUnmarshaller.Instance;
                        if (unmarshalledObject.CacheNodeTypeSpecificParameters == null)
                        {
                            unmarshalledObject.CacheNodeTypeSpecificParameters = new List<CacheNodeTypeSpecificParameter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CacheNodeTypeSpecificParameters.Add(item);
                        continue;
                    }
                    if (context.TestExpression("CacheParameterGroupFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CacheParameterGroupFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Marker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Parameters/Parameter", targetDepth))
                    {
                        var unmarshaller = ParameterUnmarshaller.Instance;
                        if (unmarshalledObject.Parameters == null)
                        {
                            unmarshalledObject.Parameters = new List<Parameter>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Parameters.Add(item);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static EngineDefaultsUnmarshaller _instance = new EngineDefaultsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EngineDefaultsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}