/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.CloudSearch.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudSearch.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeAnalysisSchemesResult Unmarshaller
     /// </summary>
    internal class DescribeAnalysisSchemesResultUnmarshaller : IUnmarshaller<DescribeAnalysisSchemesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeAnalysisSchemesResult, JsonUnmarshallerContext> 
    {
        public DescribeAnalysisSchemesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeAnalysisSchemesResult describeAnalysisSchemesResult = new DescribeAnalysisSchemesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("AnalysisSchemes/member", targetDepth))
                    {
                        describeAnalysisSchemesResult.AnalysisSchemes.Add(AnalysisSchemeStatusUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeAnalysisSchemesResult;
                }
            }
                        


            return describeAnalysisSchemesResult;
        }

        public DescribeAnalysisSchemesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeAnalysisSchemesResultUnmarshaller instance;

        public static DescribeAnalysisSchemesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeAnalysisSchemesResultUnmarshaller();

            return instance;
        }
    }
}
    
