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
    /// ActionTypeUrls Marshaller
    /// </summary>
    public partial class ActionTypeUrlsMarshaller : IRequestMarshaller<ActionTypeUrls, CborMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ActionTypeUrls requestObject, CborMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetConfigurationUrl())
            {
                context.Writer.WriteTextString("configurationUrl");
                context.Writer.WriteTextString(requestObject.ConfigurationUrl);
            }

            if (requestObject.IsSetEntityUrlTemplate())
            {
                context.Writer.WriteTextString("entityUrlTemplate");
                context.Writer.WriteTextString(requestObject.EntityUrlTemplate);
            }

            if (requestObject.IsSetExecutionUrlTemplate())
            {
                context.Writer.WriteTextString("executionUrlTemplate");
                context.Writer.WriteTextString(requestObject.ExecutionUrlTemplate);
            }

            if (requestObject.IsSetRevisionUrlTemplate())
            {
                context.Writer.WriteTextString("revisionUrlTemplate");
                context.Writer.WriteTextString(requestObject.RevisionUrlTemplate);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ActionTypeUrlsMarshaller Instance = new ActionTypeUrlsMarshaller();
    }
}
