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

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisAnalyticsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplicationConfigurationUpdate Marshaller
    /// </summary>
    public class ApplicationConfigurationUpdateMarshaller : IRequestMarshaller<ApplicationConfigurationUpdate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApplicationConfigurationUpdate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApplicationCodeConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ApplicationCodeConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ApplicationCodeConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationCodeConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetApplicationEncryptionConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ApplicationEncryptionConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ApplicationEncryptionConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationEncryptionConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetApplicationSnapshotConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ApplicationSnapshotConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ApplicationSnapshotConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationSnapshotConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetApplicationSystemRollbackConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ApplicationSystemRollbackConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ApplicationSystemRollbackConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ApplicationSystemRollbackConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnvironmentPropertyUpdates())
            {
                context.Writer.WritePropertyName("EnvironmentPropertyUpdates");
                context.Writer.WriteObjectStart();

                var marshaller = EnvironmentPropertyUpdatesMarshaller.Instance;
                marshaller.Marshall(requestObject.EnvironmentPropertyUpdates, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFlinkApplicationConfigurationUpdate())
            {
                context.Writer.WritePropertyName("FlinkApplicationConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = FlinkApplicationConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.FlinkApplicationConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSqlApplicationConfigurationUpdate())
            {
                context.Writer.WritePropertyName("SqlApplicationConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = SqlApplicationConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlApplicationConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfigurationUpdates())
            {
                context.Writer.WritePropertyName("VpcConfigurationUpdates");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcConfigurationUpdatesListValue in requestObject.VpcConfigurationUpdates)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigurationUpdateMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcConfigurationUpdatesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetZeppelinApplicationConfigurationUpdate())
            {
                context.Writer.WritePropertyName("ZeppelinApplicationConfigurationUpdate");
                context.Writer.WriteObjectStart();

                var marshaller = ZeppelinApplicationConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ZeppelinApplicationConfigurationUpdate, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApplicationConfigurationUpdateMarshaller Instance = new ApplicationConfigurationUpdateMarshaller();

    }
}