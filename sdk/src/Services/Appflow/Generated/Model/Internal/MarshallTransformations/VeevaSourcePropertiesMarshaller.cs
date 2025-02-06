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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// VeevaSourceProperties Marshaller
    /// </summary>
    public class VeevaSourcePropertiesMarshaller : IRequestMarshaller<VeevaSourceProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(VeevaSourceProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDocumentType())
            {
                context.Writer.WritePropertyName("documentType");
                context.Writer.WriteStringValue(requestObject.DocumentType);
            }

            if(requestObject.IsSetIncludeAllVersions())
            {
                context.Writer.WritePropertyName("includeAllVersions");
                context.Writer.WriteBooleanValue(requestObject.IncludeAllVersions.Value);
            }

            if(requestObject.IsSetIncludeRenditions())
            {
                context.Writer.WritePropertyName("includeRenditions");
                context.Writer.WriteBooleanValue(requestObject.IncludeRenditions.Value);
            }

            if(requestObject.IsSetIncludeSourceFiles())
            {
                context.Writer.WritePropertyName("includeSourceFiles");
                context.Writer.WriteBooleanValue(requestObject.IncludeSourceFiles.Value);
            }

            if(requestObject.IsSetObject())
            {
                context.Writer.WritePropertyName("object");
                context.Writer.WriteStringValue(requestObject.Object);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static VeevaSourcePropertiesMarshaller Instance = new VeevaSourcePropertiesMarshaller();

    }
}