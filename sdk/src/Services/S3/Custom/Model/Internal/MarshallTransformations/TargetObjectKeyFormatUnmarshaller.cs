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
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TargetObjectKeyFormat Object
    /// </summary>  
    public class TargetObjectKeyFormatUnmarshaller : IXmlUnmarshaller<TargetObjectKeyFormat, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TargetObjectKeyFormat Unmarshall(XmlUnmarshallerContext context)
        {
            TargetObjectKeyFormat unmarshalledObject = new TargetObjectKeyFormat();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("PartitionedPrefix", targetDepth))
                    {
                        var unmarshaller = PartitionedPrefixUnmarshaller.Instance;
                        unmarshalledObject.PartitionedPrefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SimplePrefix", targetDepth))
                    {
                        var unmarshaller = SimplePrefixUnmarshaller.Instance;
                        unmarshalledObject.SimplePrefix = unmarshaller.Unmarshall(context);
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

        private static TargetObjectKeyFormatUnmarshaller _instance = new TargetObjectKeyFormatUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TargetObjectKeyFormatUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}