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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchRestrictions Marshaller
    /// </summary>
    public class BatchRestrictionsMarshaller : IRequestMarshaller<BatchRestrictions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchRestrictions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComputeTypesAllowed())
            {
                context.Writer.WritePropertyName("computeTypesAllowed");
                context.Writer.WriteStartArray();
                foreach(var requestObjectComputeTypesAllowedListValue in requestObject.ComputeTypesAllowed)
                {
                        context.Writer.WriteStringValue(requestObjectComputeTypesAllowedListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFleetsAllowed())
            {
                context.Writer.WritePropertyName("fleetsAllowed");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFleetsAllowedListValue in requestObject.FleetsAllowed)
                {
                        context.Writer.WriteStringValue(requestObjectFleetsAllowedListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaximumBuildsAllowed())
            {
                context.Writer.WritePropertyName("maximumBuildsAllowed");
                context.Writer.WriteNumberValue(requestObject.MaximumBuildsAllowed.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchRestrictionsMarshaller Instance = new BatchRestrictionsMarshaller();

    }
}