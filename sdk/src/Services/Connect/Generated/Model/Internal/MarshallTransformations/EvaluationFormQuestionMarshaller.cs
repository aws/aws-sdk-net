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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EvaluationFormQuestion Marshaller
    /// </summary>
    public class EvaluationFormQuestionMarshaller : IRequestMarshaller<EvaluationFormQuestion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluationFormQuestion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnablement())
            {
                context.Writer.WritePropertyName("Enablement");
                context.Writer.WriteObjectStart();

                var marshaller = EvaluationFormItemEnablementConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Enablement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInstructions())
            {
                context.Writer.WritePropertyName("Instructions");
                context.Writer.Write(requestObject.Instructions);
            }

            if(requestObject.IsSetNotApplicableEnabled())
            {
                context.Writer.WritePropertyName("NotApplicableEnabled");
                context.Writer.Write(requestObject.NotApplicableEnabled);
            }

            if(requestObject.IsSetQuestionType())
            {
                context.Writer.WritePropertyName("QuestionType");
                context.Writer.Write(requestObject.QuestionType);
            }

            if(requestObject.IsSetQuestionTypeProperties())
            {
                context.Writer.WritePropertyName("QuestionTypeProperties");
                context.Writer.WriteObjectStart();

                var marshaller = EvaluationFormQuestionTypePropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.QuestionTypeProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRefId())
            {
                context.Writer.WritePropertyName("RefId");
                context.Writer.Write(requestObject.RefId);
            }

            if(requestObject.IsSetTitle())
            {
                context.Writer.WritePropertyName("Title");
                context.Writer.Write(requestObject.Title);
            }

            if(requestObject.IsSetWeight())
            {
                context.Writer.WritePropertyName("Weight");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Weight))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Weight));
                }
                else
                {
                    context.Writer.Write(requestObject.Weight);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluationFormQuestionMarshaller Instance = new EvaluationFormQuestionMarshaller();

    }
}