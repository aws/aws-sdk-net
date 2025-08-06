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
    /// Response Unmarshaller for KeyNameConstraint Object
    /// </summary>  
    public partial class KeyNameConstraintUnmarshaller : IXmlUnmarshaller<KeyNameConstraint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public KeyNameConstraint Unmarshall(XmlUnmarshallerContext context)
        {
            KeyNameConstraint unmarshalledObject = new KeyNameConstraint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MatchAnyPrefix/member", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnyPrefix == null)
                        {
                            unmarshalledObject.MatchAnyPrefix = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnyPrefix.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchAnySubstring/member", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnySubstring == null)
                        {
                            unmarshalledObject.MatchAnySubstring = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnySubstring.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchAnySuffix/member", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnySuffix == null)
                        {
                            unmarshalledObject.MatchAnySuffix = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnySuffix.Add(unmarshaller.Unmarshall(context));
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, KeyNameConstraint unmarshalledObject, int targetDepth);

        private static KeyNameConstraintUnmarshaller _instance = new KeyNameConstraintUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static KeyNameConstraintUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}