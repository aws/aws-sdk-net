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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisAnalyticsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SqlApplicationConfigurationUpdate Marshaller
    /// </summary>       
    public class SqlApplicationConfigurationUpdateMarshaller : IRequestMarshaller<SqlApplicationConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SqlApplicationConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInputUpdates())
            {
                context.Writer.WritePropertyName("InputUpdates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputUpdatesListValue in requestObject.InputUpdates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = InputUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectInputUpdatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOutputUpdates())
            {
                context.Writer.WritePropertyName("OutputUpdates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOutputUpdatesListValue in requestObject.OutputUpdates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OutputUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputUpdatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReferenceDataSourceUpdates())
            {
                context.Writer.WritePropertyName("ReferenceDataSourceUpdates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReferenceDataSourceUpdatesListValue in requestObject.ReferenceDataSourceUpdates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ReferenceDataSourceUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectReferenceDataSourceUpdatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SqlApplicationConfigurationUpdateMarshaller Instance = new SqlApplicationConfigurationUpdateMarshaller();

    }
}