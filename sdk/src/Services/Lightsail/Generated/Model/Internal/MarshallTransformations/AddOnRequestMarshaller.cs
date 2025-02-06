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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddOnRequest Marshaller
    /// </summary>
    public class AddOnRequestMarshaller : IRequestMarshaller<AddOnRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AddOnRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddOnType())
            {
                context.Writer.WritePropertyName("addOnType");
                context.Writer.WriteStringValue(requestObject.AddOnType);
            }

            if(requestObject.IsSetAutoSnapshotAddOnRequest())
            {
                context.Writer.WritePropertyName("autoSnapshotAddOnRequest");
                context.Writer.WriteStartObject();

                var marshaller = AutoSnapshotAddOnRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AutoSnapshotAddOnRequest, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStopInstanceOnIdleRequest())
            {
                context.Writer.WritePropertyName("stopInstanceOnIdleRequest");
                context.Writer.WriteStartObject();

                var marshaller = StopInstanceOnIdleRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.StopInstanceOnIdleRequest, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AddOnRequestMarshaller Instance = new AddOnRequestMarshaller();

    }
}