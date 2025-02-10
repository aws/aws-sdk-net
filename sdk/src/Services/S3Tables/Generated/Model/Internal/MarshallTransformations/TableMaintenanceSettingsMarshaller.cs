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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Tables.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TableMaintenanceSettings Marshaller
    /// </summary>
    public class TableMaintenanceSettingsMarshaller : IRequestMarshaller<TableMaintenanceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableMaintenanceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIcebergCompaction())
            {
                context.Writer.WritePropertyName("icebergCompaction");
                context.Writer.WriteStartObject();

                var marshaller = IcebergCompactionSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.IcebergCompaction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIcebergSnapshotManagement())
            {
                context.Writer.WritePropertyName("icebergSnapshotManagement");
                context.Writer.WriteStartObject();

                var marshaller = IcebergSnapshotManagementSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.IcebergSnapshotManagement, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableMaintenanceSettingsMarshaller Instance = new TableMaintenanceSettingsMarshaller();

    }
}