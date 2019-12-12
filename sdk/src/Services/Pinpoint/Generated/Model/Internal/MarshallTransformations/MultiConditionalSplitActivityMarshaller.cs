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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MultiConditionalSplitActivity Marshaller
    /// </summary>       
    public class MultiConditionalSplitActivityMarshaller : IRequestMarshaller<MultiConditionalSplitActivity, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MultiConditionalSplitActivity requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBranches())
            {
                context.Writer.WritePropertyName("Branches");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBranchesListValue in requestObject.Branches)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MultiConditionalBranchMarshaller.Instance;
                    marshaller.Marshall(requestObjectBranchesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDefaultActivity())
            {
                context.Writer.WritePropertyName("DefaultActivity");
                context.Writer.Write(requestObject.DefaultActivity);
            }

            if(requestObject.IsSetEvaluationWaitTime())
            {
                context.Writer.WritePropertyName("EvaluationWaitTime");
                context.Writer.WriteObjectStart();

                var marshaller = WaitTimeMarshaller.Instance;
                marshaller.Marshall(requestObject.EvaluationWaitTime, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MultiConditionalSplitActivityMarshaller Instance = new MultiConditionalSplitActivityMarshaller();

    }
}