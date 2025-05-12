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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListAccountSettings operation.
    /// Lists the account settings for a specified principal.
    /// </summary>
    public partial class ListAccountSettingsRequest : AmazonECSRequest
    {
        private bool? _effectiveSettings;
        private int? _maxResults;
        private SettingName _name;
        private string _nextToken;
        private string _principalArn;
        private string _value;

        /// <summary>
        /// Gets and sets the property EffectiveSettings. 
        /// <para>
        /// Determines whether to return the effective settings. If <c>true</c>, the account settings
        /// for the root user or the default setting for the <c>principalArn</c> are returned.
        /// If <c>false</c>, the account settings for the <c>principalArn</c> are returned if
        /// they're set. Otherwise, no account settings are returned.
        /// </para>
        /// </summary>
        public bool? EffectiveSettings
        {
            get { return this._effectiveSettings; }
            set { this._effectiveSettings = value; }
        }

        // Check to see if EffectiveSettings property is set
        internal bool IsSetEffectiveSettings()
        {
            return this._effectiveSettings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of account setting results returned by <c>ListAccountSettings</c>
        /// in paginated output. When this parameter is used, <c>ListAccountSettings</c> only
        /// returns <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. The remaining results of the initial request can be seen by sending another
        /// <c>ListAccountSettings</c> request with the returned <c>nextToken</c> value. This
        /// value can be between 1 and 10. If this parameter isn't used, then <c>ListAccountSettings</c>
        /// returns up to 10 results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the account setting you want to list the settings for.
        /// </para>
        /// </summary>
        public SettingName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a <c>ListAccountSettings</c> request indicating
        /// that more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it's possible the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal, which can be a user, role, or the root user. If this field
        /// is omitted, the account settings are listed only for the authenticated user.
        /// </para>
        ///  
        /// <para>
        /// In order to use this parameter, you must be the root user, or the principal.
        /// </para>
        ///  <note> 
        /// <para>
        /// Federated users assume the account setting of the root user and can't have explicit
        /// account settings set for them.
        /// </para>
        ///  </note>
        /// </summary>
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the account settings to filter results with. You must also specify an
        /// account setting name to use this parameter.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}