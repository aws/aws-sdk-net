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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ConnectCases.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RelatedItemsConfiguration Marshaller
    /// </summary>
    public partial class RelatedItemsConfigurationMarshaller : IRequestMarshaller<RelatedItemsConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RelatedItemsConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetComment())
            {
                context.Writer.WritePropertyName("comment");
                context.Writer.WriteBooleanValue(requestObject.Comment.Value);
            }

            if (requestObject.IsSetConnectCase())
            {
                context.Writer.WritePropertyName("connectCase");
                context.Writer.WriteBooleanValue(requestObject.ConnectCase.Value);
            }

            if (requestObject.IsSetContact())
            {
                context.Writer.WritePropertyName("contact");
                context.Writer.WriteBooleanValue(requestObject.Contact.Value);
            }

            if (requestObject.IsSetCustom())
            {
                context.Writer.WritePropertyName("custom");
                context.Writer.WriteBooleanValue(requestObject.Custom.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RelatedItemsConfigurationMarshaller Instance = new RelatedItemsConfigurationMarshaller();
    }
}
