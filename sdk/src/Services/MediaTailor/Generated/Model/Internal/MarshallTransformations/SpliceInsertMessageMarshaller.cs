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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SpliceInsertMessage Marshaller
    /// </summary>       
    public class SpliceInsertMessageMarshaller : IRequestMarshaller<SpliceInsertMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SpliceInsertMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAvailNum())
            {
                context.Writer.WritePropertyName("AvailNum");
                context.Writer.Write(requestObject.AvailNum);
            }

            if(requestObject.IsSetAvailsExpected())
            {
                context.Writer.WritePropertyName("AvailsExpected");
                context.Writer.Write(requestObject.AvailsExpected);
            }

            if(requestObject.IsSetSpliceEventId())
            {
                context.Writer.WritePropertyName("SpliceEventId");
                context.Writer.Write(requestObject.SpliceEventId);
            }

            if(requestObject.IsSetUniqueProgramId())
            {
                context.Writer.WritePropertyName("UniqueProgramId");
                context.Writer.Write(requestObject.UniqueProgramId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SpliceInsertMessageMarshaller Instance = new SpliceInsertMessageMarshaller();

    }
}