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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateInvokeConfiguration Marshaller
    /// </summary>
    public class UpdateInvokeConfigurationMarshaller : IRequestMarshaller<UpdateInvokeConfiguration, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateInvokeConfiguration requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetEventBusV2Parameters())
            {
                context.Writer.WriteTextString("EventBusV2Parameters");
                context.Writer.WriteStartMap(null);

                var marshaller = EventBusV2ParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.EventBusV2Parameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetHttpParameters())
            {
                context.Writer.WriteTextString("HttpParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = HttpParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.HttpParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetKinesisParameters())
            {
                context.Writer.WriteTextString("KinesisParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = KinesisParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetLambdaParameters())
            {
                context.Writer.WriteTextString("LambdaParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = LambdaParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetRoleArn())
            {
                context.Writer.WriteTextString("RoleArn");
                context.Writer.WriteTextString(requestObject.RoleArn);
            }
            if (requestObject.IsSetSnsParameters())
            {
                context.Writer.WriteTextString("SnsParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = SnsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetSqsParameters())
            {
                context.Writer.WriteTextString("SqsParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = SqsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.SqsParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetStepFunctionsParameters())
            {
                context.Writer.WriteTextString("StepFunctionsParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = StepFunctionsParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.StepFunctionsParameters, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetUniversalTargetParameters())
            {
                context.Writer.WriteTextString("UniversalTargetParameters");
                context.Writer.WriteStartMap(null);

                var marshaller = UniversalTargetParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.UniversalTargetParameters, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateInvokeConfigurationMarshaller Instance = new UpdateInvokeConfigurationMarshaller();

    }
}