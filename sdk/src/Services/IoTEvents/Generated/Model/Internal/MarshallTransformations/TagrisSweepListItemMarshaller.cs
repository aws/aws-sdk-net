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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTEvents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTEvents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TagrisSweepListItem Marshaller
    /// </summary>       
    public class TagrisSweepListItemMarshaller : IRequestMarshaller<TagrisSweepListItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TagrisSweepListItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetTagrisAccountId())
            {
                context.Writer.WritePropertyName("TagrisAccountId");
                context.Writer.Write(requestObject.TagrisAccountId);
            }

            if(requestObject.IsSetTagrisAmazonResourceName())
            {
                context.Writer.WritePropertyName("TagrisAmazonResourceName");
                context.Writer.Write(requestObject.TagrisAmazonResourceName);
            }

            if(requestObject.IsSetTagrisInternalId())
            {
                context.Writer.WritePropertyName("TagrisInternalId");
                context.Writer.Write(requestObject.TagrisInternalId);
            }

            if(requestObject.IsSetTagrisVersion())
            {
                context.Writer.WritePropertyName("TagrisVersion");
                context.Writer.Write(requestObject.TagrisVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TagrisSweepListItemMarshaller Instance = new TagrisSweepListItemMarshaller();

    }
}