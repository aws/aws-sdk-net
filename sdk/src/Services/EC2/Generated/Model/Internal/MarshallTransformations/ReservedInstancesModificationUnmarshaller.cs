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
    /// Response Unmarshaller for ReservedInstancesModification Object
    /// </summary>  
    public class ReservedInstancesModificationUnmarshaller : IXmlUnmarshaller<ReservedInstancesModification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReservedInstancesModification Unmarshall(XmlUnmarshallerContext context)
        {
            ReservedInstancesModification unmarshalledObject = new ReservedInstancesModification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("clientToken", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ClientToken = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("createDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreateDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("effectiveDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.EffectiveDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("modificationResultSet/item", targetDepth))
                    {
                        var unmarshaller = ReservedInstancesModificationResultUnmarshaller.Instance;
                        if (unmarshalledObject.ModificationResults == null)
                        {
                            unmarshalledObject.ModificationResults = new List<ReservedInstancesModificationResult>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ModificationResults.Add(item);
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesSet/item", targetDepth))
                    {
                        var unmarshaller = ReservedInstancesIdUnmarshaller.Instance;
                        if (unmarshalledObject.ReservedInstancesIds == null)
                        {
                            unmarshalledObject.ReservedInstancesIds = new List<ReservedInstancesId>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ReservedInstancesIds.Add(item);
                        continue;
                    }
                    if (context.TestExpression("reservedInstancesModificationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReservedInstancesModificationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("updateDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.UpdateDate = unmarshaller.Unmarshall(context);
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

        private static ReservedInstancesModificationUnmarshaller _instance = new ReservedInstancesModificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReservedInstancesModificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}