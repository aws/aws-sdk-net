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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an internal access finding. This includes details about
    /// the access that was identified within your Amazon Web Services organization or account.
    /// </summary>
    public partial class InternalAccessDetails
    {
        private InternalAccessType _accessType;
        private List<string> _action = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Dictionary<string, string> _condition = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _principal = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _principalOwnerAccount;
        private PrincipalType _principalType;
        private ResourceControlPolicyRestriction _resourceControlPolicyRestriction;
        private ServiceControlPolicyRestriction _serviceControlPolicyRestriction;
        private List<FindingSource> _sources = AWSConfigs.InitializeCollections ? new List<FindingSource>() : null;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of internal access identified in the finding. This indicates how the access
        /// is granted within your Amazon Web Services environment.
        /// </para>
        /// </summary>
        public InternalAccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action in the analyzed policy statement that has internal access permission to
        /// use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null && (this._action.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The condition in the analyzed policy statement that resulted in an internal access
        /// finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null && (this._condition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal that has access to a resource within the internal environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null && (this._principal.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PrincipalOwnerAccount. 
        /// <para>
        /// The Amazon Web Services account ID that owns the principal identified in the internal
        /// access finding.
        /// </para>
        /// </summary>
        public string PrincipalOwnerAccount
        {
            get { return this._principalOwnerAccount; }
            set { this._principalOwnerAccount = value; }
        }

        // Check to see if PrincipalOwnerAccount property is set
        internal bool IsSetPrincipalOwnerAccount()
        {
            return this._principalOwnerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalType. 
        /// <para>
        /// The type of principal identified in the internal access finding, such as IAM role
        /// or IAM user.
        /// </para>
        /// </summary>
        public PrincipalType PrincipalType
        {
            get { return this._principalType; }
            set { this._principalType = value; }
        }

        // Check to see if PrincipalType property is set
        internal bool IsSetPrincipalType()
        {
            return this._principalType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceControlPolicyRestriction. 
        /// <para>
        /// The type of restriction applied to the finding by the resource owner with an Organizations
        /// resource control policy (RCP).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPLICABLE</c>: There is an RCP present in the organization but IAM Access Analyzer
        /// does not include it in the evaluation of effective permissions. For example, if <c>s3:DeleteObject</c>
        /// is blocked by the RCP and the restriction is <c>APPLICABLE</c>, then <c>s3:DeleteObject</c>
        /// would still be included in the list of actions for the finding. Only applicable to
        /// internal access findings with the account as the zone of trust. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_TO_EVALUATE_RCP</c>: There was an error evaluating the RCP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c>: There was no RCP present in the organization. For internal
        /// access findings with the account as the zone of trust, <c>NOT_APPLICABLE</c> could
        /// also indicate that there was no RCP applicable to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLIED</c>: An RCP is present in the organization and IAM Access Analyzer included
        /// it in the evaluation of effective permissions. For example, if <c>s3:DeleteObject</c>
        /// is blocked by the RCP and the restriction is <c>APPLIED</c>, then <c>s3:DeleteObject</c>
        /// would not be included in the list of actions for the finding. Only applicable to internal
        /// access findings with the organization as the zone of trust. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceControlPolicyRestriction ResourceControlPolicyRestriction
        {
            get { return this._resourceControlPolicyRestriction; }
            set { this._resourceControlPolicyRestriction = value; }
        }

        // Check to see if ResourceControlPolicyRestriction property is set
        internal bool IsSetResourceControlPolicyRestriction()
        {
            return this._resourceControlPolicyRestriction != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceControlPolicyRestriction. 
        /// <para>
        /// The type of restriction applied to the finding by an Organizations service control
        /// policy (SCP).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPLICABLE</c>: There is an SCP present in the organization but IAM Access Analyzer
        /// does not include it in the evaluation of effective permissions. Only applicable to
        /// internal access findings with the account as the zone of trust. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED_TO_EVALUATE_SCP</c>: There was an error evaluating the SCP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_APPLICABLE</c>: There was no SCP present in the organization. For internal
        /// access findings with the account as the zone of trust, <c>NOT_APPLICABLE</c> could
        /// also indicate that there was no SCP applicable to the principal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPLIED</c>: An SCP is present in the organization and IAM Access Analyzer included
        /// it in the evaluation of effective permissions. Only applicable to internal access
        /// findings with the organization as the zone of trust. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ServiceControlPolicyRestriction ServiceControlPolicyRestriction
        {
            get { return this._serviceControlPolicyRestriction; }
            set { this._serviceControlPolicyRestriction = value; }
        }

        // Check to see if ServiceControlPolicyRestriction property is set
        internal bool IsSetServiceControlPolicyRestriction()
        {
            return this._serviceControlPolicyRestriction != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The sources of the internal access finding. This indicates how the access that generated
        /// the finding is granted within your Amazon Web Services environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FindingSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}