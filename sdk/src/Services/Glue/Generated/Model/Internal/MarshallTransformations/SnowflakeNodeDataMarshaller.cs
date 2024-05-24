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

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnowflakeNodeData Marshaller
    /// </summary>
    public class SnowflakeNodeDataMarshaller : IRequestMarshaller<SnowflakeNodeData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnowflakeNodeData requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetAdditionalOptions())
            {
                context.Writer.WritePropertyName("AdditionalOptions");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalOptionsKvp in requestObject.AdditionalOptions)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalOptionsKvp.Key);
                    var requestObjectAdditionalOptionsValue = requestObjectAdditionalOptionsKvp.Value;

                        context.Writer.Write(requestObjectAdditionalOptionsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAutoPushdown())
            {
                context.Writer.WritePropertyName("AutoPushdown");
                context.Writer.Write(requestObject.AutoPushdown);
            }

            if(requestObject.IsSetConnection())
            {
                context.Writer.WritePropertyName("Connection");
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Connection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.Write(requestObject.Database);
            }

            if(requestObject.IsSetIamRole())
            {
                context.Writer.WritePropertyName("IamRole");
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.IamRole, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMergeAction())
            {
                context.Writer.WritePropertyName("MergeAction");
                context.Writer.Write(requestObject.MergeAction);
            }

            if(requestObject.IsSetMergeClause())
            {
                context.Writer.WritePropertyName("MergeClause");
                context.Writer.Write(requestObject.MergeClause);
            }

            if(requestObject.IsSetMergeWhenMatched())
            {
                context.Writer.WritePropertyName("MergeWhenMatched");
                context.Writer.Write(requestObject.MergeWhenMatched);
            }

            if(requestObject.IsSetMergeWhenNotMatched())
            {
                context.Writer.WritePropertyName("MergeWhenNotMatched");
                context.Writer.Write(requestObject.MergeWhenNotMatched);
            }

            if(requestObject.IsSetPostAction())
            {
                context.Writer.WritePropertyName("PostAction");
                context.Writer.Write(requestObject.PostAction);
            }

            if(requestObject.IsSetPreAction())
            {
                context.Writer.WritePropertyName("PreAction");
                context.Writer.Write(requestObject.PreAction);
            }

            if(requestObject.IsSetSampleQuery())
            {
                context.Writer.WritePropertyName("SampleQuery");
                context.Writer.Write(requestObject.SampleQuery);
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.Write(requestObject.Schema);
            }

            if(requestObject.IsSetSelectedColumns())
            {
                context.Writer.WritePropertyName("SelectedColumns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSelectedColumnsListValue in requestObject.SelectedColumns)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectSelectedColumnsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.Write(requestObject.SourceType);
            }

            if(requestObject.IsSetStagingTable())
            {
                context.Writer.WritePropertyName("StagingTable");
                context.Writer.Write(requestObject.StagingTable);
            }

            if(requestObject.IsSetTable())
            {
                context.Writer.WritePropertyName("Table");
                context.Writer.Write(requestObject.Table);
            }

            if(requestObject.IsSetTableSchema())
            {
                context.Writer.WritePropertyName("TableSchema");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTableSchemaListValue in requestObject.TableSchema)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = OptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectTableSchemaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTempDir())
            {
                context.Writer.WritePropertyName("TempDir");
                context.Writer.Write(requestObject.TempDir);
            }

            if(requestObject.IsSetUpsert())
            {
                context.Writer.WritePropertyName("Upsert");
                context.Writer.Write(requestObject.Upsert);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnowflakeNodeDataMarshaller Instance = new SnowflakeNodeDataMarshaller();

    }
}