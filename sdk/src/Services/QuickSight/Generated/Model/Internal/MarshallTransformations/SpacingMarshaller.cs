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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Spacing Marshaller
    /// </summary>
    public class SpacingMarshaller : IRequestMarshaller<Spacing, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Spacing requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBottom())
            {
                context.Writer.WritePropertyName("Bottom");
                context.Writer.Write(requestObject.Bottom);
            }

            if(requestObject.IsSetLeft())
            {
                context.Writer.WritePropertyName("Left");
                context.Writer.Write(requestObject.Left);
            }

            if(requestObject.IsSetRight())
            {
                context.Writer.WritePropertyName("Right");
                context.Writer.Write(requestObject.Right);
            }

            if(requestObject.IsSetTop())
            {
                context.Writer.WritePropertyName("Top");
                context.Writer.Write(requestObject.Top);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SpacingMarshaller Instance = new SpacingMarshaller();

    }
}