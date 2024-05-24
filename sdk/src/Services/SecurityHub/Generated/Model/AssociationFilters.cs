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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Options for filtering the <c>ListConfigurationPolicyAssociations</c> response. You
    /// can filter by the Amazon Resource Name (ARN) or universally unique identifier (UUID)
    /// of a configuration policy, <c>AssociationType</c>, or <c>AssociationStatus</c>.
    /// </summary>
    public partial class AssociationFilters
    {
        private ConfigurationPolicyAssociationStatus _associationStatus;
        private AssociationType _associationType;
        private string _configurationPolicyId;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        ///  The current status of the association between a target and a configuration policy.
        /// 
        /// </para>
        /// </summary>
        public ConfigurationPolicyAssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        ///  Indicates whether the association between a target and a configuration was directly
        /// applied by the Security Hub delegated administrator or inherited from a parent. 
        /// </para>
        /// </summary>
        public AssociationType AssociationType
        {
            get { return this._associationType; }
            set { this._associationType = value; }
        }

        // Check to see if AssociationType property is set
        internal bool IsSetAssociationType()
        {
            return this._associationType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyId. 
        /// <para>
        ///  The ARN or UUID of the configuration policy. 
        /// </para>
        /// </summary>
        public string ConfigurationPolicyId
        {
            get { return this._configurationPolicyId; }
            set { this._configurationPolicyId = value; }
        }

        // Check to see if ConfigurationPolicyId property is set
        internal bool IsSetConfigurationPolicyId()
        {
            return this._configurationPolicyId != null;
        }

    }
}