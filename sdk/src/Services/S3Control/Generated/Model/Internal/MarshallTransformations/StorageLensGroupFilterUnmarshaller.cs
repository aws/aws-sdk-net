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
    /// Response Unmarshaller for StorageLensGroupFilter Object
    /// </summary>  
    public class StorageLensGroupFilterUnmarshaller : IUnmarshaller<StorageLensGroupFilter, XmlUnmarshallerContext>, IUnmarshaller<StorageLensGroupFilter, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StorageLensGroupFilter Unmarshall(XmlUnmarshallerContext context)
        {
            StorageLensGroupFilter unmarshalledObject = new StorageLensGroupFilter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("And", targetDepth))
                    {
                        var unmarshaller = StorageLensGroupAndOperatorUnmarshaller.Instance;
                        unmarshalledObject.And = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MatchAnyPrefix/Prefix", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnyPrefix == null)
                        {
                            unmarshalledObject.MatchAnyPrefix = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnyPrefix.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchAnySuffix/Suffix", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnySuffix == null)
                        {
                            unmarshalledObject.MatchAnySuffix = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MatchAnySuffix.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchAnyTag/Tag", targetDepth))
                    {
                        if (unmarshalledObject.MatchAnyTag == null)
                        {
                            unmarshalledObject.MatchAnyTag = new List<S3Tag>();
                        }
                        var unmarshaller = S3TagUnmarshaller.Instance;
                        unmarshalledObject.MatchAnyTag.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("MatchObjectAge", targetDepth))
                    {
                        var unmarshaller = MatchObjectAgeUnmarshaller.Instance;
                        unmarshalledObject.MatchObjectAge = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MatchObjectSize", targetDepth))
                    {
                        var unmarshaller = MatchObjectSizeUnmarshaller.Instance;
                        unmarshalledObject.MatchObjectSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Or", targetDepth))
                    {
                        var unmarshaller = StorageLensGroupOrOperatorUnmarshaller.Instance;
                        unmarshalledObject.Or = unmarshaller.Unmarshall(context);
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
        
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StorageLensGroupFilter Unmarshall(JsonUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        private static StorageLensGroupFilterUnmarshaller _instance = new StorageLensGroupFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StorageLensGroupFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}