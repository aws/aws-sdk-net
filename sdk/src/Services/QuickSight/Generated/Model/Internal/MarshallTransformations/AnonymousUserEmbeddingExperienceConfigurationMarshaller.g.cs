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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnonymousUserEmbeddingExperienceConfiguration Marshaller
    /// </summary>
    public partial class AnonymousUserEmbeddingExperienceConfigurationMarshaller : IRequestMarshaller<AnonymousUserEmbeddingExperienceConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(AnonymousUserEmbeddingExperienceConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDashboard())
            {
                context.Writer.WritePropertyName("Dashboard");
                context.Writer.WriteStartObject();

                var marshaller = AnonymousUserDashboardEmbeddingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.Dashboard, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetDashboardVisual())
            {
                context.Writer.WritePropertyName("DashboardVisual");
                context.Writer.WriteStartObject();

                var marshaller = AnonymousUserDashboardVisualEmbeddingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DashboardVisual, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetGenerativeQnA())
            {
                context.Writer.WritePropertyName("GenerativeQnA");
                context.Writer.WriteStartObject();

                var marshaller = AnonymousUserGenerativeQnAEmbeddingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerativeQnA, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetQSearchBar())
            {
                context.Writer.WritePropertyName("QSearchBar");
                context.Writer.WriteStartObject();

                var marshaller = AnonymousUserQSearchBarEmbeddingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.QSearchBar, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static AnonymousUserEmbeddingExperienceConfigurationMarshaller Instance = new AnonymousUserEmbeddingExperienceConfigurationMarshaller();
    }
}
