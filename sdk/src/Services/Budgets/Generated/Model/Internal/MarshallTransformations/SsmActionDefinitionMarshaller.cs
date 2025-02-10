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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SsmActionDefinition Marshaller
    /// </summary>
    public class SsmActionDefinitionMarshaller : IRequestMarshaller<SsmActionDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SsmActionDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionSubType())
            {
                context.Writer.WritePropertyName("ActionSubType");
                context.Writer.WriteStringValue(requestObject.ActionSubType);
            }

            if(requestObject.IsSetInstanceIds())
            {
                context.Writer.WritePropertyName("InstanceIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceIdsListValue in requestObject.InstanceIds)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("Region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SsmActionDefinitionMarshaller Instance = new SsmActionDefinitionMarshaller();

    }
}