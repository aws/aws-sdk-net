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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CheckpointConfigurationUpdate Marshaller
    /// </summary>
    public class CheckpointConfigurationUpdateMarshaller : IRequestMarshaller<CheckpointConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CheckpointConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCheckpointingEnabledUpdate())
            {
                context.Writer.WritePropertyName("CheckpointingEnabledUpdate");
                context.Writer.WriteBooleanValue(requestObject.CheckpointingEnabledUpdate.Value);
            }

            if(requestObject.IsSetCheckpointIntervalUpdate())
            {
                context.Writer.WritePropertyName("CheckpointIntervalUpdate");
                context.Writer.WriteNumberValue(requestObject.CheckpointIntervalUpdate.Value);
            }

            if(requestObject.IsSetConfigurationTypeUpdate())
            {
                context.Writer.WritePropertyName("ConfigurationTypeUpdate");
                context.Writer.WriteStringValue(requestObject.ConfigurationTypeUpdate);
            }

            if(requestObject.IsSetMinPauseBetweenCheckpointsUpdate())
            {
                context.Writer.WritePropertyName("MinPauseBetweenCheckpointsUpdate");
                context.Writer.WriteNumberValue(requestObject.MinPauseBetweenCheckpointsUpdate.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CheckpointConfigurationUpdateMarshaller Instance = new CheckpointConfigurationUpdateMarshaller();

    }
}