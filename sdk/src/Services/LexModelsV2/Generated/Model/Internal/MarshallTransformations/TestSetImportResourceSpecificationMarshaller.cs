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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TestSetImportResourceSpecification Marshaller
    /// </summary>
    public class TestSetImportResourceSpecificationMarshaller : IRequestMarshaller<TestSetImportResourceSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TestSetImportResourceSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetImportInputLocation())
            {
                context.Writer.WritePropertyName("importInputLocation");
                context.Writer.WriteObjectStart();

                var marshaller = TestSetImportInputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportInputLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetModality())
            {
                context.Writer.WritePropertyName("modality");
                context.Writer.Write(requestObject.Modality);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.Write(requestObject.RoleArn);
            }

            if(requestObject.IsSetStorageLocation())
            {
                context.Writer.WritePropertyName("storageLocation");
                context.Writer.WriteObjectStart();

                var marshaller = TestSetStorageLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageLocation, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTestSetName())
            {
                context.Writer.WritePropertyName("testSetName");
                context.Writer.Write(requestObject.TestSetName);
            }

            if(requestObject.IsSetTestSetTags())
            {
                context.Writer.WritePropertyName("testSetTags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTestSetTagsKvp in requestObject.TestSetTags)
                {
                    context.Writer.WritePropertyName(requestObjectTestSetTagsKvp.Key);
                    var requestObjectTestSetTagsValue = requestObjectTestSetTagsKvp.Value;

                        context.Writer.Write(requestObjectTestSetTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TestSetImportResourceSpecificationMarshaller Instance = new TestSetImportResourceSpecificationMarshaller();

    }
}