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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCases.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCases.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FieldOptionsCaseRule Marshaller
    /// </summary>
    public class FieldOptionsCaseRuleMarshaller : IRequestMarshaller<FieldOptionsCaseRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FieldOptionsCaseRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChildFieldId())
            {
                context.Writer.WritePropertyName("childFieldId");
                context.Writer.WriteStringValue(requestObject.ChildFieldId);
            }

            if(requestObject.IsSetParentChildFieldOptionsMappings())
            {
                context.Writer.WritePropertyName("parentChildFieldOptionsMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectParentChildFieldOptionsMappingsListValue in requestObject.ParentChildFieldOptionsMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ParentChildFieldOptionsMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectParentChildFieldOptionsMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetParentFieldId())
            {
                context.Writer.WritePropertyName("parentFieldId");
                context.Writer.WriteStringValue(requestObject.ParentFieldId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FieldOptionsCaseRuleMarshaller Instance = new FieldOptionsCaseRuleMarshaller();

    }
}