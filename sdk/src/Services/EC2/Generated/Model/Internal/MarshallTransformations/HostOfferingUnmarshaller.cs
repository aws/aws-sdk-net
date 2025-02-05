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
    /// Response Unmarshaller for HostOffering Object
    /// </summary>  
    public class HostOfferingUnmarshaller : IXmlUnmarshaller<HostOffering, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HostOffering Unmarshall(XmlUnmarshallerContext context)
        {
            HostOffering unmarshalledObject = new HostOffering();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("currencyCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CurrencyCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("duration", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("hourlyPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HourlyPrice = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("instanceFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("offeringId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OfferingId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("paymentOption", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PaymentOption = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("upfrontPrice", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.UpfrontPrice = unmarshaller.Unmarshall(context);
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

        private static HostOfferingUnmarshaller _instance = new HostOfferingUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HostOfferingUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}