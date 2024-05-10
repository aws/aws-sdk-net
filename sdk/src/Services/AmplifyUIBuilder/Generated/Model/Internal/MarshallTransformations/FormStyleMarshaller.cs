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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FormStyle Marshaller
    /// </summary>
    public class FormStyleMarshaller : IRequestMarshaller<FormStyle, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FormStyle requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHorizontalGap())
            {
                context.Writer.WritePropertyName("horizontalGap");
                context.Writer.WriteObjectStart();

                var marshaller = FormStyleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.HorizontalGap, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOuterPadding())
            {
                context.Writer.WritePropertyName("outerPadding");
                context.Writer.WriteObjectStart();

                var marshaller = FormStyleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.OuterPadding, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVerticalGap())
            {
                context.Writer.WritePropertyName("verticalGap");
                context.Writer.WriteObjectStart();

                var marshaller = FormStyleConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VerticalGap, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FormStyleMarshaller Instance = new FormStyleMarshaller();

    }
}