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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ImportResourcesToDraftAppVersion operation.
    /// </summary>
    public partial class ImportResourcesToDraftAppVersionResponse : AmazonWebServiceResponse
    {
        private string _appArn;
        private string _appVersion;
        private List<EksSource> _eksSources = AWSConfigs.InitializeCollections ? new List<EksSource>() : null;
        private List<string> _sourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ResourceImportStatusType _status;
        private List<TerraformSource> _terraformSources = AWSConfigs.InitializeCollections ? new List<TerraformSource>() : null;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the Resilience Hub application. The format for this
        /// ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:app/<c>app-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AppVersion
        {
            get { return this._appVersion; }
            set { this._appVersion = value; }
        }

        // Check to see if AppVersion property is set
        internal bool IsSetAppVersion()
        {
            return this._appVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EksSources. 
        /// <para>
        /// The input sources of the Amazon Elastic Kubernetes Service resources you have imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksSource> EksSources
        {
            get { return this._eksSources; }
            set { this._eksSources = value; }
        }

        // Check to see if EksSources property is set
        internal bool IsSetEksSources()
        {
            return this._eksSources != null && (this._eksSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the resources you have imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceArns
        {
            get { return this._sourceArns; }
            set { this._sourceArns = value; }
        }

        // Check to see if SourceArns property is set
        internal bool IsSetSourceArns()
        {
            return this._sourceArns != null && (this._sourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceImportStatusType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TerraformSources. 
        /// <para>
        ///  A list of terraform file s3 URLs you have imported. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TerraformSource> TerraformSources
        {
            get { return this._terraformSources; }
            set { this._terraformSources = value; }
        }

        // Check to see if TerraformSources property is set
        internal bool IsSetTerraformSources()
        {
            return this._terraformSources != null && (this._terraformSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}