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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ValidDBInstanceModificationsMessage Object
    /// </summary>  
    public class ValidDBInstanceModificationsMessageUnmarshaller : IXmlUnmarshaller<ValidDBInstanceModificationsMessage, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ValidDBInstanceModificationsMessage Unmarshall(XmlUnmarshallerContext context)
        {
            ValidDBInstanceModificationsMessage unmarshalledObject = new ValidDBInstanceModificationsMessage();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Storage/ValidStorageOptions", targetDepth))
                    {
                        var unmarshaller = ValidStorageOptionsUnmarshaller.Instance;
                        if (unmarshalledObject.Storage == null)
                        {
                            unmarshalledObject.Storage = new List<ValidStorageOptions>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Storage.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportsDedicatedLogVolume", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsDedicatedLogVolume = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ValidProcessorFeatures/AvailableProcessorFeature", targetDepth))
                    {
                        var unmarshaller = AvailableProcessorFeatureUnmarshaller.Instance;
                        if (unmarshalledObject.ValidProcessorFeatures == null)
                        {
                            unmarshalledObject.ValidProcessorFeatures = new List<AvailableProcessorFeature>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ValidProcessorFeatures.Add(item);
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

        private static ValidDBInstanceModificationsMessageUnmarshaller _instance = new ValidDBInstanceModificationsMessageUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidDBInstanceModificationsMessageUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}