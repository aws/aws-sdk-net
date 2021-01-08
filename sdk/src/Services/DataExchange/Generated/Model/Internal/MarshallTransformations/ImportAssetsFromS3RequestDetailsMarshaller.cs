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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportAssetsFromS3RequestDetails Marshaller
    /// </summary>       
    public class ImportAssetsFromS3RequestDetailsMarshaller : IRequestMarshaller<ImportAssetsFromS3RequestDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportAssetsFromS3RequestDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssetSources())
            {
                context.Writer.WritePropertyName("AssetSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssetSourcesListValue in requestObject.AssetSources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetSourceEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssetSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSetId())
            {
                context.Writer.WritePropertyName("DataSetId");
                context.Writer.Write(requestObject.DataSetId);
            }

            if(requestObject.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.Write(requestObject.RevisionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ImportAssetsFromS3RequestDetailsMarshaller Instance = new ImportAssetsFromS3RequestDetailsMarshaller();

    }
}