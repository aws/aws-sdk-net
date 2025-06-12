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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The user-defined preferences that will be applied during product provisioning, unless
    /// overridden by <c>ProvisioningPreferences</c> or <c>UpdateProvisioningPreferences</c>.
    /// 
    ///  
    /// <para>
    /// For more information on maximum concurrent accounts and failure tolerance, see <a
    /// href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-concepts.html#stackset-ops-options">Stack
    /// set operation options</a> in the <i>CloudFormation User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ProvisioningArtifactPreferences
    {
        private List<string> _stackSetAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _stackSetRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property StackSetAccounts. 
        /// <para>
        /// One or more Amazon Web Services accounts where stack instances are deployed from the
        /// stack set. These accounts can be scoped in <c>ProvisioningPreferences$StackSetAccounts</c>
        /// and <c>UpdateProvisioningPreferences$StackSetAccounts</c>.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackSetAccounts
        {
            get { return this._stackSetAccounts; }
            set { this._stackSetAccounts = value; }
        }

        // Check to see if StackSetAccounts property is set
        internal bool IsSetStackSetAccounts()
        {
            return this._stackSetAccounts != null && (this._stackSetAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StackSetRegions. 
        /// <para>
        /// One or more Amazon Web Services Regions where stack instances are deployed from the
        /// stack set. These Regions can be scoped in <c>ProvisioningPreferences$StackSetRegions</c>
        /// and <c>UpdateProvisioningPreferences$StackSetRegions</c>.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackSetRegions
        {
            get { return this._stackSetRegions; }
            set { this._stackSetRegions = value; }
        }

        // Check to see if StackSetRegions property is set
        internal bool IsSetStackSetRegions()
        {
            return this._stackSetRegions != null && (this._stackSetRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}