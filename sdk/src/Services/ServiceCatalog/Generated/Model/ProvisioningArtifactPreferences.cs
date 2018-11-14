/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The user-defined preferences that will be applied during product provisioning, unless
    /// overridden by <code>ProvisioningPreferences</code> or <code>UpdateProvisioningPreferences</code>.
    /// 
    ///  
    /// <para>
    /// For more information on maximum concurrent accounts and failure tolerance, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">Stack
    /// set operation options</a> in the <i>AWS CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ProvisioningArtifactPreferences
    {
        private List<string> _stackSetAccounts = new List<string>();
        private List<string> _stackSetRegions = new List<string>();

        /// <summary>
        /// Gets and sets the property StackSetAccounts. 
        /// <para>
        /// One or more AWS accounts where stack instances are deployed from the stack set. These
        /// accounts can be scoped in <code>ProvisioningPreferences$StackSetAccounts</code> and
        /// <code>UpdateProvisioningPreferences$StackSetAccounts</code>.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        /// </summary>
        public List<string> StackSetAccounts
        {
            get { return this._stackSetAccounts; }
            set { this._stackSetAccounts = value; }
        }

        // Check to see if StackSetAccounts property is set
        internal bool IsSetStackSetAccounts()
        {
            return this._stackSetAccounts != null && this._stackSetAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackSetRegions. 
        /// <para>
        /// One or more AWS Regions where stack instances are deployed from the stack set. These
        /// regions can be scoped in <code>ProvisioningPreferences$StackSetRegions</code> and
        /// <code>UpdateProvisioningPreferences$StackSetRegions</code>.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        /// </summary>
        public List<string> StackSetRegions
        {
            get { return this._stackSetRegions; }
            set { this._stackSetRegions = value; }
        }

        // Check to see if StackSetRegions property is set
        internal bool IsSetStackSetRegions()
        {
            return this._stackSetRegions != null && this._stackSetRegions.Count > 0; 
        }

    }
}