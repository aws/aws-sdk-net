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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SearchScope Marshaller
    /// </summary>
    public class SearchScopeMarshaller : IRequestMarshaller<SearchScope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SearchScope requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackupResourceArns())
            {
                context.Writer.WritePropertyName("BackupResourceArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBackupResourceArnsListValue in requestObject.BackupResourceArns)
                {
                        context.Writer.WriteStringValue(requestObjectBackupResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBackupResourceCreationTime())
            {
                context.Writer.WritePropertyName("BackupResourceCreationTime");
                context.Writer.WriteStartObject();

                var marshaller = BackupCreationTimeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.BackupResourceCreationTime, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBackupResourceTags())
            {
                context.Writer.WritePropertyName("BackupResourceTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectBackupResourceTagsKvp in requestObject.BackupResourceTags)
                {
                    context.Writer.WritePropertyName(requestObjectBackupResourceTagsKvp.Key);
                    var requestObjectBackupResourceTagsValue = requestObjectBackupResourceTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectBackupResourceTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBackupResourceTypes())
            {
                context.Writer.WritePropertyName("BackupResourceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectBackupResourceTypesListValue in requestObject.BackupResourceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectBackupResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceResourceArns())
            {
                context.Writer.WritePropertyName("SourceResourceArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourceResourceArnsListValue in requestObject.SourceResourceArns)
                {
                        context.Writer.WriteStringValue(requestObjectSourceResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SearchScopeMarshaller Instance = new SearchScopeMarshaller();

    }
}