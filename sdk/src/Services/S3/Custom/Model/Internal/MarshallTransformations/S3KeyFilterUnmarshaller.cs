/*
 * Copyright 2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
     ///   Grant Unmarshaller
     /// </summary>
    internal class S3KeyFilterUnmarshaller : IUnmarshaller<S3KeyFilter, XmlUnmarshallerContext>, IUnmarshaller<S3KeyFilter, JsonUnmarshallerContext> 
    {
        public S3KeyFilter Unmarshall(XmlUnmarshallerContext context) 
        {
            S3KeyFilter s3KeyFilter = new S3KeyFilter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("FilterRule", targetDepth))
                    {
                        s3KeyFilter.FilterRules.Add(FilterRuleUnmarshaller.Instance.Unmarshall(context));                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return s3KeyFilter;
                }
            }

            return s3KeyFilter;
        }

        public S3KeyFilter Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static S3KeyFilterUnmarshaller _instance;

        public static S3KeyFilterUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new S3KeyFilterUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
