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

using Amazon.Pinpoint.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MultiConditionalSplitActivity Marshaller
    /// </summary>
    public partial class MultiConditionalSplitActivityMarshaller : IRequestMarshaller<MultiConditionalSplitActivity, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(MultiConditionalSplitActivity requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBranches())
            {
                context.Writer.WritePropertyName("Branches");
                context.Writer.WriteStartArray();
                foreach (var requestObjectBranchesListValue in requestObject.Branches)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MultiConditionalBranchMarshaller.Instance;
                    marshaller.Marshall(requestObjectBranchesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDefaultActivity())
            {
                context.Writer.WritePropertyName("DefaultActivity");
                context.Writer.WriteStringValue(requestObject.DefaultActivity);
            }

            if (requestObject.IsSetEvaluationWaitTime())
            {
                context.Writer.WritePropertyName("EvaluationWaitTime");
                context.Writer.WriteStartObject();

                var marshaller = WaitTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluationWaitTime, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static MultiConditionalSplitActivityMarshaller Instance = new MultiConditionalSplitActivityMarshaller();
    }
}
