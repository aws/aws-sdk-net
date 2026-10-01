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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        [AWSProperty(Required = true)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property AppVersion. 
        /// <para>
        /// The version of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AppVersion { get; set; }

        /// <summary>
        /// Checks to see if the AppVersion property is set.
        /// </summary>
        internal bool IsSetAppVersion() => this.AppVersion != null;

        /// <summary>
        /// Gets and sets the property EksSources. 
        /// <para>
        /// The input sources of the Amazon Elastic Kubernetes Service resources you have imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EksSource> EksSources { get; set; } = AWSConfigs.InitializeCollections ? new List<EksSource>() : null;

        /// <summary>
        /// Checks to see if the EksSources property is set.
        /// </summary>
        internal bool IsSetEksSources() => this.EksSources != null && (this.EksSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) for the resources you have imported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SourceArns property is set.
        /// </summary>
        internal bool IsSetSourceArns() => this.SourceArns != null && (this.SourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceImportStatusType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TerraformSources. 
        /// <para>
        ///  A list of terraform file s3 URLs you have imported. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TerraformSource> TerraformSources { get; set; } = AWSConfigs.InitializeCollections ? new List<TerraformSource>() : null;

        /// <summary>
        /// Checks to see if the TerraformSources property is set.
        /// </summary>
        internal bool IsSetTerraformSources() => this.TerraformSources != null && (this.TerraformSources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
