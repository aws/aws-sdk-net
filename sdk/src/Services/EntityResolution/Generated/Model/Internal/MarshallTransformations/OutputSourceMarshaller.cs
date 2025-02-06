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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OutputSource Marshaller
    /// </summary>
    public class OutputSourceMarshaller : IRequestMarshaller<OutputSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OutputSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplyNormalization())
            {
                context.Writer.WritePropertyName("applyNormalization");
                context.Writer.WriteBooleanValue(requestObject.ApplyNormalization.Value);
            }

            if(requestObject.IsSetKMSArn())
            {
                context.Writer.WritePropertyName("KMSArn");
                context.Writer.WriteStringValue(requestObject.KMSArn);
            }

            if(requestObject.IsSetOutput())
            {
                context.Writer.WritePropertyName("output");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputListValue in requestObject.Output)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputAttributeMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetOutputS3Path())
            {
                context.Writer.WritePropertyName("outputS3Path");
                context.Writer.WriteStringValue(requestObject.OutputS3Path);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OutputSourceMarshaller Instance = new OutputSourceMarshaller();

    }
}