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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ValidStorageOptions Object
    /// </summary>
    public partial class ValidStorageOptionsUnmarshaller : IXmlUnmarshaller<ValidStorageOptions, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ValidStorageOptions Unmarshall(XmlUnmarshallerContext context)
        {
            ValidStorageOptions unmarshalledObject = new ValidStorageOptions();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IopsToStorageRatio/DoubleRange", targetDepth))
                    {
                        if (unmarshalledObject.IopsToStorageRatio == null)
                        {
                            unmarshalledObject.IopsToStorageRatio = new List<DoubleRange>();
                        }
                        var unmarshaller = DoubleRangeUnmarshaller.Instance;
                        unmarshalledObject.IopsToStorageRatio.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ProvisionedIops/Range", targetDepth))
                    {
                        if (unmarshalledObject.ProvisionedIops == null)
                        {
                            unmarshalledObject.ProvisionedIops = new List<Range>();
                        }
                        var unmarshaller = RangeUnmarshaller.Instance;
                        unmarshalledObject.ProvisionedIops.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ProvisionedStorageThroughput/Range", targetDepth))
                    {
                        if (unmarshalledObject.ProvisionedStorageThroughput == null)
                        {
                            unmarshalledObject.ProvisionedStorageThroughput = new List<Range>();
                        }
                        var unmarshaller = RangeUnmarshaller.Instance;
                        unmarshalledObject.ProvisionedStorageThroughput.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("StorageSize/Range", targetDepth))
                    {
                        if (unmarshalledObject.StorageSize == null)
                        {
                            unmarshalledObject.StorageSize = new List<Range>();
                        }
                        var unmarshaller = RangeUnmarshaller.Instance;
                        unmarshalledObject.StorageSize.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("StorageThroughputToIopsRatio/DoubleRange", targetDepth))
                    {
                        if (unmarshalledObject.StorageThroughputToIopsRatio == null)
                        {
                            unmarshalledObject.StorageThroughputToIopsRatio = new List<DoubleRange>();
                        }
                        var unmarshaller = DoubleRangeUnmarshaller.Instance;
                        unmarshalledObject.StorageThroughputToIopsRatio.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SupportsStorageAutoscaling", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsStorageAutoscaling = unmarshaller.Unmarshall(context);
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
        public static ValidStorageOptionsUnmarshaller Instance => _instance;
    }
}
