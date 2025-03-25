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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuntimeLogConfigurations Marshaller
    /// </summary>
    public class RuntimeLogConfigurationsMarshaller : IRequestMarshaller<RuntimeLogConfigurations, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuntimeLogConfigurations requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDeleteLocalStoreAfterUpload())
            {
                context.Writer.WritePropertyName("DeleteLocalStoreAfterUpload");
                context.Writer.WriteBooleanValue(requestObject.DeleteLocalStoreAfterUpload.Value);
            }

            if(requestObject.IsSetLocalStoreFileRotationMaxBytes())
            {
                context.Writer.WritePropertyName("LocalStoreFileRotationMaxBytes");
                context.Writer.WriteNumberValue(requestObject.LocalStoreFileRotationMaxBytes.Value);
            }

            if(requestObject.IsSetLocalStoreFileRotationMaxFiles())
            {
                context.Writer.WritePropertyName("LocalStoreFileRotationMaxFiles");
                context.Writer.WriteNumberValue(requestObject.LocalStoreFileRotationMaxFiles.Value);
            }

            if(requestObject.IsSetLocalStoreLocation())
            {
                context.Writer.WritePropertyName("LocalStoreLocation");
                context.Writer.WriteStringValue(requestObject.LocalStoreLocation);
            }

            if(requestObject.IsSetLogFlushLevel())
            {
                context.Writer.WritePropertyName("LogFlushLevel");
                context.Writer.WriteStringValue(requestObject.LogFlushLevel);
            }

            if(requestObject.IsSetLogLevel())
            {
                context.Writer.WritePropertyName("LogLevel");
                context.Writer.WriteStringValue(requestObject.LogLevel);
            }

            if(requestObject.IsSetUploadLog())
            {
                context.Writer.WritePropertyName("UploadLog");
                context.Writer.WriteBooleanValue(requestObject.UploadLog.Value);
            }

            if(requestObject.IsSetUploadPeriodMinutes())
            {
                context.Writer.WritePropertyName("UploadPeriodMinutes");
                context.Writer.WriteNumberValue(requestObject.UploadPeriodMinutes.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuntimeLogConfigurationsMarshaller Instance = new RuntimeLogConfigurationsMarshaller();

    }
}