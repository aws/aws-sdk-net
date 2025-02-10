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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MitigationActionParams Marshaller
    /// </summary>
    public class MitigationActionParamsMarshaller : IRequestMarshaller<MitigationActionParams, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MitigationActionParams requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddThingsToThingGroupParams())
            {
                context.Writer.WritePropertyName("addThingsToThingGroupParams");
                context.Writer.WriteStartObject();

                var marshaller = AddThingsToThingGroupParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.AddThingsToThingGroupParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnableIoTLoggingParams())
            {
                context.Writer.WritePropertyName("enableIoTLoggingParams");
                context.Writer.WriteStartObject();

                var marshaller = EnableIoTLoggingParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.EnableIoTLoggingParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPublishFindingToSnsParams())
            {
                context.Writer.WritePropertyName("publishFindingToSnsParams");
                context.Writer.WriteStartObject();

                var marshaller = PublishFindingToSnsParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.PublishFindingToSnsParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplaceDefaultPolicyVersionParams())
            {
                context.Writer.WritePropertyName("replaceDefaultPolicyVersionParams");
                context.Writer.WriteStartObject();

                var marshaller = ReplaceDefaultPolicyVersionParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplaceDefaultPolicyVersionParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateCACertificateParams())
            {
                context.Writer.WritePropertyName("updateCACertificateParams");
                context.Writer.WriteStartObject();

                var marshaller = UpdateCACertificateParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateCACertificateParams, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateDeviceCertificateParams())
            {
                context.Writer.WritePropertyName("updateDeviceCertificateParams");
                context.Writer.WriteStartObject();

                var marshaller = UpdateDeviceCertificateParamsMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateDeviceCertificateParams, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MitigationActionParamsMarshaller Instance = new MitigationActionParamsMarshaller();

    }
}