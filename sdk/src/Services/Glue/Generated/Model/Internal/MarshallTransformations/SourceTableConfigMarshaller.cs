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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceTableConfig Marshaller
    /// </summary>
    public class SourceTableConfigMarshaller : IRequestMarshaller<SourceTableConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceTableConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFields())
            {
                context.Writer.WritePropertyName("Fields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFieldsListValue in requestObject.Fields)
                {
                        context.Writer.WriteStringValue(requestObjectFieldsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFilterPredicate())
            {
                context.Writer.WritePropertyName("FilterPredicate");
                context.Writer.WriteStringValue(requestObject.FilterPredicate);
            }

            if(requestObject.IsSetPrimaryKey())
            {
                context.Writer.WritePropertyName("PrimaryKey");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPrimaryKeyListValue in requestObject.PrimaryKey)
                {
                        context.Writer.WriteStringValue(requestObjectPrimaryKeyListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRecordUpdateField())
            {
                context.Writer.WritePropertyName("RecordUpdateField");
                context.Writer.WriteStringValue(requestObject.RecordUpdateField);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceTableConfigMarshaller Instance = new SourceTableConfigMarshaller();

    }
}