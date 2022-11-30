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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataQualityResultFilterCriteria Marshaller
    /// </summary>
    public class DataQualityResultFilterCriteriaMarshaller : IRequestMarshaller<DataQualityResultFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataQualityResultFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataSource())
            {
                context.Writer.WritePropertyName("DataSource");
                context.Writer.WriteObjectStart();

                var marshaller = DataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSource, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.Write(requestObject.JobName);
            }

            if(requestObject.IsSetJobRunId())
            {
                context.Writer.WritePropertyName("JobRunId");
                context.Writer.Write(requestObject.JobRunId);
            }

            if(requestObject.IsSetStartedAfter())
            {
                context.Writer.WritePropertyName("StartedAfter");
                context.Writer.Write(requestObject.StartedAfter);
            }

            if(requestObject.IsSetStartedBefore())
            {
                context.Writer.WritePropertyName("StartedBefore");
                context.Writer.Write(requestObject.StartedBefore);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataQualityResultFilterCriteriaMarshaller Instance = new DataQualityResultFilterCriteriaMarshaller();

    }
}