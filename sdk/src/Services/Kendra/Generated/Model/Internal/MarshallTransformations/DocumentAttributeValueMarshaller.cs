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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DocumentAttributeValue Marshaller
    /// </summary>       
    public class DocumentAttributeValueMarshaller : IRequestMarshaller<DocumentAttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentAttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDateValue())
            {
                context.Writer.WritePropertyName("DateValue");
                context.Writer.Write(requestObject.DateValue);
            }

            if(requestObject.IsSetLongValue())
            {
                context.Writer.WritePropertyName("LongValue");
                context.Writer.Write(requestObject.LongValue);
            }

            if(requestObject.IsSetStringListValue())
            {
                context.Writer.WritePropertyName("StringListValue");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringListValueListValue in requestObject.StringListValue)
                {
                        context.Writer.Write(requestObjectStringListValueListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringValue())
            {
                context.Writer.WritePropertyName("StringValue");
                context.Writer.Write(requestObject.StringValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DocumentAttributeValueMarshaller Instance = new DocumentAttributeValueMarshaller();

    }
}