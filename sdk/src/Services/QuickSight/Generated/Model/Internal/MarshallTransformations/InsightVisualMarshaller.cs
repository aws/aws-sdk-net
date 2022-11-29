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
    /// InsightVisual Marshaller
    /// </summary>
    public class InsightVisualMarshaller : IRequestMarshaller<InsightVisual, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InsightVisual requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VisualCustomActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSetIdentifier())
            {
                context.Writer.WritePropertyName("DataSetIdentifier");
                context.Writer.Write(requestObject.DataSetIdentifier);
            }

            if(requestObject.IsSetInsightConfiguration())
            {
                context.Writer.WritePropertyName("InsightConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = InsightConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InsightConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSubtitle())
            {
                context.Writer.WritePropertyName("Subtitle");
                context.Writer.WriteObjectStart();

                var marshaller = VisualSubtitleLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Subtitle, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.WriteObjectStart();

                var marshaller = VisualTitleLabelOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Title, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisualId())
            {
                context.Writer.WritePropertyName("VisualId");
                context.Writer.Write(requestObject.VisualId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InsightVisualMarshaller Instance = new InsightVisualMarshaller();

    }
}