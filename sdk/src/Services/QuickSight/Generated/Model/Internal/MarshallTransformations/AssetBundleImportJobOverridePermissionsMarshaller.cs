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
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssetBundleImportJobOverridePermissions Marshaller
    /// </summary>
    public class AssetBundleImportJobOverridePermissionsMarshaller : IRequestMarshaller<AssetBundleImportJobOverridePermissions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssetBundleImportJobOverridePermissions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnalyses())
            {
                context.Writer.WritePropertyName("Analyses");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAnalysesListValue in requestObject.Analyses)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobAnalysisOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAnalysesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDashboards())
            {
                context.Writer.WritePropertyName("Dashboards");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDashboardsListValue in requestObject.Dashboards)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobDashboardOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDashboardsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataSets())
            {
                context.Writer.WritePropertyName("DataSets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataSetsListValue in requestObject.DataSets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobDataSetOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("DataSources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataSourcesListValue in requestObject.DataSources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobDataSourceOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFolders())
            {
                context.Writer.WritePropertyName("Folders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFoldersListValue in requestObject.Folders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobFolderOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectFoldersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetThemes())
            {
                context.Writer.WritePropertyName("Themes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectThemesListValue in requestObject.Themes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssetBundleImportJobThemeOverridePermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectThemesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssetBundleImportJobOverridePermissionsMarshaller Instance = new AssetBundleImportJobOverridePermissionsMarshaller();

    }
}