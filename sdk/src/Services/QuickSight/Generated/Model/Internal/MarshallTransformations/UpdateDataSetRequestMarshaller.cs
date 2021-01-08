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
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDataSet Request Marshaller
    /// </summary>       
    public class UpdateDataSetRequestMarshaller : IMarshaller<IRequest, UpdateDataSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDataSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDataSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";            
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetDataSetId())
                throw new AmazonQuickSightException("Request object does not have required field DataSetId set");
            request.AddPathResource("{DataSetId}", StringUtils.FromString(publicRequest.DataSetId));
            request.ResourcePath = "/accounts/{AwsAccountId}/data-sets/{DataSetId}";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetColumnGroups())
                {
                    context.Writer.WritePropertyName("ColumnGroups");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestColumnGroupsListValue in publicRequest.ColumnGroups)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ColumnGroupMarshaller.Instance;
                        marshaller.Marshall(publicRequestColumnGroupsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetColumnLevelPermissionRules())
                {
                    context.Writer.WritePropertyName("ColumnLevelPermissionRules");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestColumnLevelPermissionRulesListValue in publicRequest.ColumnLevelPermissionRules)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ColumnLevelPermissionRuleMarshaller.Instance;
                        marshaller.Marshall(publicRequestColumnLevelPermissionRulesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetImportMode())
                {
                    context.Writer.WritePropertyName("ImportMode");
                    context.Writer.Write(publicRequest.ImportMode);
                }

                if(publicRequest.IsSetLogicalTableMap())
                {
                    context.Writer.WritePropertyName("LogicalTableMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestLogicalTableMapKvp in publicRequest.LogicalTableMap)
                    {
                        context.Writer.WritePropertyName(publicRequestLogicalTableMapKvp.Key);
                        var publicRequestLogicalTableMapValue = publicRequestLogicalTableMapKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = LogicalTableMarshaller.Instance;
                        marshaller.Marshall(publicRequestLogicalTableMapValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPhysicalTableMap())
                {
                    context.Writer.WritePropertyName("PhysicalTableMap");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPhysicalTableMapKvp in publicRequest.PhysicalTableMap)
                    {
                        context.Writer.WritePropertyName(publicRequestPhysicalTableMapKvp.Key);
                        var publicRequestPhysicalTableMapValue = publicRequestPhysicalTableMapKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = PhysicalTableMarshaller.Instance;
                        marshaller.Marshall(publicRequestPhysicalTableMapValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRowLevelPermissionDataSet())
                {
                    context.Writer.WritePropertyName("RowLevelPermissionDataSet");
                    context.Writer.WriteObjectStart();

                    var marshaller = RowLevelPermissionDataSetMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RowLevelPermissionDataSet, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDataSetRequestMarshaller _instance = new UpdateDataSetRequestMarshaller();        

        internal static UpdateDataSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDataSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}