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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MalaysiaAdditionalInfo Marshaller
    /// </summary>
    public class MalaysiaAdditionalInfoMarshaller : IRequestMarshaller<MalaysiaAdditionalInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MalaysiaAdditionalInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBusinessRegistrationNumber())
            {
                context.Writer.WritePropertyName("businessRegistrationNumber");
                context.Writer.WriteStringValue(requestObject.BusinessRegistrationNumber);
            }

            if(requestObject.IsSetServiceTaxCodes())
            {
                context.Writer.WritePropertyName("serviceTaxCodes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectServiceTaxCodesListValue in requestObject.ServiceTaxCodes)
                {
                        context.Writer.WriteStringValue(requestObjectServiceTaxCodesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaxInformationNumber())
            {
                context.Writer.WritePropertyName("taxInformationNumber");
                context.Writer.WriteStringValue(requestObject.TaxInformationNumber);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MalaysiaAdditionalInfoMarshaller Instance = new MalaysiaAdditionalInfoMarshaller();

    }
}