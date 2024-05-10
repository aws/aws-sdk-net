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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnaplockRetentionPeriod Marshaller
    /// </summary>
    public class SnaplockRetentionPeriodMarshaller : IRequestMarshaller<SnaplockRetentionPeriod, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnaplockRetentionPeriod requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDefaultRetention())
            {
                context.Writer.WritePropertyName("DefaultRetention");
                context.Writer.WriteObjectStart();

                var marshaller = RetentionPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultRetention, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMaximumRetention())
            {
                context.Writer.WritePropertyName("MaximumRetention");
                context.Writer.WriteObjectStart();

                var marshaller = RetentionPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.MaximumRetention, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMinimumRetention())
            {
                context.Writer.WritePropertyName("MinimumRetention");
                context.Writer.WriteObjectStart();

                var marshaller = RetentionPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.MinimumRetention, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnaplockRetentionPeriodMarshaller Instance = new SnaplockRetentionPeriodMarshaller();

    }
}