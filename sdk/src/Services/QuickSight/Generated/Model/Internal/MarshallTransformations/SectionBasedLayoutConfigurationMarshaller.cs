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

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SectionBasedLayoutConfiguration Marshaller
    /// </summary>
    public class SectionBasedLayoutConfigurationMarshaller : IRequestMarshaller<SectionBasedLayoutConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SectionBasedLayoutConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBodySections())
            {
                context.Writer.WritePropertyName("BodySections");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBodySectionsListValue in requestObject.BodySections)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = BodySectionConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectBodySectionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCanvasSizeOptions())
            {
                context.Writer.WritePropertyName("CanvasSizeOptions");
                context.Writer.WriteObjectStart();

                var marshaller = SectionBasedLayoutCanvasSizeOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.CanvasSizeOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFooterSections())
            {
                context.Writer.WritePropertyName("FooterSections");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFooterSectionsListValue in requestObject.FooterSections)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HeaderFooterSectionConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectFooterSectionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHeaderSections())
            {
                context.Writer.WritePropertyName("HeaderSections");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHeaderSectionsListValue in requestObject.HeaderSections)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = HeaderFooterSectionConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeaderSectionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SectionBasedLayoutConfigurationMarshaller Instance = new SectionBasedLayoutConfigurationMarshaller();

    }
}