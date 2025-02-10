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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TimestreamSettings Marshaller
    /// </summary>
    public class TimestreamSettingsMarshaller : IRequestMarshaller<TimestreamSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TimestreamSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCdcInsertsAndUpdates())
            {
                context.Writer.WritePropertyName("CdcInsertsAndUpdates");
                context.Writer.WriteBooleanValue(requestObject.CdcInsertsAndUpdates.Value);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetEnableMagneticStoreWrites())
            {
                context.Writer.WritePropertyName("EnableMagneticStoreWrites");
                context.Writer.WriteBooleanValue(requestObject.EnableMagneticStoreWrites.Value);
            }

            if(requestObject.IsSetMagneticDuration())
            {
                context.Writer.WritePropertyName("MagneticDuration");
                context.Writer.WriteNumberValue(requestObject.MagneticDuration.Value);
            }

            if(requestObject.IsSetMemoryDuration())
            {
                context.Writer.WritePropertyName("MemoryDuration");
                context.Writer.WriteNumberValue(requestObject.MemoryDuration.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TimestreamSettingsMarshaller Instance = new TimestreamSettingsMarshaller();

    }
}