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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListMultipartUploads operation
    /// </summary>
    public partial class ListMultipartUploadsResponseUnmarshaller : S3ReponseUnmarshaller
    {  
        private static void CommonPrefixesCustomUnmarshall(XmlUnmarshallerContext context, ListMultipartUploadsResponse response)
        {
            var prefix = CommonPrefixesItemUnmarshaller.Instance.Unmarshall(context);

            if (prefix != null)
            {
                if (response.CommonPrefixes == null)
                {
                    response.CommonPrefixes = new List<string>();
                }
                response.CommonPrefixes.Add(prefix);
            }
            return;
        }
    }
}
    
