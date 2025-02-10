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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SAPODataSourceProperties Marshaller
    /// </summary>
    public class SAPODataSourcePropertiesMarshaller : IRequestMarshaller<SAPODataSourceProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SAPODataSourceProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetObjectPath())
            {
                context.Writer.WritePropertyName("objectPath");
                context.Writer.WriteStringValue(requestObject.ObjectPath);
            }

            if(requestObject.IsSetPaginationConfig())
            {
                context.Writer.WritePropertyName("paginationConfig");
                context.Writer.WriteStartObject();

                var marshaller = SAPODataPaginationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.PaginationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParallelismConfig())
            {
                context.Writer.WritePropertyName("parallelismConfig");
                context.Writer.WriteStartObject();

                var marshaller = SAPODataParallelismConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ParallelismConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SAPODataSourcePropertiesMarshaller Instance = new SAPODataSourcePropertiesMarshaller();

    }
}