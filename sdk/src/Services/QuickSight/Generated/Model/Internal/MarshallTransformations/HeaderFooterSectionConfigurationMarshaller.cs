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
    /// HeaderFooterSectionConfiguration Marshaller
    /// </summary>
    public class HeaderFooterSectionConfigurationMarshaller : IRequestMarshaller<HeaderFooterSectionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HeaderFooterSectionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLayout())
            {
                context.Writer.WritePropertyName("Layout");
                context.Writer.WriteObjectStart();

                var marshaller = SectionLayoutConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Layout, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSectionId())
            {
                context.Writer.WritePropertyName("SectionId");
                context.Writer.Write(requestObject.SectionId);
            }

            if(requestObject.IsSetStyle())
            {
                context.Writer.WritePropertyName("Style");
                context.Writer.WriteObjectStart();

                var marshaller = SectionStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.Style, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HeaderFooterSectionConfigurationMarshaller Instance = new HeaderFooterSectionConfigurationMarshaller();

    }
}