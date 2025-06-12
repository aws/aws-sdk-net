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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutRemediationConfigurations operation.
    /// Adds or updates the remediation configuration with a specific Config rule with the
    /// selected target or action. The API creates the <c>RemediationConfiguration</c> object
    /// for the Config rule. The Config rule must already exist for you to add a remediation
    /// configuration. The target (SSM document) must exist and have permissions to use the
    /// target. 
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Be aware of backward incompatible changes</b> 
    /// </para>
    ///  
    /// <para>
    /// If you make backward incompatible changes to the SSM document, you must call this
    /// again to ensure the remediations can run.
    /// </para>
    ///  
    /// <para>
    /// This API does not support adding remediation configurations for service-linked Config
    /// Rules such as Organization Config rules, the rules deployed by conformance packs,
    /// and rules deployed by Amazon Web Services Security Hub.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <b>Required fields</b> 
    /// </para>
    ///  
    /// <para>
    /// For manual remediation configuration, you need to provide a value for <c>automationAssumeRole</c>
    /// or use a value in the <c>assumeRole</c>field to remediate your resources. The SSM
    /// automation document can use either as long as it maps to a valid parameter.
    /// </para>
    ///  
    /// <para>
    /// However, for automatic remediation configuration, the only valid <c>assumeRole</c>
    /// field value is <c>AutomationAssumeRole</c> and you need to provide a value for <c>AutomationAssumeRole</c>
    /// to remediate your resources.
    /// </para>
    ///  </note> <note> 
    /// <para>
    ///  <b>Auto remediation can be initiated even for compliant resources</b> 
    /// </para>
    ///  
    /// <para>
    /// If you enable auto remediation for a specific Config rule using the <a href="https://docs.aws.amazon.com/config/latest/APIReference/emAPI_PutRemediationConfigurations.html">PutRemediationConfigurations</a>
    /// API or the Config console, it initiates the remediation process for all non-compliant
    /// resources for that specific rule. The auto remediation process relies on the compliance
    /// data snapshot which is captured on a periodic basis. Any non-compliant resource that
    /// is updated between the snapshot schedule will continue to be remediated based on the
    /// last known compliance data snapshot.
    /// </para>
    ///  
    /// <para>
    /// This means that in some cases auto remediation can be initiated even for compliant
    /// resources, since the bootstrap processor uses a database that can have stale evaluation
    /// results based on the last known compliance data snapshot.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutRemediationConfigurationsRequest : AmazonConfigServiceRequest
    {
        private List<RemediationConfiguration> _remediationConfigurations = AWSConfigs.InitializeCollections ? new List<RemediationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property RemediationConfigurations. 
        /// <para>
        /// A list of remediation configuration objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<RemediationConfiguration> RemediationConfigurations
        {
            get { return this._remediationConfigurations; }
            set { this._remediationConfigurations = value; }
        }

        // Check to see if RemediationConfigurations property is set
        internal bool IsSetRemediationConfigurations()
        {
            return this._remediationConfigurations != null && (this._remediationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}