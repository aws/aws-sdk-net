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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerFeatureStoreRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchGetRecordIdentifier Marshaller
    /// </summary>
    public class BatchGetRecordIdentifierMarshaller : IRequestMarshaller<BatchGetRecordIdentifier, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchGetRecordIdentifier requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetFeatureGroupName())
            {
                context.Writer.WritePropertyName("FeatureGroupName");
                context.Writer.Write(requestObject.FeatureGroupName);
            }

            if(requestObject.IsSetFeatureNames())
            {
                context.Writer.WritePropertyName("FeatureNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFeatureNamesListValue in requestObject.FeatureNames)
                {
                        context.Writer.Write(requestObjectFeatureNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRecordIdentifiersValueAsString())
            {
                context.Writer.WritePropertyName("RecordIdentifiersValueAsString");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRecordIdentifiersValueAsStringListValue in requestObject.RecordIdentifiersValueAsString)
                {
                        context.Writer.Write(requestObjectRecordIdentifiersValueAsStringListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchGetRecordIdentifierMarshaller Instance = new BatchGetRecordIdentifierMarshaller();

    }
}