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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ViewRepresentationInput Marshaller
    /// </summary>
    public class ViewRepresentationInputMarshaller : IRequestMarshaller<ViewRepresentationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ViewRepresentationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDialect())
            {
                context.Writer.WritePropertyName("Dialect");
                context.Writer.WriteStringValue(requestObject.Dialect);
            }

            if(requestObject.IsSetDialectVersion())
            {
                context.Writer.WritePropertyName("DialectVersion");
                context.Writer.WriteStringValue(requestObject.DialectVersion);
            }

            if(requestObject.IsSetValidationConnection())
            {
                context.Writer.WritePropertyName("ValidationConnection");
                context.Writer.WriteStringValue(requestObject.ValidationConnection);
            }

            if(requestObject.IsSetViewExpandedText())
            {
                context.Writer.WritePropertyName("ViewExpandedText");
                context.Writer.WriteStringValue(requestObject.ViewExpandedText);
            }

            if(requestObject.IsSetViewOriginalText())
            {
                context.Writer.WritePropertyName("ViewOriginalText");
                context.Writer.WriteStringValue(requestObject.ViewOriginalText);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ViewRepresentationInputMarshaller Instance = new ViewRepresentationInputMarshaller();

    }
}