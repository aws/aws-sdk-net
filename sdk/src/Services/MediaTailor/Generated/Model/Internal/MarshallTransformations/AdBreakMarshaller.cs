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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdBreak Marshaller
    /// </summary>
    public class AdBreakMarshaller : IRequestMarshaller<AdBreak, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AdBreak requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetMessageType())
            {
                context.Writer.WritePropertyName("MessageType");
                context.Writer.Write(requestObject.MessageType);
            }

            if(requestObject.IsSetOffsetMillis())
            {
                context.Writer.WritePropertyName("OffsetMillis");
                context.Writer.Write(requestObject.OffsetMillis);
            }

            if(requestObject.IsSetSlate())
            {
                context.Writer.WritePropertyName("Slate");
                context.Writer.WriteObjectStart();

                var marshaller = SlateSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.Slate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSpliceInsertMessage())
            {
                context.Writer.WritePropertyName("SpliceInsertMessage");
                context.Writer.WriteObjectStart();

                var marshaller = SpliceInsertMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.SpliceInsertMessage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeSignalMessage())
            {
                context.Writer.WritePropertyName("TimeSignalMessage");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSignalMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSignalMessage, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AdBreakMarshaller Instance = new AdBreakMarshaller();

    }
}