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
    /// AttributeCondition Marshaller
    /// </summary>
    public class AttributeConditionMarshaller : IRequestMarshaller<AttributeCondition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeCondition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("ComparisonOperator");
                context.Writer.WriteStringValue(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetMatchCriteria())
            {
                context.Writer.WritePropertyName("MatchCriteria");
                context.Writer.WriteStartObject();

                var marshaller = MatchCriteriaMarshaller.Instance;
                marshaller.Marshall(requestObject.MatchCriteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetProficiencyLevel())
            {
                context.Writer.WritePropertyName("ProficiencyLevel");
                if(StringUtils.IsSpecialFloatValue(requestObject.ProficiencyLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.ProficiencyLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ProficiencyLevel.Value);
                }
            }

            if(requestObject.IsSetRange())
            {
                context.Writer.WritePropertyName("Range");
                context.Writer.WriteStartObject();

                var marshaller = RangeMarshaller.Instance;
                marshaller.Marshall(requestObject.Range, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetValue())
            {
                context.Writer.WritePropertyName("Value");
                context.Writer.WriteStringValue(requestObject.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeConditionMarshaller Instance = new AttributeConditionMarshaller();

    }
}