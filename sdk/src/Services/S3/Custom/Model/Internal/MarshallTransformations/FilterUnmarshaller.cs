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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   Filter Unmarshaller
     /// </summary>
    public class FilterUnmarshaller : IUnmarshaller<Filter, XmlUnmarshallerContext>, IUnmarshaller<Filter, JsonUnmarshallerContext> 
    {
        public Filter Unmarshall(XmlUnmarshallerContext context) 
        {
            Filter filter = new Filter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("S3Key", targetDepth))
                    {
                        filter.S3KeyFilter = S3KeyFilterUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return filter;
                }
            }

            return filter;
        }

        public Filter Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static FilterUnmarshaller _instance;

        public static FilterUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new FilterUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
