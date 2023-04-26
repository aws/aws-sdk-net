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
 * Do not modify this file. This file is generated from the appintegrations-2020-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppIntegrationsService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppIntegrationsService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FileConfiguration Marshaller
    /// </summary>
    public class FileConfigurationMarshaller : IRequestMarshaller<FileConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FileConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectFiltersKvp in requestObject.Filters)
                {
                    context.Writer.WritePropertyName(requestObjectFiltersKvp.Key);
                    var requestObjectFiltersValue = requestObjectFiltersKvp.Value;

                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectFiltersValueListValue in requestObjectFiltersValue)
                    {
                            context.Writer.Write(requestObjectFiltersValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetFolders())
            {
                context.Writer.WritePropertyName("Folders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFoldersListValue in requestObject.Folders)
                {
                        context.Writer.Write(requestObjectFoldersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FileConfigurationMarshaller Instance = new FileConfigurationMarshaller();

    }
}