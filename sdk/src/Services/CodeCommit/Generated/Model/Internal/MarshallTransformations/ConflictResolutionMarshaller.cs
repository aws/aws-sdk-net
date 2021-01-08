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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConflictResolution Marshaller
    /// </summary>       
    public class ConflictResolutionMarshaller : IRequestMarshaller<ConflictResolution, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConflictResolution requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDeleteFiles())
            {
                context.Writer.WritePropertyName("deleteFiles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDeleteFilesListValue in requestObject.DeleteFiles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DeleteFileEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectDeleteFilesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetReplaceContents())
            {
                context.Writer.WritePropertyName("replaceContents");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReplaceContentsListValue in requestObject.ReplaceContents)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ReplaceContentEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplaceContentsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSetFileModes())
            {
                context.Writer.WritePropertyName("setFileModes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSetFileModesListValue in requestObject.SetFileModes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SetFileModeEntryMarshaller.Instance;
                    marshaller.Marshall(requestObjectSetFileModesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConflictResolutionMarshaller Instance = new ConflictResolutionMarshaller();

    }
}