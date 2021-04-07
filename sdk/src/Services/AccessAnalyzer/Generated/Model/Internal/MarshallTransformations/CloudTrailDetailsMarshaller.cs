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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AccessAnalyzer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AccessAnalyzer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CloudTrailDetails Marshaller
    /// </summary>       
    public class CloudTrailDetailsMarshaller : IRequestMarshaller<CloudTrailDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CloudTrailDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessRole())
            {
                context.Writer.WritePropertyName("accessRole");
                context.Writer.Write(requestObject.AccessRole);
            }

            if(requestObject.IsSetEndTime())
            {
                context.Writer.WritePropertyName("endTime");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.EndTime));
            }

            if(requestObject.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.Write(StringUtils.FromDateTimeToISO8601(requestObject.StartTime));
            }

            if(requestObject.IsSetTrails())
            {
                context.Writer.WritePropertyName("trails");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTrailsListValue in requestObject.Trails)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TrailMarshaller.Instance;
                    marshaller.Marshall(requestObjectTrailsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static CloudTrailDetailsMarshaller Instance = new CloudTrailDetailsMarshaller();

    }
}