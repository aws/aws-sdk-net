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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// A list of features which will be configured for the organization.
    /// </summary>
    public partial class OrganizationFeatureConfigurationResult
    {
        private List<OrganizationAdditionalConfigurationResult> _additionalConfiguration = AWSConfigs.InitializeCollections ? new List<OrganizationAdditionalConfigurationResult>() : null;
        private OrgFeatureStatus _autoEnable;
        private OrgFeature _name;

        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// The additional configuration that is configured for the member accounts within the
        /// organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrganizationAdditionalConfigurationResult> AdditionalConfiguration
        {
            get { return this._additionalConfiguration; }
            set { this._additionalConfiguration = value; }
        }

        // Check to see if AdditionalConfiguration property is set
        internal bool IsSetAdditionalConfiguration()
        {
            return this._additionalConfiguration != null && (this._additionalConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Describes the status of the feature that is configured for the member accounts within
        /// the organization.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c>: Indicates that when a new account joins the organization, they will have
        /// the feature enabled automatically. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c>: Indicates that all accounts in the organization have the feature enabled
        /// automatically. This includes <c>NEW</c> accounts that join the organization and accounts
        /// that may have been suspended or removed from the organization in GuardDuty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Indicates that the feature will not be automatically enabled for any
        /// account in the organization. In this case, each account will be managed individually
        /// by the administrator.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrgFeatureStatus AutoEnable
        {
            get { return this._autoEnable; }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the feature that is configured for the member accounts within the organization.
        /// </para>
        /// </summary>
        public OrgFeature Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}