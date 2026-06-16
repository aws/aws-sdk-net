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
    /// RestoreFromBackupConfiguration Marshaller
    /// </summary>
    public class RestoreFromBackupConfigurationMarshaller : IRequestMarshaller<RestoreFromBackupConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RestoreFromBackupConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutonomousDatabaseBackupId())
            {
                context.Writer.WritePropertyName("autonomousDatabaseBackupId");
                context.Writer.WriteStringValue(requestObject.AutonomousDatabaseBackupId);
            }

            if(requestObject.IsSetCloneTableSpaceList())
            {
                context.Writer.WritePropertyName("cloneTableSpaceList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCloneTableSpaceListListValue in requestObject.CloneTableSpaceList)
                {
                        context.Writer.WriteNumberValue(requestObjectCloneTableSpaceListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCloneType())
            {
                context.Writer.WritePropertyName("cloneType");
                context.Writer.WriteStringValue(requestObject.CloneType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RestoreFromBackupConfigurationMarshaller Instance = new RestoreFromBackupConfigurationMarshaller();

    }
}