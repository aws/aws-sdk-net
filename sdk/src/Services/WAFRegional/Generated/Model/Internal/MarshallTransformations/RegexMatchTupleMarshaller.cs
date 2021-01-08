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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFRegional.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.WAFRegional.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegexMatchTuple Marshaller
    /// </summary>       
    public class RegexMatchTupleMarshaller : IRequestMarshaller<RegexMatchTuple, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RegexMatchTuple requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFieldToMatch())
            {
                context.Writer.WritePropertyName("FieldToMatch");
                context.Writer.WriteObjectStart();

                var marshaller = FieldToMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.FieldToMatch, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRegexPatternSetId())
            {
                context.Writer.WritePropertyName("RegexPatternSetId");
                context.Writer.Write(requestObject.RegexPatternSetId);
            }

            if(requestObject.IsSetTextTransformation())
            {
                context.Writer.WritePropertyName("TextTransformation");
                context.Writer.Write(requestObject.TextTransformation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RegexMatchTupleMarshaller Instance = new RegexMatchTupleMarshaller();

    }
}