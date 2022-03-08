﻿/*
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetObjectAttributesParts Object
    /// </summary>  
    public class GetObjectAttributesPartsUnmarshaller : IUnmarshaller<GetObjectAttributesParts, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public GetObjectAttributesParts Unmarshall(XmlUnmarshallerContext context)
        {
            GetObjectAttributesParts unmarshalledObject = new GetObjectAttributesParts();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxParts", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.MaxParts = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextPartNumberMarker", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NextPartNumberMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PartNumberMarker", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.PartNumberMarker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Part/member", targetDepth))
                    {
                        var unmarshaller = ObjectPartUnmarshaller.Instance;
                        unmarshalledObject.Parts.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("PartsCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.TotalPartsCount = unmarshaller.Unmarshall(context);
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

        private static GetObjectAttributesPartsUnmarshaller _instance = new GetObjectAttributesPartsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetObjectAttributesPartsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}