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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// A list of features which will be configured for the organization.
    /// </summary>
    public partial class OrganizationFeatureConfiguration
    {
        private List<OrganizationAdditionalConfiguration> _additionalConfiguration = new List<OrganizationAdditionalConfiguration>();
        private OrgFeatureStatus _autoEnable;
        private OrgFeature _name;

        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// The additional information that will be configured for the organization.
        /// </para>
        /// </summary>
        public List<OrganizationAdditionalConfiguration> AdditionalConfiguration
        {
            get { return this._additionalConfiguration; }
            set { this._additionalConfiguration = value; }
        }

        // Check to see if AdditionalConfiguration property is set
        internal bool IsSetAdditionalConfiguration()
        {
            return this._additionalConfiguration != null && this._additionalConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// The status of the feature that will be configured for the organization.
        /// </para>
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
        /// The name of the feature that will be configured for the organization.
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