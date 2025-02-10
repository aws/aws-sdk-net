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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AgentHierarchyGroups Marshaller
    /// </summary>
    public class AgentHierarchyGroupsMarshaller : IRequestMarshaller<AgentHierarchyGroups, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AgentHierarchyGroups requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetL1Ids())
            {
                context.Writer.WritePropertyName("L1Ids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectL1IdsListValue in requestObject.L1Ids)
                {
                        context.Writer.WriteStringValue(requestObjectL1IdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetL2Ids())
            {
                context.Writer.WritePropertyName("L2Ids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectL2IdsListValue in requestObject.L2Ids)
                {
                        context.Writer.WriteStringValue(requestObjectL2IdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetL3Ids())
            {
                context.Writer.WritePropertyName("L3Ids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectL3IdsListValue in requestObject.L3Ids)
                {
                        context.Writer.WriteStringValue(requestObjectL3IdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetL4Ids())
            {
                context.Writer.WritePropertyName("L4Ids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectL4IdsListValue in requestObject.L4Ids)
                {
                        context.Writer.WriteStringValue(requestObjectL4IdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetL5Ids())
            {
                context.Writer.WritePropertyName("L5Ids");
                context.Writer.WriteStartArray();
                foreach(var requestObjectL5IdsListValue in requestObject.L5Ids)
                {
                        context.Writer.WriteStringValue(requestObjectL5IdsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AgentHierarchyGroupsMarshaller Instance = new AgentHierarchyGroupsMarshaller();

    }
}