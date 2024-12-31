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
    /// EnabledBaselineFilter Marshaller
    /// </summary>
    public class EnabledBaselineFilterMarshaller : IRequestMarshaller<EnabledBaselineFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EnabledBaselineFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBaselineIdentifiers())
            {
                context.Writer.WritePropertyName("baselineIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBaselineIdentifiersListValue in requestObject.BaselineIdentifiers)
                {
                        context.Writer.Write(requestObjectBaselineIdentifiersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetParentIdentifiers())
            {
                context.Writer.WritePropertyName("parentIdentifiers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectParentIdentifiersListValue in requestObject.ParentIdentifiers)
                {
                        context.Writer.Write(requestObjectParentIdentifiersListValue);
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
        public readonly static EnabledBaselineFilterMarshaller Instance = new EnabledBaselineFilterMarshaller();

    }
}