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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateWebAppConfiguration Marshaller
    /// </summary>
    public class CreateWebAppConfigurationMarshaller : IRequestMarshaller<CreateWebAppConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateWebAppConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEhrRole())
            {
                context.Writer.WritePropertyName("ehrRole");
                context.Writer.WriteStringValue(requestObject.EhrRole);
            }

            if(requestObject.IsSetIdcInstanceId())
            {
                context.Writer.WritePropertyName("idcInstanceId");
                context.Writer.WriteStringValue(requestObject.IdcInstanceId);
            }

            if(requestObject.IsSetIdcRegion())
            {
                context.Writer.WritePropertyName("idcRegion");
                context.Writer.WriteStringValue(requestObject.IdcRegion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateWebAppConfigurationMarshaller Instance = new CreateWebAppConfigurationMarshaller();

    }
}