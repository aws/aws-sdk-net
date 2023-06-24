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
    /// ImportAssetsFromLakeFormationTagPolicyRequestDetails Marshaller
    /// </summary>
    public class ImportAssetsFromLakeFormationTagPolicyRequestDetailsMarshaller : IRequestMarshaller<ImportAssetsFromLakeFormationTagPolicyRequestDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImportAssetsFromLakeFormationTagPolicyRequestDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCatalogId())
            {
                context.Writer.WritePropertyName("CatalogId");
                context.Writer.Write(requestObject.CatalogId);
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseLFTagPolicyAndPermissionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Database, context);

                context.Writer.WriteObjectEnd();
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

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.WriteObjectStart();

                var marshaller = TableLFTagPolicyAndPermissionsMarshaller.Instance;
                marshaller.Marshall(requestObject.Table, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImportAssetsFromLakeFormationTagPolicyRequestDetailsMarshaller Instance = new ImportAssetsFromLakeFormationTagPolicyRequestDetailsMarshaller();

    }
}