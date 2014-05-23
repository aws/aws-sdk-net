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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListAvailableSolutionStacks Object
    /// </summary>  
    public class ListAvailableSolutionStacksResultUnmarshaller : IUnmarshaller<ListAvailableSolutionStacksResult, XmlUnmarshallerContext>
    {
        public ListAvailableSolutionStacksResult Unmarshall(XmlUnmarshallerContext context) 
        {
            ListAvailableSolutionStacksResult result = new ListAvailableSolutionStacksResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("SolutionStackDetails/member", targetDepth))
                    {
                        var unmarshaller = SolutionStackDescriptionUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.SolutionStackDetails.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SolutionStacks/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        var item = unmarshaller.Unmarshall(context);
                        result.SolutionStacks.Add(item);
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


        private static ListAvailableSolutionStacksResultUnmarshaller instance;
        public static ListAvailableSolutionStacksResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new ListAvailableSolutionStacksResultUnmarshaller();
            }
            return instance;
        }

    }
}