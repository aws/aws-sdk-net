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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateLinkAttributes Marshaller
    /// </summary>       
    public class BatchUpdateLinkAttributesMarshaller : IRequestMarshaller<BatchUpdateLinkAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchUpdateLinkAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttributeUpdates())
            {
                context.Writer.WritePropertyName("AttributeUpdates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAttributeUpdatesListValue in requestObject.AttributeUpdates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LinkAttributeUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributeUpdatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTypedLinkSpecifier())
            {
                context.Writer.WritePropertyName("TypedLinkSpecifier");
                context.Writer.WriteObjectStart();

                var marshaller = TypedLinkSpecifierMarshaller.Instance;
                marshaller.Marshall(requestObject.TypedLinkSpecifier, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BatchUpdateLinkAttributesMarshaller Instance = new BatchUpdateLinkAttributesMarshaller();

    }
}