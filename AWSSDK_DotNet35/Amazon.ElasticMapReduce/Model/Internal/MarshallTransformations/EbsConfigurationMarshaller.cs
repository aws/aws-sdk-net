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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EbsConfiguration Marshaller
    /// </summary>       
    public class EbsConfigurationMarshaller : IRequestMarshaller<EbsConfiguration, JsonMarshallerContext> 
    {
        public void Marshall(EbsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEbsBlockDeviceConfigs())
            {
                context.Writer.WritePropertyName("EbsBlockDeviceConfigs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEbsBlockDeviceConfigsListValue in requestObject.EbsBlockDeviceConfigs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EbsBlockDeviceConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectEbsBlockDeviceConfigsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEbsOptimized())
            {
                context.Writer.WritePropertyName("EbsOptimized");
                context.Writer.Write(requestObject.EbsOptimized);
            }

        }

        public readonly static EbsConfigurationMarshaller Instance = new EbsConfigurationMarshaller();

    }
}