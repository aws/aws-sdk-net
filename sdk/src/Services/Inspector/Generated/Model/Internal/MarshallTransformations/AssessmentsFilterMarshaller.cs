/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Inspector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssessmentsFilter Marshaller
    /// </summary>       
    public class AssessmentsFilterMarshaller : IRequestMarshaller<AssessmentsFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssessmentsFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssessmentNamePatterns())
            {
                context.Writer.WritePropertyName("assessmentNamePatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssessmentNamePatternsListValue in requestObject.AssessmentNamePatterns)
                {
                        context.Writer.Write(requestObjectAssessmentNamePatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAssessmentStates())
            {
                context.Writer.WritePropertyName("assessmentStates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssessmentStatesListValue in requestObject.AssessmentStates)
                {
                        context.Writer.Write(requestObjectAssessmentStatesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataCollected())
            {
                context.Writer.WritePropertyName("dataCollected");
                context.Writer.Write(requestObject.DataCollected);
            }

            if(requestObject.IsSetDurationRange())
            {
                context.Writer.WritePropertyName("durationRange");
                context.Writer.WriteObjectStart();

                var marshaller = DurationRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.DurationRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEndTimeRange())
            {
                context.Writer.WritePropertyName("endTimeRange");
                context.Writer.WriteObjectStart();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.EndTimeRange, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartTimeRange())
            {
                context.Writer.WritePropertyName("startTimeRange");
                context.Writer.WriteObjectStart();

                var marshaller = TimestampRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.StartTimeRange, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AssessmentsFilterMarshaller Instance = new AssessmentsFilterMarshaller();

    }
}