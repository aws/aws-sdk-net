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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EncryptionConfig Marshaller
    /// </summary>       
    public class EncryptionConfigMarshaller : IRequestMarshaller<EncryptionConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EncryptionConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetKMSKeyArn())
            {
                context.Writer.WritePropertyName("KMSKeyArn");
                context.Writer.Write(requestObject.KMSKeyArn);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EncryptionConfigMarshaller Instance = new EncryptionConfigMarshaller();

    }
}