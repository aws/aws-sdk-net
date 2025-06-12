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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// This is the response object from the GetReadinessCheckResourceStatus operation.
    /// </summary>
    public partial class GetReadinessCheckResourceStatusResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private Readiness _readiness;
        private List<RuleResult> _rules = AWSConfigs.InitializeCollections ? new List<RuleResult>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that identifies which batch of results you want to see.
        /// </para>
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
        /// Gets and sets the property Readiness. 
        /// <para>
        /// The readiness at a rule level.
        /// </para>
        /// </summary>
        public Readiness Readiness
        {
            get { return this._readiness; }
            set { this._readiness = value; }
        }

        // Check to see if Readiness property is set
        internal bool IsSetReadiness()
        {
            return this._readiness != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Details of the rule's results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleResult> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}