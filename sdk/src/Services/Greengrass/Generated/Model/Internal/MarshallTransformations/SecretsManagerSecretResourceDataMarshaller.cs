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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SecretsManagerSecretResourceData Marshaller
    /// </summary>
    public class SecretsManagerSecretResourceDataMarshaller : IRequestMarshaller<SecretsManagerSecretResourceData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SecretsManagerSecretResourceData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalStagingLabelsToDownload())
            {
                context.Writer.WritePropertyName("AdditionalStagingLabelsToDownload");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalStagingLabelsToDownloadListValue in requestObject.AdditionalStagingLabelsToDownload)
                {
                        context.Writer.WriteStringValue(requestObjectAdditionalStagingLabelsToDownloadListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetARN())
            {
                context.Writer.WritePropertyName("ARN");
                context.Writer.WriteStringValue(requestObject.ARN);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SecretsManagerSecretResourceDataMarshaller Instance = new SecretsManagerSecretResourceDataMarshaller();

    }
}