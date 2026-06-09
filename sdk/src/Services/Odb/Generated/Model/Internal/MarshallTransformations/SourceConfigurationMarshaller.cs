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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceConfiguration Marshaller
    /// </summary>
    public class SourceConfigurationMarshaller : IRequestMarshaller<SourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloneToRefreshable())
            {
                context.Writer.WritePropertyName("cloneToRefreshable");
                context.Writer.WriteStartObject();

                var marshaller = CloneToRefreshableConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloneToRefreshable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrossRegionDataGuard())
            {
                context.Writer.WritePropertyName("crossRegionDataGuard");
                context.Writer.WriteStartObject();

                var marshaller = CrossRegionDataGuardConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CrossRegionDataGuard, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCrossRegionDisasterRecovery())
            {
                context.Writer.WritePropertyName("crossRegionDisasterRecovery");
                context.Writer.WriteStartObject();

                var marshaller = CrossRegionDisasterRecoveryConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CrossRegionDisasterRecovery, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseClone())
            {
                context.Writer.WritePropertyName("databaseClone");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseCloneConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseClone, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPointInTimeRestore())
            {
                context.Writer.WritePropertyName("pointInTimeRestore");
                context.Writer.WriteStartObject();

                var marshaller = PointInTimeRestoreConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PointInTimeRestore, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRestoreFromBackup())
            {
                context.Writer.WritePropertyName("restoreFromBackup");
                context.Writer.WriteStartObject();

                var marshaller = RestoreFromBackupConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RestoreFromBackup, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceConfigurationMarshaller Instance = new SourceConfigurationMarshaller();

    }
}