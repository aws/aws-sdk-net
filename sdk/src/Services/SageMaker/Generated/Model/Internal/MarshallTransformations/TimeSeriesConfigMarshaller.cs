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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimeSeriesConfig Marshaller
    /// </summary>
    public class TimeSeriesConfigMarshaller : IRequestMarshaller<TimeSeriesConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TimeSeriesConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGroupingAttributeNames())
            {
                context.Writer.WritePropertyName("GroupingAttributeNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupingAttributeNamesListValue in requestObject.GroupingAttributeNames)
                {
                        context.Writer.Write(requestObjectGroupingAttributeNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetItemIdentifierAttributeName())
            {
                context.Writer.WritePropertyName("ItemIdentifierAttributeName");
                context.Writer.Write(requestObject.ItemIdentifierAttributeName);
            }

            if(requestObject.IsSetTargetAttributeName())
            {
                context.Writer.WritePropertyName("TargetAttributeName");
                context.Writer.Write(requestObject.TargetAttributeName);
            }

            if(requestObject.IsSetTimestampAttributeName())
            {
                context.Writer.WritePropertyName("TimestampAttributeName");
                context.Writer.Write(requestObject.TimestampAttributeName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimeSeriesConfigMarshaller Instance = new TimeSeriesConfigMarshaller();

    }
}