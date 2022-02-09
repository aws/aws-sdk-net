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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ControlScope Marshaller
    /// </summary>
    public class ControlScopeMarshaller : IRequestMarshaller<ControlScope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ControlScope requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetComplianceResourceIds())
            {
                context.Writer.WritePropertyName("ComplianceResourceIds");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComplianceResourceIdsListValue in requestObject.ComplianceResourceIds)
                {
                        context.Writer.Write(requestObjectComplianceResourceIdsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComplianceResourceTypes())
            {
                context.Writer.WritePropertyName("ComplianceResourceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectComplianceResourceTypesListValue in requestObject.ComplianceResourceTypes)
                {
                        context.Writer.Write(requestObjectComplianceResourceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ControlScopeMarshaller Instance = new ControlScopeMarshaller();

    }
}