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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExperimentTemplateReportConfigurationInput Marshaller
    /// </summary>
    public class CreateExperimentTemplateReportConfigurationInputMarshaller : IRequestMarshaller<CreateExperimentTemplateReportConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateExperimentTemplateReportConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("dataSources");
                context.Writer.WriteObjectStart();

                var marshaller = ExperimentTemplateReportConfigurationDataSourcesInputMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSources, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOutputs())
            {
                context.Writer.WritePropertyName("outputs");
                context.Writer.WriteObjectStart();

                var marshaller = ExperimentTemplateReportConfigurationOutputsInputMarshaller.Instance;
                marshaller.Marshall(requestObject.Outputs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPostExperimentDuration())
            {
                context.Writer.WritePropertyName("postExperimentDuration");
                context.Writer.Write(requestObject.PostExperimentDuration);
            }

            if(requestObject.IsSetPreExperimentDuration())
            {
                context.Writer.WritePropertyName("preExperimentDuration");
                context.Writer.Write(requestObject.PreExperimentDuration);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateExperimentTemplateReportConfigurationInputMarshaller Instance = new CreateExperimentTemplateReportConfigurationInputMarshaller();

    }
}