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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataSet Request Marshaller
    /// </summary>       
    public class CreateDataSetRequestMarshaller : IMarshaller<IRequest, CreateDataSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            request.ResourcePath = "/accounts/{AwsAccountId}/data-sets";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetColumnGroups())
            {
                context.Writer.WritePropertyName("ColumnGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestColumnGroupsListValue in publicRequest.ColumnGroups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnGroupMarshaller.Instance;
                    marshaller.Marshall(publicRequestColumnGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetColumnLevelPermissionRules())
            {
                context.Writer.WritePropertyName("ColumnLevelPermissionRules");
                context.Writer.WriteStartArray();
                foreach(var publicRequestColumnLevelPermissionRulesListValue in publicRequest.ColumnLevelPermissionRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ColumnLevelPermissionRuleMarshaller.Instance;
                    marshaller.Marshall(publicRequestColumnLevelPermissionRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDataSetId())
            {
                context.Writer.WritePropertyName("DataSetId");
                context.Writer.WriteStringValue(publicRequest.DataSetId);
            }

            if(publicRequest.IsSetDatasetParameters())
            {
                context.Writer.WritePropertyName("DatasetParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDatasetParametersListValue in publicRequest.DatasetParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DatasetParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestDatasetParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDataSetUsageConfiguration())
            {
                context.Writer.WritePropertyName("DataSetUsageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSetUsageConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DataSetUsageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFieldFolders())
            {
                context.Writer.WritePropertyName("FieldFolders");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFieldFoldersKvp in publicRequest.FieldFolders)
                {
                    context.Writer.WritePropertyName(publicRequestFieldFoldersKvp.Key);
                    var publicRequestFieldFoldersValue = publicRequestFieldFoldersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = FieldFolderMarshaller.Instance;
                    marshaller.Marshall(publicRequestFieldFoldersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFolderArns())
            {
                context.Writer.WritePropertyName("FolderArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFolderArnsListValue in publicRequest.FolderArns)
                {
                        context.Writer.WriteStringValue(publicRequestFolderArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetImportMode())
            {
                context.Writer.WritePropertyName("ImportMode");
                context.Writer.WriteStringValue(publicRequest.ImportMode);
            }

            if(publicRequest.IsSetLogicalTableMap())
            {
                context.Writer.WritePropertyName("LogicalTableMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestLogicalTableMapKvp in publicRequest.LogicalTableMap)
                {
                    context.Writer.WritePropertyName(publicRequestLogicalTableMapKvp.Key);
                    var publicRequestLogicalTableMapValue = publicRequestLogicalTableMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = LogicalTableMarshaller.Instance;
                    marshaller.Marshall(publicRequestLogicalTableMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPerformanceConfiguration())
            {
                context.Writer.WritePropertyName("PerformanceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PerformanceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PerformanceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPermissions())
            {
                context.Writer.WritePropertyName("Permissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcePermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPhysicalTableMap())
            {
                context.Writer.WritePropertyName("PhysicalTableMap");
                context.Writer.WriteStartObject();
                foreach (var publicRequestPhysicalTableMapKvp in publicRequest.PhysicalTableMap)
                {
                    context.Writer.WritePropertyName(publicRequestPhysicalTableMapKvp.Key);
                    var publicRequestPhysicalTableMapValue = publicRequestPhysicalTableMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = PhysicalTableMarshaller.Instance;
                    marshaller.Marshall(publicRequestPhysicalTableMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRowLevelPermissionDataSet())
            {
                context.Writer.WritePropertyName("RowLevelPermissionDataSet");
                context.Writer.WriteStartObject();

                var marshaller = RowLevelPermissionDataSetMarshaller.Instance;
                marshaller.Marshall(publicRequest.RowLevelPermissionDataSet, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRowLevelPermissionTagConfiguration())
            {
                context.Writer.WritePropertyName("RowLevelPermissionTagConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RowLevelPermissionTagConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RowLevelPermissionTagConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUseAs())
            {
                context.Writer.WritePropertyName("UseAs");
                context.Writer.WriteStringValue(publicRequest.UseAs);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDataSetRequestMarshaller _instance = new CreateDataSetRequestMarshaller();        

        internal static CreateDataSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}