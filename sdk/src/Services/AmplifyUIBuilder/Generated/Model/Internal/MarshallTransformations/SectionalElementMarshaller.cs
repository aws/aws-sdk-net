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

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SectionalElement Marshaller
    /// </summary>
    public class SectionalElementMarshaller : IRequestMarshaller<SectionalElement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SectionalElement requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExcluded())
            {
                context.Writer.WritePropertyName("excluded");
                context.Writer.Write(requestObject.Excluded);
            }

            if(requestObject.IsSetLevel())
            {
                context.Writer.WritePropertyName("level");
                context.Writer.Write(requestObject.Level);
            }

            if(requestObject.IsSetOrientation())
            {
                context.Writer.WritePropertyName("orientation");
                context.Writer.Write(requestObject.Orientation);
            }

            if(requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteObjectStart();

                var marshaller = FieldPositionMarshaller.Instance;
                marshaller.Marshall(requestObject.Position, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetText())
            {
                context.Writer.WritePropertyName("text");
                context.Writer.Write(requestObject.Text);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SectionalElementMarshaller Instance = new SectionalElementMarshaller();

    }
}