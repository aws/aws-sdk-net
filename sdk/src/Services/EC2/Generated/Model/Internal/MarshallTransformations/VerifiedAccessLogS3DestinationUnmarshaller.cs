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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VerifiedAccessLogS3Destination Object
    /// </summary>  
    public class VerifiedAccessLogS3DestinationUnmarshaller : IXmlUnmarshaller<VerifiedAccessLogS3Destination, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VerifiedAccessLogS3Destination Unmarshall(XmlUnmarshallerContext context)
        {
            VerifiedAccessLogS3Destination unmarshalledObject = new VerifiedAccessLogS3Destination();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("bucketName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("bucketOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BucketOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deliveryStatus", targetDepth))
                    {
                        var unmarshaller = VerifiedAccessLogDeliveryStatusUnmarshaller.Instance;
                        unmarshalledObject.DeliveryStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Prefix = unmarshaller.Unmarshall(context);
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

        private static VerifiedAccessLogS3DestinationUnmarshaller _instance = new VerifiedAccessLogS3DestinationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VerifiedAccessLogS3DestinationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}