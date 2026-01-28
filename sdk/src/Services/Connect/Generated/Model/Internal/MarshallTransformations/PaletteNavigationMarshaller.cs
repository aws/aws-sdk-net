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
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PaletteNavigation Marshaller
    /// </summary>
    public class PaletteNavigationMarshaller : IRequestMarshaller<PaletteNavigation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PaletteNavigation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackground())
            {
                context.Writer.WritePropertyName("Background");
                context.Writer.WriteStringValue(requestObject.Background);
            }

            if(requestObject.IsSetInvertActionsColors())
            {
                context.Writer.WritePropertyName("InvertActionsColors");
                context.Writer.WriteBooleanValue(requestObject.InvertActionsColors.Value);
            }

            if(requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("Text");
                context.Writer.WriteStringValue(requestObject.Text);
            }

            if(requestObject.IsSetTextActive())
            {
                context.Writer.WritePropertyName("TextActive");
                context.Writer.WriteStringValue(requestObject.TextActive);
            }

            if(requestObject.IsSetTextBackgroundActive())
            {
                context.Writer.WritePropertyName("TextBackgroundActive");
                context.Writer.WriteStringValue(requestObject.TextBackgroundActive);
            }

            if(requestObject.IsSetTextBackgroundHover())
            {
                context.Writer.WritePropertyName("TextBackgroundHover");
                context.Writer.WriteStringValue(requestObject.TextBackgroundHover);
            }

            if(requestObject.IsSetTextHover())
            {
                context.Writer.WritePropertyName("TextHover");
                context.Writer.WriteStringValue(requestObject.TextHover);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PaletteNavigationMarshaller Instance = new PaletteNavigationMarshaller();

    }
}