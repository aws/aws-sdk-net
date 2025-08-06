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
    /// Response Unmarshaller for ListAccessGrantEntry Object
    /// </summary>  
    public partial class ListAccessGrantEntryUnmarshaller : IXmlUnmarshaller<ListAccessGrantEntry, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ListAccessGrantEntry Unmarshall(XmlUnmarshallerContext context)
        {
            ListAccessGrantEntry unmarshalledObject = new ListAccessGrantEntry();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AccessGrantArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AccessGrantArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessGrantId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AccessGrantId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessGrantsLocationConfiguration", targetDepth))
                    {
                        var unmarshaller = AccessGrantsLocationConfigurationUnmarshaller.Instance;
                        unmarshalledObject.AccessGrantsLocationConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AccessGrantsLocationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AccessGrantsLocationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ApplicationArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ApplicationArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreatedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Grantee", targetDepth))
                    {
                        var unmarshaller = GranteeUnmarshaller.Instance;
                        unmarshalledObject.Grantee = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("GrantScope", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.GrantScope = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Permission", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Permission = unmarshaller.Unmarshall(context);
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

        partial void XmlStructureUnmarshallCustomization(XmlUnmarshallerContext context, ListAccessGrantEntry unmarshalledObject, int targetDepth);

        private static ListAccessGrantEntryUnmarshaller _instance = new ListAccessGrantEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListAccessGrantEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}