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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Synthetics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CanaryCodeInput Marshaller
    /// </summary>
    public class CanaryCodeInputMarshaller : IRequestMarshaller<CanaryCodeInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CanaryCodeInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlueprintTypes())
            {
                context.Writer.WritePropertyName("BlueprintTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBlueprintTypesListValue in requestObject.BlueprintTypes)
                {
                        context.Writer.Write(requestObjectBlueprintTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDependencies())
            {
                context.Writer.WritePropertyName("Dependencies");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDependenciesListValue in requestObject.Dependencies)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependenciesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetHandler())
            {
                context.Writer.WritePropertyName("Handler");
                context.Writer.Write(requestObject.Handler);
            }

            if(requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.Write(requestObject.S3Bucket);
            }

            if(requestObject.IsSetS3Key())
            {
                context.Writer.WritePropertyName("S3Key");
                context.Writer.Write(requestObject.S3Key);
            }

            if(requestObject.IsSetS3Version())
            {
                context.Writer.WritePropertyName("S3Version");
                context.Writer.Write(requestObject.S3Version);
            }

            if(requestObject.IsSetZipFile())
            {
                context.Writer.WritePropertyName("ZipFile");
                context.Writer.Write(StringUtils.FromMemoryStream(requestObject.ZipFile));
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CanaryCodeInputMarshaller Instance = new CanaryCodeInputMarshaller();

    }
}