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
    /// This is the response object from the StartConfigurationPolicyAssociation operation.
    /// </summary>
    public partial class StartConfigurationPolicyAssociationResponse : AmazonWebServiceResponse
    {
        private ConfigurationPolicyAssociationStatus _associationStatus;
        private string _associationStatusMessage;
        private AssociationType _associationType;
        private string _configurationPolicyId;
        private string _targetId;
        private TargetType _targetType;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        ///  The current status of the association between the specified target and the configuration.
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
        /// Gets and sets the property AssociationStatusMessage. 
        /// <para>
        ///  An explanation for a <c>FAILED</c> value for <c>AssociationStatus</c>. 
        /// </para>
        /// </summary>
        public string AssociationStatusMessage
        {
            get { return this._associationStatusMessage; }
            set { this._associationStatusMessage = value; }
        }

        // Check to see if AssociationStatusMessage property is set
        internal bool IsSetAssociationStatusMessage()
        {
            return this._associationStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationType. 
        /// <para>
        ///  Indicates whether the association between the specified target and the configuration
        /// was directly applied by the Security Hub delegated administrator or inherited from
        /// a parent. 
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
        ///  The UUID of the configuration policy. 
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

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        ///  The identifier of the target account, organizational unit, or the organization root
        /// with which the configuration is associated. 
        /// </para>
        /// </summary>
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        ///  Indicates whether the target is an Amazon Web Services account, organizational unit,
        /// or the organization root. 
        /// </para>
        /// </summary>
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  The date and time, in UTC and ISO 8601 format, that the configuration policy association
        /// was last updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}