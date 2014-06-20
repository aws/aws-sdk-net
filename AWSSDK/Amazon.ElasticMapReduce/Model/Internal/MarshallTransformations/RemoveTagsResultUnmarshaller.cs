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

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RemoveTags Object
    /// </summary>  
    public class RemoveTagsResultUnmarshaller : IUnmarshaller<RemoveTagsResult, XmlUnmarshallerContext>, IUnmarshaller<RemoveTagsResult, JsonUnmarshallerContext>
    {
        RemoveTagsResult IUnmarshaller<RemoveTagsResult, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public RemoveTagsResult Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new RemoveTagsResult();
                           
            return unmarshalledObject;
        }


        private static RemoveTagsResultUnmarshaller instance;
        public static RemoveTagsResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new RemoveTagsResultUnmarshaller();
            }
            return instance;
        }

    }
}