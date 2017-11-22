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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CertificateManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CertificateManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Filters Marshaller
    /// </summary>       
    public class FiltersMarshaller : IRequestMarshaller<Filters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Filters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExtendedKeyUsage())
            {
                context.Writer.WritePropertyName("extendedKeyUsage");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExtendedKeyUsageListValue in requestObject.ExtendedKeyUsage)
                {
                        context.Writer.Write(requestObjectExtendedKeyUsageListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeyTypes())
            {
                context.Writer.WritePropertyName("keyTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKeyTypesListValue in requestObject.KeyTypes)
                {
                        context.Writer.Write(requestObjectKeyTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("keyUsage");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectKeyUsageListValue in requestObject.KeyUsage)
                {
                        context.Writer.Write(requestObjectKeyUsageListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FiltersMarshaller Instance = new FiltersMarshaller();

    }
}