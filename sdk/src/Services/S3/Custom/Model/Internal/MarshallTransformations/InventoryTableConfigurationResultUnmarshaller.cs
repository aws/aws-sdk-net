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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InventoryTableConfigurationResult Object
    /// </summary>  
    public class InventoryTableConfigurationResultUnmarshaller : IUnmarshaller<InventoryTableConfigurationResult, XmlUnmarshallerContext>, IUnmarshaller<InventoryTableConfigurationResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InventoryTableConfigurationResult Unmarshall(XmlUnmarshallerContext context)
        {
            InventoryTableConfigurationResult unmarshalledObject = new InventoryTableConfigurationResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ConfigurationState", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ConfigurationState = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Error", targetDepth))
                    {
                        var unmarshaller = ErrorUnmarshaller.Instance;
                        unmarshalledObject.Error = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TableArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TableName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TableStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TableStatus = unmarshaller.Unmarshall(context);
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
        
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InventoryTableConfigurationResult Unmarshall(JsonUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        private static InventoryTableConfigurationResultUnmarshaller _instance = new InventoryTableConfigurationResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InventoryTableConfigurationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}