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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MigrationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MigrationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Task Marshaller
    /// </summary>
    public class TaskMarshaller : IRequestMarshaller<Task, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Task requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetProgressPercent())
            {
                context.Writer.WritePropertyName("ProgressPercent");
                context.Writer.WriteNumberValue(requestObject.ProgressPercent.Value);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetStatusDetail())
            {
                context.Writer.WritePropertyName("StatusDetail");
                context.Writer.WriteStringValue(requestObject.StatusDetail);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskMarshaller Instance = new TaskMarshaller();

    }
}