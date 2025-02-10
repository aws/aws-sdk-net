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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoAdjustData Marshaller
    /// </summary>
    public class AutoAdjustDataMarshaller : IRequestMarshaller<AutoAdjustData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoAdjustData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoAdjustType())
            {
                context.Writer.WritePropertyName("AutoAdjustType");
                context.Writer.WriteStringValue(requestObject.AutoAdjustType);
            }

            if(requestObject.IsSetHistoricalOptions())
            {
                context.Writer.WritePropertyName("HistoricalOptions");
                context.Writer.WriteStartObject();

                var marshaller = HistoricalOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.HistoricalOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLastAutoAdjustTime())
            {
                context.Writer.WritePropertyName("LastAutoAdjustTime");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(requestObject.LastAutoAdjustTime.Value)));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoAdjustDataMarshaller Instance = new AutoAdjustDataMarshaller();

    }
}