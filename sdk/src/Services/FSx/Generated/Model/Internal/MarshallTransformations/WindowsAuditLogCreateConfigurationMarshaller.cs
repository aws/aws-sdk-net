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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// WindowsAuditLogCreateConfiguration Marshaller
    /// </summary>
    public class WindowsAuditLogCreateConfigurationMarshaller : IRequestMarshaller<WindowsAuditLogCreateConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WindowsAuditLogCreateConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuditLogDestination())
            {
                context.Writer.WritePropertyName("AuditLogDestination");
                context.Writer.WriteStringValue(requestObject.AuditLogDestination);
            }

            if(requestObject.IsSetFileAccessAuditLogLevel())
            {
                context.Writer.WritePropertyName("FileAccessAuditLogLevel");
                context.Writer.WriteStringValue(requestObject.FileAccessAuditLogLevel);
            }

            if(requestObject.IsSetFileShareAccessAuditLogLevel())
            {
                context.Writer.WritePropertyName("FileShareAccessAuditLogLevel");
                context.Writer.WriteStringValue(requestObject.FileShareAccessAuditLogLevel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WindowsAuditLogCreateConfigurationMarshaller Instance = new WindowsAuditLogCreateConfigurationMarshaller();

    }
}