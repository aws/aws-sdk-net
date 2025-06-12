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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The decision, based on policy evaluation, from an individual authorization request
    /// in a <c>BatchIsAuthorized</c> API request.
    /// </summary>
    public partial class BatchIsAuthorizedOutputItem
    {
        private Decision _decision;
        private List<DeterminingPolicyItem> _determiningPolicies = AWSConfigs.InitializeCollections ? new List<DeterminingPolicyItem>() : null;
        private List<EvaluationErrorItem> _errors = AWSConfigs.InitializeCollections ? new List<EvaluationErrorItem>() : null;
        private BatchIsAuthorizedInputItem _request;

        /// <summary>
        /// Gets and sets the property Decision. 
        /// <para>
        /// An authorization decision that indicates if the authorization request should be allowed
        /// or denied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Decision Decision
        {
            get { return this._decision; }
            set { this._decision = value; }
        }

        // Check to see if Decision property is set
        internal bool IsSetDecision()
        {
            return this._decision != null;
        }

        /// <summary>
        /// Gets and sets the property DeterminingPolicies. 
        /// <para>
        /// The list of determining policies used to make the authorization decision. For example,
        /// if there are two matching policies, where one is a forbid and the other is a permit,
        /// then the forbid policy will be the determining policy. In the case of multiple matching
        /// permit policies then there would be multiple determining policies. In the case that
        /// no policies match, and hence the response is DENY, there would be no determining policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DeterminingPolicyItem> DeterminingPolicies
        {
            get { return this._determiningPolicies; }
            set { this._determiningPolicies = value; }
        }

        // Check to see if DeterminingPolicies property is set
        internal bool IsSetDeterminingPolicies()
        {
            return this._determiningPolicies != null && (this._determiningPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// Errors that occurred while making an authorization decision. For example, a policy
        /// might reference an entity or attribute that doesn't exist in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EvaluationErrorItem> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// The authorization request that initiated the decision.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchIsAuthorizedInputItem Request
        {
            get { return this._request; }
            set { this._request = value; }
        }

        // Check to see if Request property is set
        internal bool IsSetRequest()
        {
            return this._request != null;
        }

    }
}