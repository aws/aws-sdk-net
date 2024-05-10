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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PcaConnectorAd.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PcaConnectorAd.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TemplateDefinition Marshaller
    /// </summary>
    public class TemplateDefinitionMarshaller : IRequestMarshaller<TemplateDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TemplateDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetTemplateV2())
            {
                context.Writer.WritePropertyName("TemplateV2");
                context.Writer.WriteObjectStart();

                var marshaller = TemplateV2Marshaller.Instance;
                marshaller.Marshall(requestObject.TemplateV2, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateV3())
            {
                context.Writer.WritePropertyName("TemplateV3");
                context.Writer.WriteObjectStart();

                var marshaller = TemplateV3Marshaller.Instance;
                marshaller.Marshall(requestObject.TemplateV3, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTemplateV4())
            {
                context.Writer.WritePropertyName("TemplateV4");
                context.Writer.WriteObjectStart();

                var marshaller = TemplateV4Marshaller.Instance;
                marshaller.Marshall(requestObject.TemplateV4, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TemplateDefinitionMarshaller Instance = new TemplateDefinitionMarshaller();

    }
}