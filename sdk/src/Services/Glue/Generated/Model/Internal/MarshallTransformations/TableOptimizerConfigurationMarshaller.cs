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
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TableOptimizerConfiguration Marshaller
    /// </summary>
    public class TableOptimizerConfigurationMarshaller : IRequestMarshaller<TableOptimizerConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableOptimizerConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCompactionConfiguration())
            {
                context.Writer.WritePropertyName("compactionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CompactionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CompactionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetOrphanFileDeletionConfiguration())
            {
                context.Writer.WritePropertyName("orphanFileDeletionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OrphanFileDeletionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OrphanFileDeletionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetentionConfiguration())
            {
                context.Writer.WritePropertyName("retentionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RetentionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RetentionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("vpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TableOptimizerVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableOptimizerConfigurationMarshaller Instance = new TableOptimizerConfigurationMarshaller();

    }
}