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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipelineDefinitionS3Location Marshaller
    /// </summary>
    public class PipelineDefinitionS3LocationMarshaller : IRequestMarshaller<PipelineDefinitionS3Location, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipelineDefinitionS3Location requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("Bucket");
                context.Writer.Write(requestObject.Bucket);
            }

            if(requestObject.IsSetObjectKey())
            {
                context.Writer.WritePropertyName("ObjectKey");
                context.Writer.Write(requestObject.ObjectKey);
            }

            if(requestObject.IsSetVersionId())
            {
                context.Writer.WritePropertyName("VersionId");
                context.Writer.Write(requestObject.VersionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipelineDefinitionS3LocationMarshaller Instance = new PipelineDefinitionS3LocationMarshaller();

    }
}