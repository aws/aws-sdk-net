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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Plan Marshaller
    /// </summary>
    public class PlanMarshaller : IRequestMarshaller<Plan, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Plan requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetRotationIds())
            {
                context.Writer.WritePropertyName("RotationIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRotationIdsListValue in requestObject.RotationIds)
                {
                        context.Writer.Write(requestObjectRotationIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStages())
            {
                context.Writer.WritePropertyName("Stages");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStagesListValue in requestObject.Stages)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StageMarshaller.Instance;
                    marshaller.Marshall(requestObjectStagesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PlanMarshaller Instance = new PlanMarshaller();

    }
}