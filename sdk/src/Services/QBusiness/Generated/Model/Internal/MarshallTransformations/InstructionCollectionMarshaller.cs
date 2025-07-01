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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstructionCollection Marshaller
    /// </summary>
    public class InstructionCollectionMarshaller : IRequestMarshaller<InstructionCollection, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstructionCollection requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomInstructions())
            {
                context.Writer.WritePropertyName("customInstructions");
                context.Writer.WriteStringValue(requestObject.CustomInstructions);
            }

            if(requestObject.IsSetExamples())
            {
                context.Writer.WritePropertyName("examples");
                context.Writer.WriteStringValue(requestObject.Examples);
            }

            if(requestObject.IsSetIdentity())
            {
                context.Writer.WritePropertyName("identity");
                context.Writer.WriteStringValue(requestObject.Identity);
            }

            if(requestObject.IsSetOutputStyle())
            {
                context.Writer.WritePropertyName("outputStyle");
                context.Writer.WriteStringValue(requestObject.OutputStyle);
            }

            if(requestObject.IsSetPerspective())
            {
                context.Writer.WritePropertyName("perspective");
                context.Writer.WriteStringValue(requestObject.Perspective);
            }

            if(requestObject.IsSetResponseLength())
            {
                context.Writer.WritePropertyName("responseLength");
                context.Writer.WriteStringValue(requestObject.ResponseLength);
            }

            if(requestObject.IsSetTargetAudience())
            {
                context.Writer.WritePropertyName("targetAudience");
                context.Writer.WriteStringValue(requestObject.TargetAudience);
            }

            if(requestObject.IsSetTone())
            {
                context.Writer.WritePropertyName("tone");
                context.Writer.WriteStringValue(requestObject.Tone);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstructionCollectionMarshaller Instance = new InstructionCollectionMarshaller();

    }
}