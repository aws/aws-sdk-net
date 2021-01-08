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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnomalyMonitor Marshaller
    /// </summary>       
    public class AnomalyMonitorMarshaller : IRequestMarshaller<AnomalyMonitor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AnomalyMonitor requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreationDate())
            {
                context.Writer.WritePropertyName("CreationDate");
                context.Writer.Write(requestObject.CreationDate);
            }

            if(requestObject.IsSetDimensionalValueCount())
            {
                context.Writer.WritePropertyName("DimensionalValueCount");
                context.Writer.Write(requestObject.DimensionalValueCount);
            }

            if(requestObject.IsSetLastEvaluatedDate())
            {
                context.Writer.WritePropertyName("LastEvaluatedDate");
                context.Writer.Write(requestObject.LastEvaluatedDate);
            }

            if(requestObject.IsSetLastUpdatedDate())
            {
                context.Writer.WritePropertyName("LastUpdatedDate");
                context.Writer.Write(requestObject.LastUpdatedDate);
            }

            if(requestObject.IsSetMonitorArn())
            {
                context.Writer.WritePropertyName("MonitorArn");
                context.Writer.Write(requestObject.MonitorArn);
            }

            if(requestObject.IsSetMonitorDimension())
            {
                context.Writer.WritePropertyName("MonitorDimension");
                context.Writer.Write(requestObject.MonitorDimension);
            }

            if(requestObject.IsSetMonitorName())
            {
                context.Writer.WritePropertyName("MonitorName");
                context.Writer.Write(requestObject.MonitorName);
            }

            if(requestObject.IsSetMonitorSpecification())
            {
                context.Writer.WritePropertyName("MonitorSpecification");
                context.Writer.WriteObjectStart();

                var marshaller = ExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.MonitorSpecification, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMonitorType())
            {
                context.Writer.WritePropertyName("MonitorType");
                context.Writer.Write(requestObject.MonitorType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AnomalyMonitorMarshaller Instance = new AnomalyMonitorMarshaller();

    }
}