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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Control.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Control.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for BucketLevel Object
    /// </summary>  
    public partial class BucketLevelUnmarshaller : IXmlUnmarshaller<BucketLevel, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public BucketLevel Unmarshall(XmlUnmarshallerContext context)
        {
            BucketLevel unmarshalledObject = new BucketLevel();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ActivityMetrics", targetDepth))
                    {
                        var unmarshaller = ActivityMetricsUnmarshaller.Instance;
                        unmarshalledObject.ActivityMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AdvancedCostOptimizationMetrics", targetDepth))
                    {
                        var unmarshaller = AdvancedCostOptimizationMetricsUnmarshaller.Instance;
                        unmarshalledObject.AdvancedCostOptimizationMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AdvancedDataProtectionMetrics", targetDepth))
                    {
                        var unmarshaller = AdvancedDataProtectionMetricsUnmarshaller.Instance;
                        unmarshalledObject.AdvancedDataProtectionMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DetailedStatusCodesMetrics", targetDepth))
                    {
                        var unmarshaller = DetailedStatusCodesMetricsUnmarshaller.Instance;
                        unmarshalledObject.DetailedStatusCodesMetrics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PrefixLevel", targetDepth))
                    {
                        var unmarshaller = PrefixLevelUnmarshaller.Instance;
                        unmarshalledObject.PrefixLevel = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    XmlStructureUnmarshallCustomization(context, unmarshalledObject, targetDepth);
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, BucketLevel unmarshalledObject, int targetDepth);

        private static BucketLevelUnmarshaller _instance = new BucketLevelUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BucketLevelUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}