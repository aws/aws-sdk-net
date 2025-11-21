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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JoinOperation Marshaller
    /// </summary>
    public class JoinOperationMarshaller : IRequestMarshaller<JoinOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JoinOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlias())
            {
                context.Writer.WritePropertyName("Alias");
                context.Writer.WriteStringValue(requestObject.Alias);
            }

            if(requestObject.IsSetLeftOperand())
            {
                context.Writer.WritePropertyName("LeftOperand");
                context.Writer.WriteStartObject();

                var marshaller = TransformOperationSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.LeftOperand, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLeftOperandProperties())
            {
                context.Writer.WritePropertyName("LeftOperandProperties");
                context.Writer.WriteStartObject();

                var marshaller = JoinOperandPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.LeftOperandProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnClause())
            {
                context.Writer.WritePropertyName("OnClause");
                context.Writer.WriteStringValue(requestObject.OnClause);
            }

            if(requestObject.IsSetRightOperand())
            {
                context.Writer.WritePropertyName("RightOperand");
                context.Writer.WriteStartObject();

                var marshaller = TransformOperationSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.RightOperand, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRightOperandProperties())
            {
                context.Writer.WritePropertyName("RightOperandProperties");
                context.Writer.WriteStartObject();

                var marshaller = JoinOperandPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.RightOperandProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JoinOperationMarshaller Instance = new JoinOperationMarshaller();

    }
}