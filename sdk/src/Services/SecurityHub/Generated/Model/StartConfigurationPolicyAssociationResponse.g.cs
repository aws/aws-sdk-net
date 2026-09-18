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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the StartConfigurationPolicyAssociation operation.
    /// </summary>
    public partial class StartConfigurationPolicyAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        ///  The current status of the association between the specified target and the configuration.
        /// 
        /// </para>
        /// </summary>
        public ConfigurationPolicyAssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property AssociationStatusMessage. 
        /// <para>
        ///  An explanation for a <c>FAILED</c> value for <c>AssociationStatus</c>. 
        /// </para>
        /// </summary>
        public string AssociationStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatusMessage property is set.
        /// </summary>
        internal bool IsSetAssociationStatusMessage() => this.AssociationStatusMessage != null;

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        ///  Indicates whether the association between the specified target and the configuration
        /// was directly applied by the Security Hub CSPM delegated administrator or inherited
        /// from a parent. 
        /// </para>
        /// </summary>
        public AssociationType AssociationType { get; set; }

        /// <summary>
        /// Checks to see if the AssociationType property is set.
        /// </summary>
        internal bool IsSetAssociationType() => this.AssociationType != null;

        /// <summary>
        /// Gets and sets the property ConfigurationPolicyId. 
        /// <para>
        ///  The UUID of the configuration policy. 
        /// </para>
        /// </summary>
        public string ConfigurationPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationPolicyId property is set.
        /// </summary>
        internal bool IsSetConfigurationPolicyId() => this.ConfigurationPolicyId != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The identifier of the target account, organizational unit, or the organization root
        /// with which the configuration is associated. 
        /// </para>
        /// </summary>
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        ///  Indicates whether the target is an Amazon Web Services account, organizational unit,
        /// or the organization root. 
        /// </para>
        /// </summary>
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The date and time, in UTC and ISO 8601 format, that the configuration policy association
        /// was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
