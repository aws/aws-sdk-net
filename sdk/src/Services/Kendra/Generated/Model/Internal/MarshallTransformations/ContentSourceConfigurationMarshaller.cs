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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ContentSourceConfiguration Marshaller
    /// </summary>
    public class ContentSourceConfigurationMarshaller : IRequestMarshaller<ContentSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContentSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSourceIds())
            {
                context.Writer.WritePropertyName("DataSourceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataSourceIdsListValue in requestObject.DataSourceIds)
                {
                        context.Writer.WriteStringValue(requestObjectDataSourceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDirectPutContent())
            {
                context.Writer.WritePropertyName("DirectPutContent");
                context.Writer.WriteBooleanValue(requestObject.DirectPutContent.Value);
            }

            if(requestObject.IsSetFaqIds())
            {
                context.Writer.WritePropertyName("FaqIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFaqIdsListValue in requestObject.FaqIds)
                {
                        context.Writer.WriteStringValue(requestObjectFaqIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContentSourceConfigurationMarshaller Instance = new ContentSourceConfigurationMarshaller();

    }
}