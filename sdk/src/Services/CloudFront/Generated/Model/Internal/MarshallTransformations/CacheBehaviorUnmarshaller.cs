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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CacheBehavior Object
    /// </summary>  
    public class CacheBehaviorUnmarshaller : IXmlUnmarshaller<CacheBehavior, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CacheBehavior Unmarshall(XmlUnmarshallerContext context)
        {
            CacheBehavior unmarshalledObject = new CacheBehavior();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AllowedMethods", targetDepth))
                    {
                        var unmarshaller = AllowedMethodsUnmarshaller.Instance;
                        unmarshalledObject.AllowedMethods = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CachePolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.CachePolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Compress", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Compress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultTTL", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.DefaultTTL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FieldLevelEncryptionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FieldLevelEncryptionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ForwardedValues", targetDepth))
                    {
                        var unmarshaller = ForwardedValuesUnmarshaller.Instance;
                        unmarshalledObject.ForwardedValues = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("FunctionAssociations", targetDepth))
                    {
                        var unmarshaller = FunctionAssociationsUnmarshaller.Instance;
                        unmarshalledObject.FunctionAssociations = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LambdaFunctionAssociations", targetDepth))
                    {
                        var unmarshaller = LambdaFunctionAssociationsUnmarshaller.Instance;
                        unmarshalledObject.LambdaFunctionAssociations = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxTTL", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.MaxTTL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinTTL", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.MinTTL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("OriginRequestPolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OriginRequestPolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PathPattern", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PathPattern = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RealtimeLogConfigArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RealtimeLogConfigArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResponseHeadersPolicyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResponseHeadersPolicyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SmoothStreaming", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.SmoothStreaming = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetOriginId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetOriginId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrustedKeyGroups", targetDepth))
                    {
                        var unmarshaller = TrustedKeyGroupsUnmarshaller.Instance;
                        unmarshalledObject.TrustedKeyGroups = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrustedSigners", targetDepth))
                    {
                        var unmarshaller = TrustedSignersUnmarshaller.Instance;
                        unmarshalledObject.TrustedSigners = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ViewerProtocolPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ViewerProtocolPolicy = unmarshaller.Unmarshall(context);
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
        private static CacheBehaviorUnmarshaller _instance = new CacheBehaviorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CacheBehaviorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}