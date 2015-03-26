/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListVersions operation
    /// </summary>
    internal class ListVersionsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            ListVersionsResponse response = new ListVersionsResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,ListVersionsResponse response)
        {
            
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
                        response.IsTruncated = BoolUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("KeyMarker", targetDepth))
                    {
                        response.KeyMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Delimiter", targetDepth))
                    {
                        response.Delimiter = StringUnmarshaller.GetInstance().Unmarshall(context);

                        continue;
                    } 
                    if (context.TestExpression("VersionIdMarker", targetDepth))
                    {
                        response.VersionIdMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextKeyMarker", targetDepth))
                    {
                        response.NextKeyMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("NextVersionIdMarker", targetDepth))
                    {
                        response.NextVersionIdMarker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Version", targetDepth))
                    {
                        response.Versions.Add(VersionsItemUnmarshaller.Instance.Unmarshall(context));
                            
                        continue;
                    }
                    if (context.TestExpression("DeleteMarker", targetDepth))
                    {
                        var version = VersionsItemUnmarshaller.Instance.Unmarshall(context);
                        version.IsDeleteMarker = true;
                        response.Versions.Add(version);
                            
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        response.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Prefix", targetDepth))
                    {
                        response.Prefix = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("MaxKeys", targetDepth))
                    {
                        response.MaxKeys = IntUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("CommonPrefixes", targetDepth))
                    {
                        var prefix = CommonPrefixesItemUnmarshaller.Instance.Unmarshall(context);

                        if (prefix != null)
                            response.CommonPrefixes.Add(prefix);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                            


            return;
        }

        private static ListVersionsResponseUnmarshaller _instance;

        public static ListVersionsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListVersionsResponseUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
    
