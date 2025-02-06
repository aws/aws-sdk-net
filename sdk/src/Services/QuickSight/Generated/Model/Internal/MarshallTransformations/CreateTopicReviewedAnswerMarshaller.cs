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
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTopicReviewedAnswer Marshaller
    /// </summary>
    public class CreateTopicReviewedAnswerMarshaller : IRequestMarshaller<CreateTopicReviewedAnswer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateTopicReviewedAnswer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnswerId())
            {
                context.Writer.WritePropertyName("AnswerId");
                context.Writer.WriteStringValue(requestObject.AnswerId);
            }

            if(requestObject.IsSetDatasetArn())
            {
                context.Writer.WritePropertyName("DatasetArn");
                context.Writer.WriteStringValue(requestObject.DatasetArn);
            }

            if(requestObject.IsSetMir())
            {
                context.Writer.WritePropertyName("Mir");
                context.Writer.WriteStartObject();

                var marshaller = TopicIRMarshaller.Instance;
                marshaller.Marshall(requestObject.Mir, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrimaryVisual())
            {
                context.Writer.WritePropertyName("PrimaryVisual");
                context.Writer.WriteStartObject();

                var marshaller = TopicVisualMarshaller.Instance;
                marshaller.Marshall(requestObject.PrimaryVisual, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQuestion())
            {
                context.Writer.WritePropertyName("Question");
                context.Writer.WriteStringValue(requestObject.Question);
            }

            if(requestObject.IsSetTemplate())
            {
                context.Writer.WritePropertyName("Template");
                context.Writer.WriteStartObject();

                var marshaller = TopicTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.Template, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateTopicReviewedAnswerMarshaller Instance = new CreateTopicReviewedAnswerMarshaller();

    }
}