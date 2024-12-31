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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BackupSearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BackupSearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EBSItemFilter Marshaller
    /// </summary>
    public class EBSItemFilterMarshaller : IRequestMarshaller<EBSItemFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EBSItemFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreationTimes())
            {
                context.Writer.WritePropertyName("CreationTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCreationTimesListValue in requestObject.CreationTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreationTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFilePaths())
            {
                context.Writer.WritePropertyName("FilePaths");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFilePathsListValue in requestObject.FilePaths)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectFilePathsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLastModificationTimes())
            {
                context.Writer.WritePropertyName("LastModificationTimes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLastModificationTimesListValue in requestObject.LastModificationTimes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TimeConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectLastModificationTimesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSizes())
            {
                context.Writer.WritePropertyName("Sizes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSizesListValue in requestObject.Sizes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LongConditionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSizesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EBSItemFilterMarshaller Instance = new EBSItemFilterMarshaller();

    }
}