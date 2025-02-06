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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutomaticTapeCreationRule Marshaller
    /// </summary>
    public class AutomaticTapeCreationRuleMarshaller : IRequestMarshaller<AutomaticTapeCreationRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomaticTapeCreationRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMinimumNumTapes())
            {
                context.Writer.WritePropertyName("MinimumNumTapes");
                context.Writer.WriteNumberValue(requestObject.MinimumNumTapes.Value);
            }

            if(requestObject.IsSetPoolId())
            {
                context.Writer.WritePropertyName("PoolId");
                context.Writer.WriteStringValue(requestObject.PoolId);
            }

            if(requestObject.IsSetTapeBarcodePrefix())
            {
                context.Writer.WritePropertyName("TapeBarcodePrefix");
                context.Writer.WriteStringValue(requestObject.TapeBarcodePrefix);
            }

            if(requestObject.IsSetTapeSizeInBytes())
            {
                context.Writer.WritePropertyName("TapeSizeInBytes");
                context.Writer.WriteNumberValue(requestObject.TapeSizeInBytes.Value);
            }

            if(requestObject.IsSetWorm())
            {
                context.Writer.WritePropertyName("Worm");
                context.Writer.WriteBooleanValue(requestObject.Worm.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomaticTapeCreationRuleMarshaller Instance = new AutomaticTapeCreationRuleMarshaller();

    }
}