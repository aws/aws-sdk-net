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

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EvaluationFormSection Marshaller
    /// </summary>
    public class EvaluationFormSectionMarshaller : IRequestMarshaller<EvaluationFormSection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluationFormSection requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInstructions())
            {
                context.Writer.WritePropertyName("Instructions");
                context.Writer.Write(requestObject.Instructions);
            }

            if(requestObject.IsSetItems())
            {
                context.Writer.WritePropertyName("Items");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectItemsListValue in requestObject.Items)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EvaluationFormItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectItemsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
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
                context.Writer.Write(requestObject.Weight);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluationFormSectionMarshaller Instance = new EvaluationFormSectionMarshaller();

    }
}