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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PostFulfillmentStatusSpecification Marshaller
    /// </summary>
    public class PostFulfillmentStatusSpecificationMarshaller : IRequestMarshaller<PostFulfillmentStatusSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PostFulfillmentStatusSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFailureConditional())
            {
                context.Writer.WritePropertyName("failureConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFailureNextStep())
            {
                context.Writer.WritePropertyName("failureNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFailureResponse())
            {
                context.Writer.WritePropertyName("failureResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.FailureResponse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuccessConditional())
            {
                context.Writer.WritePropertyName("successConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.SuccessConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuccessNextStep())
            {
                context.Writer.WritePropertyName("successNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.SuccessNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuccessResponse())
            {
                context.Writer.WritePropertyName("successResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.SuccessResponse, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeoutConditional())
            {
                context.Writer.WritePropertyName("timeoutConditional");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeoutConditional, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeoutNextStep())
            {
                context.Writer.WritePropertyName("timeoutNextStep");
                context.Writer.WriteObjectStart();

                var marshaller = DialogStateMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeoutNextStep, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeoutResponse())
            {
                context.Writer.WritePropertyName("timeoutResponse");
                context.Writer.WriteObjectStart();

                var marshaller = ResponseSpecificationMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeoutResponse, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PostFulfillmentStatusSpecificationMarshaller Instance = new PostFulfillmentStatusSpecificationMarshaller();

    }
}