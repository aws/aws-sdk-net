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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PosixUser Marshaller
    /// </summary>
    public class PosixUserMarshaller : IRequestMarshaller<PosixUser, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PosixUser requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGid())
            {
                context.Writer.WritePropertyName("Gid");
                context.Writer.WriteNumberValue(requestObject.Gid.Value);
            }

            if(requestObject.IsSetSecondaryGids())
            {
                context.Writer.WritePropertyName("SecondaryGids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecondaryGidsListValue in requestObject.SecondaryGids)
                {
                        context.Writer.WriteNumberValue(requestObjectSecondaryGidsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUid())
            {
                context.Writer.WritePropertyName("Uid");
                context.Writer.WriteNumberValue(requestObject.Uid.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PosixUserMarshaller Instance = new PosixUserMarshaller();

    }
}