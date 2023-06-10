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

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AmazonRedshiftNodeData Marshaller
    /// </summary>
    public class AmazonRedshiftNodeDataMarshaller : IRequestMarshaller<AmazonRedshiftNodeData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AmazonRedshiftNodeData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessType())
            {
                context.Writer.WritePropertyName("AccessType");
                context.Writer.Write(requestObject.AccessType);
            }

            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.Write(requestObject.Action);
            }

            if(requestObject.IsSetAdvancedOptions())
            {
                context.Writer.WritePropertyName("AdvancedOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdvancedOptionsListValue in requestObject.AdvancedOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AmazonRedshiftAdvancedOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdvancedOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCatalogDatabase())
            {
                context.Writer.WritePropertyName("CatalogDatabase");
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogDatabase, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCatalogRedshiftSchema())
            {
                context.Writer.WritePropertyName("CatalogRedshiftSchema");
                context.Writer.Write(requestObject.CatalogRedshiftSchema);
            }

            if(requestObject.IsSetCatalogRedshiftTable())
            {
                context.Writer.WritePropertyName("CatalogRedshiftTable");
                context.Writer.Write(requestObject.CatalogRedshiftTable);
            }

            if(requestObject.IsSetCatalogTable())
            {
                context.Writer.WritePropertyName("CatalogTable");
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogTable, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnection())
            {
                context.Writer.WritePropertyName("Connection");
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Connection, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCrawlerConnection())
            {
                context.Writer.WritePropertyName("CrawlerConnection");
                context.Writer.Write(requestObject.CrawlerConnection);
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
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Schema, context);

                context.Writer.WriteObjectEnd();
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
                context.Writer.WriteObjectStart();

                var marshaller = OptionMarshaller.Instance;
                marshaller.Marshall(requestObject.Table, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTablePrefix())
            {
                context.Writer.WritePropertyName("TablePrefix");
                context.Writer.Write(requestObject.TablePrefix);
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
        public readonly static AmazonRedshiftNodeDataMarshaller Instance = new AmazonRedshiftNodeDataMarshaller();

    }
}