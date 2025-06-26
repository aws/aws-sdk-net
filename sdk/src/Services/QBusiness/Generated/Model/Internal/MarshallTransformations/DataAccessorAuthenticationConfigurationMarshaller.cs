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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataAccessorAuthenticationConfiguration Marshaller
    /// </summary>
    public class DataAccessorAuthenticationConfigurationMarshaller : IRequestMarshaller<DataAccessorAuthenticationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataAccessorAuthenticationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIdcTrustedTokenIssuerConfiguration())
            {
                context.Writer.WritePropertyName("idcTrustedTokenIssuerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataAccessorIdcTrustedTokenIssuerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.IdcTrustedTokenIssuerConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataAccessorAuthenticationConfigurationMarshaller Instance = new DataAccessorAuthenticationConfigurationMarshaller();

    }
}