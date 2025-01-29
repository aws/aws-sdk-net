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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsGuardDutyDetectorDetails Marshaller
    /// </summary>
    public class AwsGuardDutyDetectorDetailsMarshaller : IRequestMarshaller<AwsGuardDutyDetectorDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsGuardDutyDetectorDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("DataSources");
                context.Writer.WriteStartObject();

                var marshaller = AwsGuardDutyDetectorDataSourcesDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSources, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFeatures())
            {
                context.Writer.WritePropertyName("Features");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFeaturesListValue in requestObject.Features)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsGuardDutyDetectorFeaturesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectFeaturesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFindingPublishingFrequency())
            {
                context.Writer.WritePropertyName("FindingPublishingFrequency");
                context.Writer.WriteStringValue(requestObject.FindingPublishingFrequency);
            }

            if(requestObject.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("ServiceRole");
                context.Writer.WriteStringValue(requestObject.ServiceRole);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsGuardDutyDetectorDetailsMarshaller Instance = new AwsGuardDutyDetectorDetailsMarshaller();

    }
}