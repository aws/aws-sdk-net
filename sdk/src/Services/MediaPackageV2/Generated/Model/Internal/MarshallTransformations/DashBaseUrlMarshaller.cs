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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackageV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaPackageV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DashBaseUrl Marshaller
    /// </summary>
    public class DashBaseUrlMarshaller : IRequestMarshaller<DashBaseUrl, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DashBaseUrl requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDvbPriority())
            {
                context.Writer.WritePropertyName("DvbPriority");
                context.Writer.WriteNumberValue(requestObject.DvbPriority.Value);
            }

            if(requestObject.IsSetDvbWeight())
            {
                context.Writer.WritePropertyName("DvbWeight");
                context.Writer.WriteNumberValue(requestObject.DvbWeight.Value);
            }

            if(requestObject.IsSetServiceLocation())
            {
                context.Writer.WritePropertyName("ServiceLocation");
                context.Writer.WriteStringValue(requestObject.ServiceLocation);
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("Url");
                context.Writer.WriteStringValue(requestObject.Url);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DashBaseUrlMarshaller Instance = new DashBaseUrlMarshaller();

    }
}