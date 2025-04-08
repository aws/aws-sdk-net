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
    /// RegisteredUserConsoleFeatureConfigurations Marshaller
    /// </summary>
    public class RegisteredUserConsoleFeatureConfigurationsMarshaller : IRequestMarshaller<RegisteredUserConsoleFeatureConfigurations, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RegisteredUserConsoleFeatureConfigurations requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAmazonQInQuickSight())
            {
                context.Writer.WritePropertyName("AmazonQInQuickSight");
                context.Writer.WriteStartObject();

                var marshaller = AmazonQInQuickSightConsoleConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.AmazonQInQuickSight, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecentSnapshots())
            {
                context.Writer.WritePropertyName("RecentSnapshots");
                context.Writer.WriteStartObject();

                var marshaller = RecentSnapshotsConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.RecentSnapshots, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSchedules())
            {
                context.Writer.WritePropertyName("Schedules");
                context.Writer.WriteStartObject();

                var marshaller = SchedulesConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.Schedules, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSharedView())
            {
                context.Writer.WritePropertyName("SharedView");
                context.Writer.WriteStartObject();

                var marshaller = SharedViewConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.SharedView, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStatePersistence())
            {
                context.Writer.WritePropertyName("StatePersistence");
                context.Writer.WriteStartObject();

                var marshaller = StatePersistenceConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.StatePersistence, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetThresholdAlerts())
            {
                context.Writer.WritePropertyName("ThresholdAlerts");
                context.Writer.WriteStartObject();

                var marshaller = ThresholdAlertsConfigurationsMarshaller.Instance;
                marshaller.Marshall(requestObject.ThresholdAlerts, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RegisteredUserConsoleFeatureConfigurationsMarshaller Instance = new RegisteredUserConsoleFeatureConfigurationsMarshaller();

    }
}