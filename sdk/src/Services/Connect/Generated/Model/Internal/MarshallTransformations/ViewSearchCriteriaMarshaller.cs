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
    /// ViewSearchCriteria Marshaller
    /// </summary>
    public class ViewSearchCriteriaMarshaller : IRequestMarshaller<ViewSearchCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ViewSearchCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndConditions())
            {
                context.Writer.WritePropertyName("AndConditions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAndConditionsListValue in requestObject.AndConditions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ViewSearchCriteriaMarshaller.Instance;
                    marshaller.Marshall(requestObjectAndConditionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOrConditions())
            {
                context.Writer.WritePropertyName("OrConditions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrConditionsListValue in requestObject.OrConditions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ViewSearchCriteriaMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrConditionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringCondition())
            {
                context.Writer.WritePropertyName("StringCondition");
                context.Writer.WriteObjectStart();

                var marshaller = StringConditionMarshaller.Instance;
                marshaller.Marshall(requestObject.StringCondition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetViewStatusCondition())
            {
                context.Writer.WritePropertyName("ViewStatusCondition");
                context.Writer.Write(requestObject.ViewStatusCondition);
            }

            if(requestObject.IsSetViewTypeCondition())
            {
                context.Writer.WritePropertyName("ViewTypeCondition");
                context.Writer.Write(requestObject.ViewTypeCondition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ViewSearchCriteriaMarshaller Instance = new ViewSearchCriteriaMarshaller();

    }
}