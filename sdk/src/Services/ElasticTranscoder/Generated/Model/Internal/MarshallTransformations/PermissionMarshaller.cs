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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Permission Marshaller
    /// </summary>
    public class PermissionMarshaller : IRequestMarshaller<Permission, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Permission requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccess())
            {
                context.Writer.WritePropertyName("Access");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccessListValue in requestObject.Access)
                {
                        context.Writer.WriteStringValue(requestObjectAccessListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGrantee())
            {
                context.Writer.WritePropertyName("Grantee");
                context.Writer.WriteStringValue(requestObject.Grantee);
            }

            if(requestObject.IsSetGranteeType())
            {
                context.Writer.WritePropertyName("GranteeType");
                context.Writer.WriteStringValue(requestObject.GranteeType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PermissionMarshaller Instance = new PermissionMarshaller();

    }
}