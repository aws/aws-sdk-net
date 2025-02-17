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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssetBundleImportJobOverrideTags Marshaller
    /// </summary>
    public class AssetBundleImportJobOverrideTagsMarshaller : IRequestMarshaller<AssetBundleImportJobOverrideTags, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssetBundleImportJobOverrideTags requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnalyses())
            {
                context.Writer.WritePropertyName("Analyses");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAnalysesListValue in requestObject.Analyses)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobAnalysisOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAnalysesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDashboards())
            {
                context.Writer.WritePropertyName("Dashboards");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDashboardsListValue in requestObject.Dashboards)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobDashboardOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDashboardsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSets())
            {
                context.Writer.WritePropertyName("DataSets");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataSetsListValue in requestObject.DataSets)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobDataSetOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSetsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataSources())
            {
                context.Writer.WritePropertyName("DataSources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataSourcesListValue in requestObject.DataSources)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobDataSourceOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSourcesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFolders())
            {
                context.Writer.WritePropertyName("Folders");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFoldersListValue in requestObject.Folders)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobFolderOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectFoldersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetThemes())
            {
                context.Writer.WritePropertyName("Themes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectThemesListValue in requestObject.Themes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobThemeOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectThemesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetVPCConnections())
            {
                context.Writer.WritePropertyName("VPCConnections");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVPCConnectionsListValue in requestObject.VPCConnections)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AssetBundleImportJobVPCConnectionOverrideTagsMarshaller.Instance;
                    marshaller.Marshall(requestObjectVPCConnectionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssetBundleImportJobOverrideTagsMarshaller Instance = new AssetBundleImportJobOverrideTagsMarshaller();

    }
}