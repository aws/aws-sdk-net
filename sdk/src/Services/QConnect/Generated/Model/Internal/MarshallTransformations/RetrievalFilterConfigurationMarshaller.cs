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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RetrievalFilterConfiguration Marshaller
    /// </summary>
    public class RetrievalFilterConfigurationMarshaller : IRequestMarshaller<RetrievalFilterConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RetrievalFilterConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndAll())
            {
                context.Writer.WritePropertyName("andAll");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAndAllListValue in requestObject.AndAll)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RetrievalFilterConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndAllListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEquals())
            {
                context.Writer.WritePropertyName("equals");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.Equals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGreaterThan())
            {
                context.Writer.WritePropertyName("greaterThan");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGreaterThanOrEquals())
            {
                context.Writer.WritePropertyName("greaterThanOrEquals");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.GreaterThanOrEquals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIn())
            {
                context.Writer.WritePropertyName("in");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.In, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLessThan())
            {
                context.Writer.WritePropertyName("lessThan");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThan, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLessThanOrEquals())
            {
                context.Writer.WritePropertyName("lessThanOrEquals");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.LessThanOrEquals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetListContains())
            {
                context.Writer.WritePropertyName("listContains");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.ListContains, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNotEquals())
            {
                context.Writer.WritePropertyName("notEquals");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotEquals, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNotIn())
            {
                context.Writer.WritePropertyName("notIn");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.NotIn, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOrAll())
            {
                context.Writer.WritePropertyName("orAll");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrAllListValue in requestObject.OrAll)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RetrievalFilterConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrAllListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStartsWith())
            {
                context.Writer.WritePropertyName("startsWith");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.StartsWith, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStringContains())
            {
                context.Writer.WritePropertyName("stringContains");
                context.Writer.WriteObjectStart();

                var marshaller = FilterAttributeMarshaller.Instance;
                marshaller.Marshall(requestObject.StringContains, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RetrievalFilterConfigurationMarshaller Instance = new RetrievalFilterConfigurationMarshaller();

    }
}