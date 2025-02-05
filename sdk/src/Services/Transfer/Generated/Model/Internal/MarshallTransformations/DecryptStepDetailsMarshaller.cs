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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DecryptStepDetails Marshaller
    /// </summary>
    public class DecryptStepDetailsMarshaller : IRequestMarshaller<DecryptStepDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DecryptStepDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationFileLocation())
            {
                context.Writer.WritePropertyName("DestinationFileLocation");
                context.Writer.WriteStartObject();

                var marshaller = InputFileLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationFileLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOverwriteExisting())
            {
                context.Writer.WritePropertyName("OverwriteExisting");
                context.Writer.WriteStringValue(requestObject.OverwriteExisting);
            }

            if(requestObject.IsSetSourceFileLocation())
            {
                context.Writer.WritePropertyName("SourceFileLocation");
                context.Writer.WriteStringValue(requestObject.SourceFileLocation);
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
        public readonly static DecryptStepDetailsMarshaller Instance = new DecryptStepDetailsMarshaller();

    }
}