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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ControlTower.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ControlTower.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ControlOperationFilter Marshaller
    /// </summary>
    public class ControlOperationFilterMarshaller : IRequestMarshaller<ControlOperationFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ControlOperationFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetControlIdentifiers())
            {
                context.Writer.WritePropertyName("controlIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectControlIdentifiersListValue in requestObject.ControlIdentifiers)
                {
                        context.Writer.Write(requestObjectControlIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetControlOperationTypes())
            {
                context.Writer.WritePropertyName("controlOperationTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectControlOperationTypesListValue in requestObject.ControlOperationTypes)
                {
                        context.Writer.Write(requestObjectControlOperationTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnabledControlIdentifiers())
            {
                context.Writer.WritePropertyName("enabledControlIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnabledControlIdentifiersListValue in requestObject.EnabledControlIdentifiers)
                {
                        context.Writer.Write(requestObjectEnabledControlIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatuses())
            {
                context.Writer.WritePropertyName("statuses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStatusesListValue in requestObject.Statuses)
                {
                        context.Writer.Write(requestObjectStatusesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTargetIdentifiers())
            {
                context.Writer.WritePropertyName("targetIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetIdentifiersListValue in requestObject.TargetIdentifiers)
                {
                        context.Writer.Write(requestObjectTargetIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ControlOperationFilterMarshaller Instance = new ControlOperationFilterMarshaller();

    }
}