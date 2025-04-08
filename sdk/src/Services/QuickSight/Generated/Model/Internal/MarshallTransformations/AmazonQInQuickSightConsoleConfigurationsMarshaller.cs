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
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AmazonQInQuickSightConsoleConfigurations Marshaller
    /// </summary>
    public class AmazonQInQuickSightConsoleConfigurationsMarshaller : IRequestMarshaller<AmazonQInQuickSightConsoleConfigurations, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AmazonQInQuickSightConsoleConfigurations requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataQnA())
            {
                context.Writer.WritePropertyName("DataQnA");
                context.Writer.WriteStartObject();

                var marshaller = DataQnAConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataQnA, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataStories())
            {
                context.Writer.WritePropertyName("DataStories");
                context.Writer.WriteStartObject();

                var marshaller = DataStoriesConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataStories, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExecutiveSummary())
            {
                context.Writer.WritePropertyName("ExecutiveSummary");
                context.Writer.WriteStartObject();

                var marshaller = ExecutiveSummaryConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExecutiveSummary, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGenerativeAuthoring())
            {
                context.Writer.WritePropertyName("GenerativeAuthoring");
                context.Writer.WriteStartObject();

                var marshaller = GenerativeAuthoringConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerativeAuthoring, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AmazonQInQuickSightConsoleConfigurationsMarshaller Instance = new AmazonQInQuickSightConsoleConfigurationsMarshaller();

    }
}