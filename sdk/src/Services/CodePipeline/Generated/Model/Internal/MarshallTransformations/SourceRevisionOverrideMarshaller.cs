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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceRevisionOverride Marshaller
    /// </summary>
    public class SourceRevisionOverrideMarshaller : IRequestMarshaller<SourceRevisionOverride, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceRevisionOverride requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionName())
            {
                context.Writer.WritePropertyName("actionName");
                context.Writer.Write(requestObject.ActionName);
            }

            if(requestObject.IsSetRevisionType())
            {
                context.Writer.WritePropertyName("revisionType");
                context.Writer.Write(requestObject.RevisionType);
            }

            if(requestObject.IsSetRevisionValue())
            {
                context.Writer.WritePropertyName("revisionValue");
                context.Writer.Write(requestObject.RevisionValue);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceRevisionOverrideMarshaller Instance = new SourceRevisionOverrideMarshaller();

    }
}