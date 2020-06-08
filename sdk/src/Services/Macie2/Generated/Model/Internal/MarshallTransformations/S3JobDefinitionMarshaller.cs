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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3JobDefinition Marshaller
    /// </summary>       
    public class S3JobDefinitionMarshaller : IRequestMarshaller<S3JobDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3JobDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketDefinitions())
            {
                context.Writer.WritePropertyName("bucketDefinitions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBucketDefinitionsListValue in requestObject.BucketDefinitions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = S3BucketDefinitionForJobMarshaller.Instance;
                    marshaller.Marshall(requestObjectBucketDefinitionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetScoping())
            {
                context.Writer.WritePropertyName("scoping");
                context.Writer.WriteObjectStart();

                var marshaller = ScopingMarshaller.Instance;
                marshaller.Marshall(requestObject.Scoping, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static S3JobDefinitionMarshaller Instance = new S3JobDefinitionMarshaller();

    }
}