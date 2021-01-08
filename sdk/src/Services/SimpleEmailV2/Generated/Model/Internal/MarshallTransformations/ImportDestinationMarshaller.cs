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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportDestination Marshaller
    /// </summary>       
    public class ImportDestinationMarshaller : IRequestMarshaller<ImportDestination, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportDestination requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContactListDestination())
            {
                context.Writer.WritePropertyName("ContactListDestination");
                context.Writer.WriteObjectStart();

                var marshaller = ContactListDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.ContactListDestination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuppressionListDestination())
            {
                context.Writer.WritePropertyName("SuppressionListDestination");
                context.Writer.WriteObjectStart();

                var marshaller = SuppressionListDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.SuppressionListDestination, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ImportDestinationMarshaller Instance = new ImportDestinationMarshaller();

    }
}