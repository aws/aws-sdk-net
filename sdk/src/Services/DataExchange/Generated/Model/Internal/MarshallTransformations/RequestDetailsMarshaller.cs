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
    /// RequestDetails Marshaller
    /// </summary>
    public class RequestDetailsMarshaller : IRequestMarshaller<RequestDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RequestDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreateS3DataAccessFromS3Bucket())
            {
                context.Writer.WritePropertyName("CreateS3DataAccessFromS3Bucket");
                context.Writer.WriteObjectStart();

                var marshaller = CreateS3DataAccessFromS3BucketRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateS3DataAccessFromS3Bucket, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExportAssetsToS3())
            {
                context.Writer.WritePropertyName("ExportAssetsToS3");
                context.Writer.WriteObjectStart();

                var marshaller = ExportAssetsToS3RequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportAssetsToS3, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExportAssetToSignedUrl())
            {
                context.Writer.WritePropertyName("ExportAssetToSignedUrl");
                context.Writer.WriteObjectStart();

                var marshaller = ExportAssetToSignedUrlRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportAssetToSignedUrl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExportRevisionsToS3())
            {
                context.Writer.WritePropertyName("ExportRevisionsToS3");
                context.Writer.WriteObjectStart();

                var marshaller = ExportRevisionsToS3RequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ExportRevisionsToS3, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImportAssetFromApiGatewayApi())
            {
                context.Writer.WritePropertyName("ImportAssetFromApiGatewayApi");
                context.Writer.WriteObjectStart();

                var marshaller = ImportAssetFromApiGatewayApiRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportAssetFromApiGatewayApi, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImportAssetFromSignedUrl())
            {
                context.Writer.WritePropertyName("ImportAssetFromSignedUrl");
                context.Writer.WriteObjectStart();

                var marshaller = ImportAssetFromSignedUrlRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportAssetFromSignedUrl, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImportAssetsFromLakeFormationTagPolicy())
            {
                context.Writer.WritePropertyName("ImportAssetsFromLakeFormationTagPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = ImportAssetsFromLakeFormationTagPolicyRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportAssetsFromLakeFormationTagPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImportAssetsFromRedshiftDataShares())
            {
                context.Writer.WritePropertyName("ImportAssetsFromRedshiftDataShares");
                context.Writer.WriteObjectStart();

                var marshaller = ImportAssetsFromRedshiftDataSharesRequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportAssetsFromRedshiftDataShares, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImportAssetsFromS3())
            {
                context.Writer.WritePropertyName("ImportAssetsFromS3");
                context.Writer.WriteObjectStart();

                var marshaller = ImportAssetsFromS3RequestDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportAssetsFromS3, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RequestDetailsMarshaller Instance = new RequestDetailsMarshaller();

    }
}