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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsDmsReplicationTaskDetails Marshaller
    /// </summary>
    public class AwsDmsReplicationTaskDetailsMarshaller : IRequestMarshaller<AwsDmsReplicationTaskDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDmsReplicationTaskDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCdcStartPosition())
            {
                context.Writer.WritePropertyName("CdcStartPosition");
                context.Writer.WriteStringValue(requestObject.CdcStartPosition);
            }

            if(requestObject.IsSetCdcStartTime())
            {
                context.Writer.WritePropertyName("CdcStartTime");
                context.Writer.WriteStringValue(requestObject.CdcStartTime);
            }

            if(requestObject.IsSetCdcStopPosition())
            {
                context.Writer.WritePropertyName("CdcStopPosition");
                context.Writer.WriteStringValue(requestObject.CdcStopPosition);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetMigrationType())
            {
                context.Writer.WritePropertyName("MigrationType");
                context.Writer.WriteStringValue(requestObject.MigrationType);
            }

            if(requestObject.IsSetReplicationInstanceArn())
            {
                context.Writer.WritePropertyName("ReplicationInstanceArn");
                context.Writer.WriteStringValue(requestObject.ReplicationInstanceArn);
            }

            if(requestObject.IsSetReplicationTaskIdentifier())
            {
                context.Writer.WritePropertyName("ReplicationTaskIdentifier");
                context.Writer.WriteStringValue(requestObject.ReplicationTaskIdentifier);
            }

            if(requestObject.IsSetReplicationTaskSettings())
            {
                context.Writer.WritePropertyName("ReplicationTaskSettings");
                context.Writer.WriteStringValue(requestObject.ReplicationTaskSettings);
            }

            if(requestObject.IsSetResourceIdentifier())
            {
                context.Writer.WritePropertyName("ResourceIdentifier");
                context.Writer.WriteStringValue(requestObject.ResourceIdentifier);
            }

            if(requestObject.IsSetSourceEndpointArn())
            {
                context.Writer.WritePropertyName("SourceEndpointArn");
                context.Writer.WriteStringValue(requestObject.SourceEndpointArn);
            }

            if(requestObject.IsSetTableMappings())
            {
                context.Writer.WritePropertyName("TableMappings");
                context.Writer.WriteStringValue(requestObject.TableMappings);
            }

            if(requestObject.IsSetTargetEndpointArn())
            {
                context.Writer.WritePropertyName("TargetEndpointArn");
                context.Writer.WriteStringValue(requestObject.TargetEndpointArn);
            }

            if(requestObject.IsSetTaskData())
            {
                context.Writer.WritePropertyName("TaskData");
                context.Writer.WriteStringValue(requestObject.TaskData);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDmsReplicationTaskDetailsMarshaller Instance = new AwsDmsReplicationTaskDetailsMarshaller();

    }
}