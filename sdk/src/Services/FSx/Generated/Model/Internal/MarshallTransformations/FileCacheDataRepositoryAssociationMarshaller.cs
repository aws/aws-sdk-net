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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FileCacheDataRepositoryAssociation Marshaller
    /// </summary>
    public class FileCacheDataRepositoryAssociationMarshaller : IRequestMarshaller<FileCacheDataRepositoryAssociation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FileCacheDataRepositoryAssociation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDataRepositoryPath())
            {
                context.Writer.WritePropertyName("DataRepositoryPath");
                context.Writer.WriteStringValue(requestObject.DataRepositoryPath);
            }

            if(requestObject.IsSetDataRepositorySubdirectories())
            {
                context.Writer.WritePropertyName("DataRepositorySubdirectories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataRepositorySubdirectoriesListValue in requestObject.DataRepositorySubdirectories)
                {
                        context.Writer.WriteStringValue(requestObjectDataRepositorySubdirectoriesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFileCachePath())
            {
                context.Writer.WritePropertyName("FileCachePath");
                context.Writer.WriteStringValue(requestObject.FileCachePath);
            }

            if(requestObject.IsSetNFS())
            {
                context.Writer.WritePropertyName("NFS");
                context.Writer.WriteStartObject();

                var marshaller = FileCacheNFSConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.NFS, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FileCacheDataRepositoryAssociationMarshaller Instance = new FileCacheDataRepositoryAssociationMarshaller();

    }
}