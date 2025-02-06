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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetImportInputLocation())
            {
                context.Writer.WritePropertyName("importInputLocation");
                context.Writer.WriteStartObject();

                var marshaller = TestSetImportInputLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.ImportInputLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModality())
            {
                context.Writer.WritePropertyName("modality");
                context.Writer.WriteStringValue(requestObject.Modality);
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetStorageLocation())
            {
                context.Writer.WritePropertyName("storageLocation");
                context.Writer.WriteStartObject();

                var marshaller = TestSetStorageLocationMarshaller.Instance;
                marshaller.Marshall(requestObject.StorageLocation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTestSetName())
            {
                context.Writer.WritePropertyName("testSetName");
                context.Writer.WriteStringValue(requestObject.TestSetName);
            }

            if(requestObject.IsSetTestSetTags())
            {
                context.Writer.WritePropertyName("testSetTags");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTestSetTagsKvp in requestObject.TestSetTags)
                {
                    context.Writer.WritePropertyName(requestObjectTestSetTagsKvp.Key);
                    var requestObjectTestSetTagsValue = requestObjectTestSetTagsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectTestSetTagsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TestSetImportResourceSpecificationMarshaller Instance = new TestSetImportResourceSpecificationMarshaller();

    }
}