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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for S3TablePublishStatus Object
    /// </summary>  
    public class S3TablePublishStatusUnmarshaller : IXmlUnmarshaller<S3TablePublishStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public S3TablePublishStatus Unmarshall(XmlUnmarshallerContext context)
        {
            S3TablePublishStatus unmarshalledObject = new S3TablePublishStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("EnabledAll", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.EnabledAll = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LastIngestionTimes/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance, "key", "value");
                        if (unmarshalledObject.LastIngestionTimes == null)
                        {
                            unmarshalledObject.LastIngestionTimes = new Dictionary<string, string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.LastIngestionTimes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("S3TableGranularity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3TableGranularity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3TableNamespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3TableNamespace = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("S3Tables/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.S3Tables == null)
                        {
                            unmarshalledObject.S3Tables = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.S3Tables.Add(item);
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

        private static S3TablePublishStatusUnmarshaller _instance = new S3TablePublishStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static S3TablePublishStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}