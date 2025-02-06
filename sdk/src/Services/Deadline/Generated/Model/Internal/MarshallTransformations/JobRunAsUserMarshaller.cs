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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobRunAsUser Marshaller
    /// </summary>
    public class JobRunAsUserMarshaller : IRequestMarshaller<JobRunAsUser, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobRunAsUser requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPosix())
            {
                context.Writer.WritePropertyName("posix");
                context.Writer.WriteStartObject();

                var marshaller = PosixUserMarshaller.Instance;
                marshaller.Marshall(requestObject.Posix, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRunAs())
            {
                context.Writer.WritePropertyName("runAs");
                context.Writer.WriteStringValue(requestObject.RunAs);
            }

            if(requestObject.IsSetWindows())
            {
                context.Writer.WritePropertyName("windows");
                context.Writer.WriteStartObject();

                var marshaller = WindowsUserMarshaller.Instance;
                marshaller.Marshall(requestObject.Windows, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobRunAsUserMarshaller Instance = new JobRunAsUserMarshaller();

    }
}