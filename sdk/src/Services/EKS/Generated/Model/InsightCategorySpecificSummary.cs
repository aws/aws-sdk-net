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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Summary information that relates to the category of the insight. Currently only returned
    /// with certain insights having category <c>UPGRADE_READINESS</c>.
    /// </summary>
    public partial class InsightCategorySpecificSummary
    {
        private List<AddonCompatibilityDetail> _addonCompatibilityDetails = AWSConfigs.InitializeCollections ? new List<AddonCompatibilityDetail>() : null;
        private List<DeprecationDetail> _deprecationDetails = AWSConfigs.InitializeCollections ? new List<DeprecationDetail>() : null;

        /// <summary>
        /// Gets and sets the property AddonCompatibilityDetails. 
        /// <para>
        /// A list of <c>AddonCompatibilityDetail</c> objects for Amazon EKS add-ons.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddonCompatibilityDetail> AddonCompatibilityDetails
        {
            get { return this._addonCompatibilityDetails; }
            set { this._addonCompatibilityDetails = value; }
        }

        // Check to see if AddonCompatibilityDetails property is set
        internal bool IsSetAddonCompatibilityDetails()
        {
            return this._addonCompatibilityDetails != null && (this._addonCompatibilityDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeprecationDetails. 
        /// <para>
        /// The summary information about deprecated resource usage for an insight check in the
        /// <c>UPGRADE_READINESS</c> category.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeprecationDetail> DeprecationDetails
        {
            get { return this._deprecationDetails; }
            set { this._deprecationDetails = value; }
        }

        // Check to see if DeprecationDetails property is set
        internal bool IsSetDeprecationDetails()
        {
            return this._deprecationDetails != null && (this._deprecationDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}