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

using Amazon.BedrockAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActionGroupExecutor Marshaller
    /// </summary>
    public partial class ActionGroupExecutorMarshaller : IRequestMarshaller<ActionGroupExecutor, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionGroupExecutor requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCustomControl())
            {
                context.Writer.WritePropertyName("customControl");
                context.Writer.WriteStringValue(requestObject.CustomControl);
            }

            if (requestObject.IsSetLambda())
            {
                context.Writer.WritePropertyName("lambda");
                context.Writer.WriteStringValue(requestObject.Lambda);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionGroupExecutorMarshaller Instance = new ActionGroupExecutorMarshaller();
    }
}
