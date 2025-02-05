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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReceiptRule Object
    /// </summary>  
    public class ReceiptRuleUnmarshaller : IXmlUnmarshaller<ReceiptRule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ReceiptRule Unmarshall(XmlUnmarshallerContext context)
        {
            ReceiptRule unmarshalledObject = new ReceiptRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Actions/member", targetDepth))
                    {
                        var unmarshaller = ReceiptActionUnmarshaller.Instance;
                        if (unmarshalledObject.Actions == null)
                        {
                            unmarshalledObject.Actions = new List<ReceiptAction>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Actions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Enabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Enabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Recipients/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Recipients == null)
                        {
                            unmarshalledObject.Recipients = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Recipients.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ScanEnabled", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.ScanEnabled = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TlsPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TlsPolicy = unmarshaller.Unmarshall(context);
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

        private static ReceiptRuleUnmarshaller _instance = new ReceiptRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReceiptRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}