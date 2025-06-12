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
    /// Container for the parameters to the UpdateAppVersion operation.
    /// Updates the Resilience Hub application version.
    /// 
    ///  <note> 
    /// <para>
    /// This API updates the Resilience Hub application draft version. To use this information
    /// for running resiliency assessments, you must publish the Resilience Hub application
    /// using the <c>PublishAppVersion</c> API.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateAppVersionRequest : AmazonResilienceHubRequest
    {
        private Dictionary<string, List<string>> _additionalInfo = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private string _appArn;

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Additional configuration parameters for an Resilience Hub application. If you want
        /// to implement <c>additionalInfo</c> through the Resilience Hub console rather than
        /// using an API call, see <a href="https://docs.aws.amazon.com/resilience-hub/latest/userguide/app-config-param.html">Configure
        /// the application configuration parameters</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, this parameter accepts a key-value mapping (in a string format) of only
        /// one failover region and one associated account.
        /// </para>
        ///  
        /// <para>
        /// Key: <c>"failover-regions"</c> 
        /// </para>
        ///  
        /// <para>
        /// Value: <c>"[{"region":"&lt;REGION&gt;", "accounts":[{"id":"&lt;ACCOUNT_ID&gt;"}]}]"</c>
        /// 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null && (this._additionalInfo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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

    }
}