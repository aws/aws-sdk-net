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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePipeSourceManagedStreamingKafkaParameters Marshaller
    /// </summary>
    public class UpdatePipeSourceManagedStreamingKafkaParametersMarshaller : IRequestMarshaller<UpdatePipeSourceManagedStreamingKafkaParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdatePipeSourceManagedStreamingKafkaParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchSize())
            {
                context.Writer.WritePropertyName("BatchSize");
                context.Writer.WriteNumberValue(requestObject.BatchSize.Value);
            }

            if(requestObject.IsSetCredentials())
            {
                context.Writer.WritePropertyName("Credentials");
                context.Writer.WriteStartObject();

                var marshaller = MSKAccessCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Credentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMaximumBatchingWindowInSeconds())
            {
                context.Writer.WritePropertyName("MaximumBatchingWindowInSeconds");
                context.Writer.WriteNumberValue(requestObject.MaximumBatchingWindowInSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdatePipeSourceManagedStreamingKafkaParametersMarshaller Instance = new UpdatePipeSourceManagedStreamingKafkaParametersMarshaller();

    }
}