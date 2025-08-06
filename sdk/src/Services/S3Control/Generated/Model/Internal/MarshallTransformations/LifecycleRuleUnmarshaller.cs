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
    /// Response Unmarshaller for LifecycleRule Object
    /// </summary>  
    public partial class LifecycleRuleUnmarshaller : IXmlUnmarshaller<LifecycleRule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LifecycleRule Unmarshall(XmlUnmarshallerContext context)
        {
            LifecycleRule unmarshalledObject = new LifecycleRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AbortIncompleteMultipartUpload", targetDepth))
                    {
                        var unmarshaller = AbortIncompleteMultipartUploadUnmarshaller.Instance;
                        unmarshalledObject.AbortIncompleteMultipartUpload = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Expiration", targetDepth))
                    {
                        var unmarshaller = LifecycleExpirationUnmarshaller.Instance;
                        unmarshalledObject.Expiration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        var unmarshaller = LifecycleRuleFilterUnmarshaller.Instance;
                        unmarshalledObject.Filter = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ID = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionExpiration", targetDepth))
                    {
                        var unmarshaller = NoncurrentVersionExpirationUnmarshaller.Instance;
                        unmarshalledObject.NoncurrentVersionExpiration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionTransitions/NoncurrentVersionTransition", targetDepth))
                    {
                        if (unmarshalledObject.NoncurrentVersionTransitions == null)
                        {
                            unmarshalledObject.NoncurrentVersionTransitions = new List<NoncurrentVersionTransition>();
                        }
                        var unmarshaller = NoncurrentVersionTransitionUnmarshaller.Instance;
                        unmarshalledObject.NoncurrentVersionTransitions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Transitions/Transition", targetDepth))
                    {
                        if (unmarshalledObject.Transitions == null)
                        {
                            unmarshalledObject.Transitions = new List<Transition>();
                        }
                        var unmarshaller = TransitionUnmarshaller.Instance;
                        unmarshalledObject.Transitions.Add(unmarshaller.Unmarshall(context));
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, LifecycleRule unmarshalledObject, int targetDepth);

        private static LifecycleRuleUnmarshaller _instance = new LifecycleRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LifecycleRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}