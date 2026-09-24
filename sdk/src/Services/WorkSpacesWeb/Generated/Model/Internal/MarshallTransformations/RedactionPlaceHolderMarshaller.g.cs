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

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedactionPlaceHolder Marshaller
    /// </summary>
    public partial class RedactionPlaceHolderMarshaller : IRequestMarshaller<RedactionPlaceHolder, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(RedactionPlaceHolder requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetRedactionPlaceHolderText())
            {
                context.Writer.WritePropertyName("redactionPlaceHolderText");
                context.Writer.WriteStringValue(requestObject.RedactionPlaceHolderText);
            }

            if (requestObject.IsSetRedactionPlaceHolderType())
            {
                context.Writer.WritePropertyName("redactionPlaceHolderType");
                context.Writer.WriteStringValue(requestObject.RedactionPlaceHolderType);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static RedactionPlaceHolderMarshaller Instance = new RedactionPlaceHolderMarshaller();
    }
}
