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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AmiDistributionConfiguration Marshaller
    /// </summary>       
    public class AmiDistributionConfigurationMarshaller : IRequestMarshaller<AmiDistributionConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AmiDistributionConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAmiTags())
            {
                context.Writer.WritePropertyName("amiTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAmiTagsKvp in requestObject.AmiTags)
                {
                    context.Writer.WritePropertyName(requestObjectAmiTagsKvp.Key);
                    var requestObjectAmiTagsValue = requestObjectAmiTagsKvp.Value;

                        context.Writer.Write(requestObjectAmiTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetLaunchPermission())
            {
                context.Writer.WritePropertyName("launchPermission");
                context.Writer.WriteObjectStart();

                var marshaller = LaunchPermissionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.LaunchPermission, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetTargetAccountIds())
            {
                context.Writer.WritePropertyName("targetAccountIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTargetAccountIdsListValue in requestObject.TargetAccountIds)
                {
                        context.Writer.Write(requestObjectTargetAccountIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AmiDistributionConfigurationMarshaller Instance = new AmiDistributionConfigurationMarshaller();

    }
}