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
 * Do not modify this file. This file is generated from the cloudsearch-2013-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainStatus Object
    /// </summary>  
    public class DomainStatusUnmarshaller : IXmlUnmarshaller<DomainStatus, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DomainStatus Unmarshall(XmlUnmarshallerContext context)
        {
            DomainStatus unmarshalledObject = new DomainStatus();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ARN", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Created", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Created = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Deleted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Deleted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DocService", targetDepth))
                    {
                        var unmarshaller = ServiceEndpointUnmarshaller.Instance;
                        unmarshalledObject.DocService = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DomainId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DomainId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DomainName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DomainName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Limits", targetDepth))
                    {
                        var unmarshaller = LimitsUnmarshaller.Instance;
                        unmarshalledObject.Limits = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Processing", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Processing = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RequiresIndexDocuments", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.RequiresIndexDocuments = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SearchInstanceCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SearchInstanceCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SearchInstanceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SearchInstanceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SearchPartitionCount", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SearchPartitionCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SearchService", targetDepth))
                    {
                        var unmarshaller = ServiceEndpointUnmarshaller.Instance;
                        unmarshalledObject.SearchService = unmarshaller.Unmarshall(context);
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

        private static DomainStatusUnmarshaller _instance = new DomainStatusUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainStatusUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}