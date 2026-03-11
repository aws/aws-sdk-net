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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelatedItemTypeFilter Marshaller
    /// </summary>
    public class RelatedItemTypeFilterMarshaller : IRequestMarshaller<RelatedItemTypeFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RelatedItemTypeFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.WriteStartObject();

                var marshaller = CommentFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Comment, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectCase())
            {
                context.Writer.WritePropertyName("connectCase");
                context.Writer.WriteStartObject();

                var marshaller = ConnectCaseFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectCase, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContact())
            {
                context.Writer.WritePropertyName("contact");
                context.Writer.WriteStartObject();

                var marshaller = ContactFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Contact, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustom())
            {
                context.Writer.WritePropertyName("custom");
                context.Writer.WriteStartObject();

                var marshaller = CustomFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Custom, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFile())
            {
                context.Writer.WritePropertyName("file");
                context.Writer.WriteStartObject();

                var marshaller = FileFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.File, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSla())
            {
                context.Writer.WritePropertyName("sla");
                context.Writer.WriteStartObject();

                var marshaller = SlaFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.Sla, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RelatedItemTypeFilterMarshaller Instance = new RelatedItemTypeFilterMarshaller();

    }
}