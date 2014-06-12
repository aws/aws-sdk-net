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

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeResize Object
    /// </summary>  
    public class DescribeResizeResultUnmarshaller : IUnmarshaller<DescribeResizeResult, XmlUnmarshallerContext>
    {
        public DescribeResizeResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeResizeResult result = new DescribeResizeResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AvgResizeRateInMegaBytesPerSecond", targetDepth))
                    {
                        var unmarshaller = DoubleUnmarshaller.GetInstance();
                        result.AvgResizeRateInMegaBytesPerSecond = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ElapsedTimeInSeconds", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.GetInstance();
                        result.ElapsedTimeInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EstimatedTimeToCompletionInSeconds", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.GetInstance();
                        result.EstimatedTimeToCompletionInSeconds = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesCompleted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.ImportTablesCompleted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesInProgress/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.ImportTablesInProgress.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ImportTablesNotStarted/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.ImportTablesNotStarted.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ProgressInMegaBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.GetInstance();
                        result.ProgressInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetClusterType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.TargetClusterType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetNodeType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.TargetNodeType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetNumberOfNodes", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.GetInstance();
                        result.TargetNumberOfNodes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TotalResizeDataInMegaBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.GetInstance();
                        result.TotalResizeDataInMegaBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }

            return result;
        }


        private static DescribeResizeResultUnmarshaller instance;
        public static DescribeResizeResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new DescribeResizeResultUnmarshaller();
            }
            return instance;
        }

    }
}