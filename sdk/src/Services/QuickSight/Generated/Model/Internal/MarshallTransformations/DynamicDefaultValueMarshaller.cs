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
    /// DynamicDefaultValue Marshaller
    /// </summary>
    public class DynamicDefaultValueMarshaller : IRequestMarshaller<DynamicDefaultValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DynamicDefaultValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultValueColumn())
            {
                context.Writer.WritePropertyName("DefaultValueColumn");
                context.Writer.WriteObjectStart();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValueColumn, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGroupNameColumn())
            {
                context.Writer.WritePropertyName("GroupNameColumn");
                context.Writer.WriteObjectStart();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.GroupNameColumn, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUserNameColumn())
            {
                context.Writer.WritePropertyName("UserNameColumn");
                context.Writer.WriteObjectStart();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.UserNameColumn, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DynamicDefaultValueMarshaller Instance = new DynamicDefaultValueMarshaller();

    }
}