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
    /// EvaluationAnswerData Marshaller
    /// </summary>
    public class EvaluationAnswerDataMarshaller : IRequestMarshaller<EvaluationAnswerData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluationAnswerData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDateTimeValue())
            {
                context.Writer.WritePropertyName("DateTimeValue");
                context.Writer.Write(requestObject.DateTimeValue);
            }

            if(requestObject.IsSetNotApplicable())
            {
                context.Writer.WritePropertyName("NotApplicable");
                context.Writer.Write(requestObject.NotApplicable);
            }

            if(requestObject.IsSetNumericValue())
            {
                context.Writer.WritePropertyName("NumericValue");
                if(StringUtils.IsSpecialDoubleValue(requestObject.NumericValue))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.NumericValue));
                }
                else
                {
                    context.Writer.Write(requestObject.NumericValue);
                }
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.Write(requestObject.StringValue);
            }

            if(requestObject.IsSetStringValues())
            {
                context.Writer.WritePropertyName("StringValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringValuesListValue in requestObject.StringValues)
                {
                        context.Writer.Write(requestObjectStringValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluationAnswerDataMarshaller Instance = new EvaluationAnswerDataMarshaller();

    }
}