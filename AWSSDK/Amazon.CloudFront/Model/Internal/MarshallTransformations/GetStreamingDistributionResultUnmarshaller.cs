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

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Result Unmarshaller for GetStreamingDistribution operation
    /// </summary>  
    public class GetStreamingDistributionResultUnmarshaller : IUnmarshaller<GetStreamingDistributionResult, XmlUnmarshallerContext>
    {
        public GetStreamingDistributionResult Unmarshall(XmlUnmarshallerContext context)
        {
            var unmarshalledObject = new GetStreamingDistributionResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("StreamingDistribution", targetDepth))
                    {
                        var unmarshaller = StreamingDistributionUnmarshaller.GetInstance();
                        unmarshalledObject.StreamingDistribution = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }
            
            if (context.Headers["ETag"] != null)
                unmarshalledObject.ETag = context.Headers["ETag"];
            
            return unmarshalledObject;
        }        

        private static GetStreamingDistributionResultUnmarshaller instance;
        public static GetStreamingDistributionResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new GetStreamingDistributionResultUnmarshaller();
            }
            return instance;
        }

    }
}