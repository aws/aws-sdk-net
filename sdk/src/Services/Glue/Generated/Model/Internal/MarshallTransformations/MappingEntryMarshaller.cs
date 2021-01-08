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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MappingEntry Marshaller
    /// </summary>       
    public class MappingEntryMarshaller : IRequestMarshaller<MappingEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MappingEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetSourcePath())
            {
                context.Writer.WritePropertyName("SourcePath");
                context.Writer.Write(requestObject.SourcePath);
            }

            if(requestObject.IsSetSourceTable())
            {
                context.Writer.WritePropertyName("SourceTable");
                context.Writer.Write(requestObject.SourceTable);
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.Write(requestObject.SourceType);
            }

            if(requestObject.IsSetTargetPath())
            {
                context.Writer.WritePropertyName("TargetPath");
                context.Writer.Write(requestObject.TargetPath);
            }

            if(requestObject.IsSetTargetTable())
            {
                context.Writer.WritePropertyName("TargetTable");
                context.Writer.Write(requestObject.TargetTable);
            }

            if(requestObject.IsSetTargetType())
            {
                context.Writer.WritePropertyName("TargetType");
                context.Writer.Write(requestObject.TargetType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static MappingEntryMarshaller Instance = new MappingEntryMarshaller();

    }
}