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
    /// Response Unmarshaller for MetadataConfigurationResult Object
    /// </summary>  
    public class MetadataConfigurationResultUnmarshaller : IUnmarshaller<MetadataConfigurationResult, XmlUnmarshallerContext>, IUnmarshaller<MetadataConfigurationResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MetadataConfigurationResult Unmarshall(XmlUnmarshallerContext context)
        {
            MetadataConfigurationResult unmarshalledObject = new MetadataConfigurationResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("DestinationResult", targetDepth))
                    {
                        var unmarshaller = DestinationResultUnmarshaller.Instance;
                        unmarshalledObject.DestinationResult = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InventoryTableConfigurationResult", targetDepth))
                    {
                        var unmarshaller = InventoryTableConfigurationResultUnmarshaller.Instance;
                        unmarshalledObject.InventoryTableConfigurationResult = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JournalTableConfigurationResult", targetDepth))
                    {
                        var unmarshaller = JournalTableConfigurationResultUnmarshaller.Instance;
                        unmarshalledObject.JournalTableConfigurationResult = unmarshaller.Unmarshall(context);
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
        public MetadataConfigurationResult Unmarshall(JsonUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        private static MetadataConfigurationResultUnmarshaller _instance = new MetadataConfigurationResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetadataConfigurationResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}