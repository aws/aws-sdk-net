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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResponseInspection Marshaller
    /// </summary>
    public class ResponseInspectionMarshaller : IRequestMarshaller<ResponseInspection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResponseInspection requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBodyContains())
            {
                context.Writer.WritePropertyName("BodyContains");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseInspectionBodyContainsMarshaller.Instance;
                marshaller.Marshall(requestObject.BodyContains, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetHeader())
            {
                context.Writer.WritePropertyName("Header");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseInspectionHeaderMarshaller.Instance;
                marshaller.Marshall(requestObject.Header, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJson())
            {
                context.Writer.WritePropertyName("Json");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseInspectionJsonMarshaller.Instance;
                marshaller.Marshall(requestObject.Json, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatusCode())
            {
                context.Writer.WritePropertyName("StatusCode");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseInspectionStatusCodeMarshaller.Instance;
                marshaller.Marshall(requestObject.StatusCode, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResponseInspectionMarshaller Instance = new ResponseInspectionMarshaller();

    }
}