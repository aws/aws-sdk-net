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

/*
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalytics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalytics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceSchema Marshaller
    /// </summary>       
    public class SourceSchemaMarshaller : IRequestMarshaller<SourceSchema, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceSchema requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetRecordColumns())
            {
                context.Writer.WritePropertyName("RecordColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecordColumnsListValue in requestObject.RecordColumns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RecordColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecordEncoding())
            {
                context.Writer.WritePropertyName("RecordEncoding");
                context.Writer.Write(requestObject.RecordEncoding);
            }

            if(requestObject.IsSetRecordFormat())
            {
                context.Writer.WritePropertyName("RecordFormat");
                context.Writer.WriteObjectStart();

                var marshaller = RecordFormatMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordFormat, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SourceSchemaMarshaller Instance = new SourceSchemaMarshaller();

    }
}