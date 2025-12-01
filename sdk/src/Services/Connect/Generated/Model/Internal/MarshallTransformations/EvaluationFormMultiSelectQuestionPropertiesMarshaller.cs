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
    /// EvaluationFormMultiSelectQuestionProperties Marshaller
    /// </summary>
    public class EvaluationFormMultiSelectQuestionPropertiesMarshaller : IRequestMarshaller<EvaluationFormMultiSelectQuestionProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluationFormMultiSelectQuestionProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutomation())
            {
                context.Writer.WritePropertyName("Automation");
                context.Writer.WriteObjectStart();

                var marshaller = EvaluationFormMultiSelectQuestionAutomationMarshaller.Instance;
                marshaller.Marshall(requestObject.Automation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDisplayAs())
            {
                context.Writer.WritePropertyName("DisplayAs");
                context.Writer.Write(requestObject.DisplayAs);
            }

            if(requestObject.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOptionsListValue in requestObject.Options)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormMultiSelectQuestionOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluationFormMultiSelectQuestionPropertiesMarshaller Instance = new EvaluationFormMultiSelectQuestionPropertiesMarshaller();

    }
}