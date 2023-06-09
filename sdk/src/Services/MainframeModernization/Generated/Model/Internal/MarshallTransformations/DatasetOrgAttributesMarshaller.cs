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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MainframeModernization.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MainframeModernization.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatasetOrgAttributes Marshaller
    /// </summary>
    public class DatasetOrgAttributesMarshaller : IRequestMarshaller<DatasetOrgAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatasetOrgAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetGdg())
            {
                context.Writer.WritePropertyName("gdg");
                context.Writer.WriteObjectStart();

                var marshaller = GdgAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Gdg, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPo())
            {
                context.Writer.WritePropertyName("po");
                context.Writer.WriteObjectStart();

                var marshaller = PoAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Po, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPs())
            {
                context.Writer.WritePropertyName("ps");
                context.Writer.WriteObjectStart();

                var marshaller = PsAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Ps, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVsam())
            {
                context.Writer.WritePropertyName("vsam");
                context.Writer.WriteObjectStart();

                var marshaller = VsamAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.Vsam, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatasetOrgAttributesMarshaller Instance = new DatasetOrgAttributesMarshaller();

    }
}