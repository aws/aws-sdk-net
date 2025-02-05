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
    /// Response Unmarshaller for CacheNodeTypeSpecificParameter Object
    /// </summary>  
    public class CacheNodeTypeSpecificParameterUnmarshaller : IXmlUnmarshaller<CacheNodeTypeSpecificParameter, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CacheNodeTypeSpecificParameter Unmarshall(XmlUnmarshallerContext context)
        {
            CacheNodeTypeSpecificParameter unmarshalledObject = new CacheNodeTypeSpecificParameter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedValues", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AllowedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CacheNodeTypeSpecificValues/CacheNodeTypeSpecificValue", targetDepth))
                    {
                        var unmarshaller = CacheNodeTypeSpecificValueUnmarshaller.Instance;
                        if (unmarshalledObject.CacheNodeTypeSpecificValues == null)
                        {
                            unmarshalledObject.CacheNodeTypeSpecificValues = new List<CacheNodeTypeSpecificValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.CacheNodeTypeSpecificValues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ChangeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChangeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DataType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("IsModifiable", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.IsModifiable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinimumEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MinimumEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ParameterName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ParameterName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Source", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Source = unmarshaller.Unmarshall(context);
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

        private static CacheNodeTypeSpecificParameterUnmarshaller _instance = new CacheNodeTypeSpecificParameterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CacheNodeTypeSpecificParameterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}