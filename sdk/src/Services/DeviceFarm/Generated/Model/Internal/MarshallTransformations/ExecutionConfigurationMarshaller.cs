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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExecutionConfiguration Marshaller
    /// </summary>
    public class ExecutionConfigurationMarshaller : IRequestMarshaller<ExecutionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExecutionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountsCleanup())
            {
                context.Writer.WritePropertyName("accountsCleanup");
                context.Writer.WriteBooleanValue(requestObject.AccountsCleanup.Value);
            }

            if(requestObject.IsSetAppPackagesCleanup())
            {
                context.Writer.WritePropertyName("appPackagesCleanup");
                context.Writer.WriteBooleanValue(requestObject.AppPackagesCleanup.Value);
            }

            if(requestObject.IsSetJobTimeoutMinutes())
            {
                context.Writer.WritePropertyName("jobTimeoutMinutes");
                context.Writer.WriteNumberValue(requestObject.JobTimeoutMinutes.Value);
            }

            if(requestObject.IsSetSkipAppResign())
            {
                context.Writer.WritePropertyName("skipAppResign");
                context.Writer.WriteBooleanValue(requestObject.SkipAppResign.Value);
            }

            if(requestObject.IsSetVideoCapture())
            {
                context.Writer.WritePropertyName("videoCapture");
                context.Writer.WriteBooleanValue(requestObject.VideoCapture.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExecutionConfigurationMarshaller Instance = new ExecutionConfigurationMarshaller();

    }
}