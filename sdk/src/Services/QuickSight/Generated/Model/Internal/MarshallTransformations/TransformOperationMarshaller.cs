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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransformOperation Marshaller
    /// </summary>       
    public class TransformOperationMarshaller : IRequestMarshaller<TransformOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransformOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCastColumnTypeOperation())
            {
                context.Writer.WritePropertyName("CastColumnTypeOperation");
                context.Writer.WriteObjectStart();

                var marshaller = CastColumnTypeOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.CastColumnTypeOperation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateColumnsOperation())
            {
                context.Writer.WritePropertyName("CreateColumnsOperation");
                context.Writer.WriteObjectStart();

                var marshaller = CreateColumnsOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateColumnsOperation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFilterOperation())
            {
                context.Writer.WritePropertyName("FilterOperation");
                context.Writer.WriteObjectStart();

                var marshaller = FilterOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.FilterOperation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetProjectOperation())
            {
                context.Writer.WritePropertyName("ProjectOperation");
                context.Writer.WriteObjectStart();

                var marshaller = ProjectOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.ProjectOperation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRenameColumnOperation())
            {
                context.Writer.WritePropertyName("RenameColumnOperation");
                context.Writer.WriteObjectStart();

                var marshaller = RenameColumnOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.RenameColumnOperation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTagColumnOperation())
            {
                context.Writer.WritePropertyName("TagColumnOperation");
                context.Writer.WriteObjectStart();

                var marshaller = TagColumnOperationMarshaller.Instance;
                marshaller.Marshall(requestObject.TagColumnOperation, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TransformOperationMarshaller Instance = new TransformOperationMarshaller();

    }
}