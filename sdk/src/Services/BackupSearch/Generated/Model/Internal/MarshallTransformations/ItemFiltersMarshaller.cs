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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ItemFilters Marshaller
    /// </summary>
    public class ItemFiltersMarshaller : IRequestMarshaller<ItemFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ItemFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEBSItemFilters())
            {
                context.Writer.WritePropertyName("EBSItemFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEBSItemFiltersListValue in requestObject.EBSItemFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EBSItemFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectEBSItemFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetS3ItemFilters())
            {
                context.Writer.WritePropertyName("S3ItemFilters");
                context.Writer.WriteStartArray();
                foreach(var requestObjectS3ItemFiltersListValue in requestObject.S3ItemFilters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = S3ItemFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectS3ItemFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ItemFiltersMarshaller Instance = new ItemFiltersMarshaller();

    }
}