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
    /// JoinInstruction Marshaller
    /// </summary>
    public class JoinInstructionMarshaller : IRequestMarshaller<JoinInstruction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JoinInstruction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLeftJoinKeyProperties())
            {
                context.Writer.WritePropertyName("LeftJoinKeyProperties");
                context.Writer.WriteStartObject();

                var marshaller = JoinKeyPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.LeftJoinKeyProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLeftOperand())
            {
                context.Writer.WritePropertyName("LeftOperand");
                context.Writer.WriteStringValue(requestObject.LeftOperand);
            }

            if(requestObject.IsSetOnClause())
            {
                context.Writer.WritePropertyName("OnClause");
                context.Writer.WriteStringValue(requestObject.OnClause);
            }

            if(requestObject.IsSetRightJoinKeyProperties())
            {
                context.Writer.WritePropertyName("RightJoinKeyProperties");
                context.Writer.WriteStartObject();

                var marshaller = JoinKeyPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.RightJoinKeyProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRightOperand())
            {
                context.Writer.WritePropertyName("RightOperand");
                context.Writer.WriteStringValue(requestObject.RightOperand);
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
        public readonly static JoinInstructionMarshaller Instance = new JoinInstructionMarshaller();

    }
}