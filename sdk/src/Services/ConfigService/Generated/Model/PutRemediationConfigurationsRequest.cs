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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the PutRemediationConfigurations operation.
    /// Adds or updates the remediation configuration with a specific AWS Config rule with
    /// the selected target or action. The API creates the <code>RemediationConfiguration</code>
    /// object for the AWS Config rule. The AWS Config rule must already exist for you to
    /// add a remediation configuration. The target (SSM document) must exist and have permissions
    /// to use the target. 
    /// 
    ///  <note> 
    /// <para>
    /// If you make backward incompatible changes to the SSM document, you must call this
    /// again to ensure the remediations can run.
    /// </para>
    ///  
    /// <para>
    /// This API does not support adding remediation configurations for service-linked AWS
    /// Config Rules such as Organization Config rules, the rules deployed by conformance
    /// packs, and rules deployed by AWS Security Hub.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutRemediationConfigurationsRequest : AmazonConfigServiceRequest
    {
        private List<RemediationConfiguration> _remediationConfigurations = new List<RemediationConfiguration>();

        /// <summary>
        /// Gets and sets the property RemediationConfigurations. 
        /// <para>
        /// A list of remediation configuration objects.
        /// </para>
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
            return this._remediationConfigurations != null && this._remediationConfigurations.Count > 0; 
        }

    }
}