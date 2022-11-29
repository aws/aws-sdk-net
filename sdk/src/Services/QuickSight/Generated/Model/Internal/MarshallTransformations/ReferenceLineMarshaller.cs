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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReferenceLine Marshaller
    /// </summary>
    public class ReferenceLineMarshaller : IRequestMarshaller<ReferenceLine, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ReferenceLine requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataConfiguration())
            {
                context.Writer.WritePropertyName("DataConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ReferenceLineDataConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DataConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLabelConfiguration())
            {
                context.Writer.WritePropertyName("LabelConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ReferenceLineLabelConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LabelConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetStyleConfiguration())
            {
                context.Writer.WritePropertyName("StyleConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ReferenceLineStyleConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StyleConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ReferenceLineMarshaller Instance = new ReferenceLineMarshaller();

    }
}