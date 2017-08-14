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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StorageDescriptor Marshaller
    /// </summary>       
    public class StorageDescriptorMarshaller : IRequestMarshaller<StorageDescriptor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StorageDescriptor requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBucketColumns())
            {
                context.Writer.WritePropertyName("BucketColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBucketColumnsListValue in requestObject.BucketColumns)
                {
                        context.Writer.Write(requestObjectBucketColumnsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetColumns())
            {
                context.Writer.WritePropertyName("Columns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnsListValue in requestObject.Columns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCompressed())
            {
                context.Writer.WritePropertyName("Compressed");
                context.Writer.Write(requestObject.Compressed);
            }

            if(requestObject.IsSetInputFormat())
            {
                context.Writer.WritePropertyName("InputFormat");
                context.Writer.Write(requestObject.InputFormat);
            }

            if(requestObject.IsSetLocation())
            {
                context.Writer.WritePropertyName("Location");
                context.Writer.Write(requestObject.Location);
            }

            if(requestObject.IsSetNumberOfBuckets())
            {
                context.Writer.WritePropertyName("NumberOfBuckets");
                context.Writer.Write(requestObject.NumberOfBuckets);
            }

            if(requestObject.IsSetOutputFormat())
            {
                context.Writer.WritePropertyName("OutputFormat");
                context.Writer.Write(requestObject.OutputFormat);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.Write(requestObjectParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSerdeInfo())
            {
                context.Writer.WritePropertyName("SerdeInfo");
                context.Writer.WriteObjectStart();

                var marshaller = SerDeInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.SerdeInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSkewedInfo())
            {
                context.Writer.WritePropertyName("SkewedInfo");
                context.Writer.WriteObjectStart();

                var marshaller = SkewedInfoMarshaller.Instance;
                marshaller.Marshall(requestObject.SkewedInfo, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSortColumns())
            {
                context.Writer.WritePropertyName("SortColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSortColumnsListValue in requestObject.SortColumns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OrderMarshaller.Instance;
                    marshaller.Marshall(requestObjectSortColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStoredAsSubDirectories())
            {
                context.Writer.WritePropertyName("StoredAsSubDirectories");
                context.Writer.Write(requestObject.StoredAsSubDirectories);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static StorageDescriptorMarshaller Instance = new StorageDescriptorMarshaller();

    }
}