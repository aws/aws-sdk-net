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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessPreview operation.
    /// Creates an access preview that allows you to preview IAM Access Analyzer findings
    /// for your resource before deploying resource permissions.
    /// </summary>
    public partial class CreateAccessPreviewRequest : AmazonAccessAnalyzerRequest
    {
        private string _analyzerArn;
        private string _clientToken;
        private Dictionary<string, Configuration> _configurations = AWSConfigs.InitializeCollections ? new Dictionary<string, Configuration>() : null;

        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-getting-started.html#permission-resources">ARN
        /// of the account analyzer</a> used to generate the access preview. You can only create
        /// an access preview for analyzers with an <c>Account</c> type and <c>Active</c> status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnalyzerArn
        {
            get { return this._analyzerArn; }
            set { this._analyzerArn = value; }
        }

        // Check to see if AnalyzerArn property is set
        internal bool IsSetAnalyzerArn()
        {
            return this._analyzerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// Access control configuration for your resource that is used to generate the access
        /// preview. The access preview includes findings for external access allowed to the resource
        /// with the proposed access control configuration. The configuration must contain exactly
        /// one element.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, Configuration> Configurations
        {
            get { return this._configurations; }
            set { this._configurations = value; }
        }

        // Check to see if Configurations property is set
        internal bool IsSetConfigurations()
        {
            return this._configurations != null && (this._configurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}