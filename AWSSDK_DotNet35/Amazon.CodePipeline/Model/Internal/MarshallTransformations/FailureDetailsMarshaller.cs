/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FailureDetails Marshaller
    /// </summary>       
    public class FailureDetailsMarshaller : IRequestMarshaller<FailureDetails, JsonMarshallerContext> 
    {
        public void Marshall(FailureDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetExternalExecutionId())
            {
                context.Writer.WritePropertyName("externalExecutionId");
                context.Writer.Write(requestObject.ExternalExecutionId);
            }

            if(requestObject.IsSetMessage())
            {
                context.Writer.WritePropertyName("message");
                context.Writer.Write(requestObject.Message);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

        }

        public readonly static FailureDetailsMarshaller Instance = new FailureDetailsMarshaller();

    }
}