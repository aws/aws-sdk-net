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
    /// Response Unmarshaller for ApplicationStatusCheckResponseObject Object
    /// </summary>  
    public class ApplicationStatusCheckResponseObjectUnmarshaller : IXmlUnmarshaller<ApplicationStatusCheckResponseObject, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ApplicationStatusCheckResponseObject Unmarshall(XmlUnmarshallerContext context)
        {
            ApplicationStatusCheckResponseObject unmarshalledObject = new ApplicationStatusCheckResponseObject();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("aggregation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Aggregation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("applicationStatusCheckId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApplicationStatusCheckId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deletionTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.DeletionTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deviceIndex", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.DeviceIndex = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("failureThreshold", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.FailureThreshold = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("healthCheckPathSet/item", targetDepth))
                    {
                        var unmarshaller = HealthCheckPathResponseObjectUnmarshaller.Instance;
                        if (unmarshalledObject.HealthCheckPaths == null)
                        {
                            unmarshalledObject.HealthCheckPaths = new List<HealthCheckPathResponseObject>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.HealthCheckPaths.Add(item);
                        continue;
                    }
                    if (context.TestExpression("initializationGracePeriodSeconds", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.InitializationGracePeriodSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("interval", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Interval = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipScope", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpScope = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastUpdatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LastUpdatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("modifyTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.ModifyTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("path", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Path = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("protocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusCodeMatcher", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusCodeMatcher = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("successThreshold", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SuccessThreshold = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("targetTagAssociationSet/item", targetDepth))
                    {
                        var unmarshaller = CustomTagKeyValueResponsePairUnmarshaller.Instance;
                        if (unmarshalledObject.TargetTagAssociations == null)
                        {
                            unmarshalledObject.TargetTagAssociations = new List<CustomTagKeyValueResponsePair>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TargetTagAssociations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("timeout", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Timeout = unmarshaller.Unmarshall(context);
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

        private static ApplicationStatusCheckResponseObjectUnmarshaller _instance = new ApplicationStatusCheckResponseObjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationStatusCheckResponseObjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}