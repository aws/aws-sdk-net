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
    /// Application Marshaller
    /// </summary>       
    public class ApplicationMarshaller : IRequestMarshaller<Application, JsonMarshallerContext> 
    {
        public void Marshall(Application requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalInfo())
            {
                context.Writer.WritePropertyName("AdditionalInfo");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalInfoKvp in requestObject.AdditionalInfo)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalInfoKvp.Key);
                    var requestObjectAdditionalInfoValue = requestObjectAdditionalInfoKvp.Value;

                        context.Writer.Write(requestObjectAdditionalInfoValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetArgs())
            {
                context.Writer.WritePropertyName("Args");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArgsListValue in requestObject.Args)
                {
                        context.Writer.Write(requestObjectArgsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetVersion())
            {
                context.Writer.WritePropertyName("Version");
                context.Writer.Write(requestObject.Version);
            }

        }

        public readonly static ApplicationMarshaller Instance = new ApplicationMarshaller();

    }
}