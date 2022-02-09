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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Occurrences Marshaller
    /// </summary>
    public class OccurrencesMarshaller : IRequestMarshaller<Occurrences, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Occurrences requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCells())
            {
                context.Writer.WritePropertyName("Cells");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCellsListValue in requestObject.Cells)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CellMarshaller.Instance;
                    marshaller.Marshall(requestObjectCellsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLineRanges())
            {
                context.Writer.WritePropertyName("LineRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLineRangesListValue in requestObject.LineRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectLineRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOffsetRanges())
            {
                context.Writer.WritePropertyName("OffsetRanges");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOffsetRangesListValue in requestObject.OffsetRanges)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectOffsetRangesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPages())
            {
                context.Writer.WritePropertyName("Pages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPagesListValue in requestObject.Pages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PageMarshaller.Instance;
                    marshaller.Marshall(requestObjectPagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecords())
            {
                context.Writer.WritePropertyName("Records");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecordsListValue in requestObject.Records)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RecordMarshaller.Instance;
                    marshaller.Marshall(requestObjectRecordsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OccurrencesMarshaller Instance = new OccurrencesMarshaller();

    }
}