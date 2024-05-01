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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// A resource policy grants one or more Amazon Web Services services and accounts permissions
    /// to access X-Ray. Each resource policy is associated with a specific Amazon Web Services
    /// account.
    /// </summary>
    public partial class ResourcePolicy
    {
        private DateTime? _lastUpdatedTime;
        private string _policyDocument;
        private string _policyName;
        private string _policyRevisionId;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// When the policy was last updated, in Unix time seconds.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// The resource policy document, which can be up to 5kb in size.
        /// </para>
        /// </summary>
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the resource policy. Must be unique within a specific Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRevisionId. 
        /// <para>
        /// Returns the current policy revision id for this policy name.
        /// </para>
        /// </summary>
        public string PolicyRevisionId
        {
            get { return this._policyRevisionId; }
            set { this._policyRevisionId = value; }
        }

        // Check to see if PolicyRevisionId property is set
        internal bool IsSetPolicyRevisionId()
        {
            return this._policyRevisionId != null;
        }

    }
}