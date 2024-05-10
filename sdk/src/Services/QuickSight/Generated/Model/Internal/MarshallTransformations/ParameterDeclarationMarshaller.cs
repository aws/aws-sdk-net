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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ParameterDeclaration Marshaller
    /// </summary>
    public class ParameterDeclarationMarshaller : IRequestMarshaller<ParameterDeclaration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ParameterDeclaration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDateTimeParameterDeclaration())
            {
                context.Writer.WritePropertyName("DateTimeParameterDeclaration");
                context.Writer.WriteObjectStart();

                var marshaller = DateTimeParameterDeclarationMarshaller.Instance;
                marshaller.Marshall(requestObject.DateTimeParameterDeclaration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDecimalParameterDeclaration())
            {
                context.Writer.WritePropertyName("DecimalParameterDeclaration");
                context.Writer.WriteObjectStart();

                var marshaller = DecimalParameterDeclarationMarshaller.Instance;
                marshaller.Marshall(requestObject.DecimalParameterDeclaration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIntegerParameterDeclaration())
            {
                context.Writer.WritePropertyName("IntegerParameterDeclaration");
                context.Writer.WriteObjectStart();

                var marshaller = IntegerParameterDeclarationMarshaller.Instance;
                marshaller.Marshall(requestObject.IntegerParameterDeclaration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStringParameterDeclaration())
            {
                context.Writer.WritePropertyName("StringParameterDeclaration");
                context.Writer.WriteObjectStart();

                var marshaller = StringParameterDeclarationMarshaller.Instance;
                marshaller.Marshall(requestObject.StringParameterDeclaration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParameterDeclarationMarshaller Instance = new ParameterDeclarationMarshaller();

    }
}