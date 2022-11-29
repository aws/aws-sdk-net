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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LakeConfigurationRequest Marshaller
    /// </summary>
    public class LakeConfigurationRequestMarshaller : IRequestMarshaller<LakeConfigurationRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LakeConfigurationRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEncryptionKey())
            {
                context.Writer.WritePropertyName("encryptionKey");
                context.Writer.Write(requestObject.EncryptionKey);
            }

            if(requestObject.IsSetReplicationDestinationRegions())
            {
                context.Writer.WritePropertyName("replicationDestinationRegions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReplicationDestinationRegionsListValue in requestObject.ReplicationDestinationRegions)
                {
                        context.Writer.Write(requestObjectReplicationDestinationRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReplicationRoleArn())
            {
                context.Writer.WritePropertyName("replicationRoleArn");
                context.Writer.Write(requestObject.ReplicationRoleArn);
            }

            if(requestObject.IsSetRetentionSettings())
            {
                context.Writer.WritePropertyName("retentionSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRetentionSettingsListValue in requestObject.RetentionSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RetentionSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectRetentionSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTagsMap())
            {
                context.Writer.WritePropertyName("tagsMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsMapKvp in requestObject.TagsMap)
                {
                    context.Writer.WritePropertyName(requestObjectTagsMapKvp.Key);
                    var requestObjectTagsMapValue = requestObjectTagsMapKvp.Value;

                        context.Writer.Write(requestObjectTagsMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LakeConfigurationRequestMarshaller Instance = new LakeConfigurationRequestMarshaller();

    }
}