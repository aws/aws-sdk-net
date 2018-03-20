/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudWatchEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Target Marshaller
    /// </summary>       
    public class TargetMarshaller : IRequestMarshaller<Target, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Target requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.Write(requestObject.Arn);
            }

            if(requestObject.IsSetBatchParameters())
            {
                context.Writer.WritePropertyName("BatchParameters");
                context.Writer.WriteObjectStart();

                var marshaller = BatchParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BatchParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEcsParameters())
            {
                context.Writer.WritePropertyName("EcsParameters");
                context.Writer.WriteObjectStart();

                var marshaller = EcsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EcsParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.Write(requestObject.Id);
            }

            if(requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("Input");
                context.Writer.Write(requestObject.Input);
            }

            if(requestObject.IsSetInputPath())
            {
                context.Writer.WritePropertyName("InputPath");
                context.Writer.Write(requestObject.InputPath);
            }

            if(requestObject.IsSetInputTransformer())
            {
                context.Writer.WritePropertyName("InputTransformer");
                context.Writer.WriteObjectStart();

                var marshaller = InputTransformerMarshaller.Instance;
                marshaller.Marshall(requestObject.InputTransformer, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKinesisParameters())
            {
                context.Writer.WritePropertyName("KinesisParameters");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetRunCommandParameters())
            {
                context.Writer.WritePropertyName("RunCommandParameters");
                context.Writer.WriteObjectStart();

                var marshaller = RunCommandParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.RunCommandParameters, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqsParameters())
            {
                context.Writer.WritePropertyName("SqsParameters");
                context.Writer.WriteObjectStart();

                var marshaller = SqsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsParameters, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TargetMarshaller Instance = new TargetMarshaller();

    }
}