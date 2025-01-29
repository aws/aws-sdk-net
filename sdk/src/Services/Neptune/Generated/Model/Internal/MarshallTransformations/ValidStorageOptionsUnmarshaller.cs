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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ValidStorageOptions Object
    /// </summary>  
    public class ValidStorageOptionsUnmarshaller : IXmlUnmarshaller<ValidStorageOptions, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ValidStorageOptions Unmarshall(XmlUnmarshallerContext context)
        {
            ValidStorageOptions unmarshalledObject = new ValidStorageOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IopsToStorageRatio/DoubleRange", targetDepth))
                    {
                        var unmarshaller = DoubleRangeUnmarshaller.Instance;
                        if (unmarshalledObject.IopsToStorageRatio == null)
                        {
                            unmarshalledObject.IopsToStorageRatio = new List<DoubleRange>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.IopsToStorageRatio.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ProvisionedIops/Range", targetDepth))
                    {
                        var unmarshaller = RangeUnmarshaller.Instance;
                        if (unmarshalledObject.ProvisionedIops == null)
                        {
                            unmarshalledObject.ProvisionedIops = new List<Range>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ProvisionedIops.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StorageSize/Range", targetDepth))
                    {
                        var unmarshaller = RangeUnmarshaller.Instance;
                        if (unmarshalledObject.StorageSize == null)
                        {
                            unmarshalledObject.StorageSize = new List<Range>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.StorageSize.Add(item);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
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

        private static ValidStorageOptionsUnmarshaller _instance = new ValidStorageOptionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidStorageOptionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}