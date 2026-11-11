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

using Amazon.CodePipeline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionConfigurationProperty Marshaller
    /// </summary>
    public partial class ActionConfigurationPropertyMarshaller : IRequestMarshaller<ActionConfigurationProperty, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionConfigurationProperty requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDescription())
            {
                context.Writer.WriteTextString("description");
                context.Writer.WriteTextString(requestObject.Description);
            }

            if (requestObject.IsSetKey())
            {
                context.Writer.WriteTextString("key");
                context.Writer.WriteBoolean(requestObject.Key.Value);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WriteTextString("name");
                context.Writer.WriteTextString(requestObject.Name);
            }

            if (requestObject.IsSetQueryable())
            {
                context.Writer.WriteTextString("queryable");
                context.Writer.WriteBoolean(requestObject.Queryable.Value);
            }

            if (requestObject.IsSetRequired())
            {
                context.Writer.WriteTextString("required");
                context.Writer.WriteBoolean(requestObject.Required.Value);
            }

            if (requestObject.IsSetSecret())
            {
                context.Writer.WriteTextString("secret");
                context.Writer.WriteBoolean(requestObject.Secret.Value);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WriteTextString("type");
                context.Writer.WriteTextString(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionConfigurationPropertyMarshaller Instance = new ActionConfigurationPropertyMarshaller();
    }
}
