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
    /// Response Unmarshaller for AsyncOperation Object
    /// </summary>  
    public partial class AsyncOperationUnmarshaller : IXmlUnmarshaller<AsyncOperation, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AsyncOperation Unmarshall(XmlUnmarshallerContext context)
        {
            AsyncOperation unmarshalledObject = new AsyncOperation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CreationTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Operation", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Operation = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestParameters", targetDepth))
                    {
                        var unmarshaller = AsyncRequestParametersUnmarshaller.Instance;
                        unmarshalledObject.RequestParameters = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequestStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequestTokenARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.RequestTokenARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResponseDetails", targetDepth))
                    {
                        var unmarshaller = AsyncResponseDetailsUnmarshaller.Instance;
                        unmarshalledObject.ResponseDetails = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, AsyncOperation unmarshalledObject, int targetDepth);

        private static AsyncOperationUnmarshaller _instance = new AsyncOperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AsyncOperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}