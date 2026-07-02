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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LambdaMicrovms.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LambdaMicrovms.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MicrovmHooks Marshaller
    /// </summary>
    public class MicrovmHooksMarshaller : IRequestMarshaller<MicrovmHooks, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MicrovmHooks requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetResume())
            {
                context.Writer.WritePropertyName("resume");
                context.Writer.WriteStringValue(requestObject.Resume);
            }

            if(requestObject.IsSetResumeTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("resumeTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.ResumeTimeoutInSeconds.Value);
            }

            if(requestObject.IsSetRun())
            {
                context.Writer.WritePropertyName("run");
                context.Writer.WriteStringValue(requestObject.Run);
            }

            if(requestObject.IsSetRunTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("runTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.RunTimeoutInSeconds.Value);
            }

            if(requestObject.IsSetSuspend())
            {
                context.Writer.WritePropertyName("suspend");
                context.Writer.WriteStringValue(requestObject.Suspend);
            }

            if(requestObject.IsSetSuspendTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("suspendTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.SuspendTimeoutInSeconds.Value);
            }

            if(requestObject.IsSetTerminate())
            {
                context.Writer.WritePropertyName("terminate");
                context.Writer.WriteStringValue(requestObject.Terminate);
            }

            if(requestObject.IsSetTerminateTimeoutInSeconds())
            {
                context.Writer.WritePropertyName("terminateTimeoutInSeconds");
                context.Writer.WriteNumberValue(requestObject.TerminateTimeoutInSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MicrovmHooksMarshaller Instance = new MicrovmHooksMarshaller();

    }
}