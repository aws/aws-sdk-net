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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the ListServices operation.
    /// Lists services.
    /// </summary>
    public partial class ListServicesRequest : AmazonResiliencehubv2Request
    {
        private string _accountId;
        private AssessmentStatus _assessmentStatus;
        private int? _maxResults;
        private string _nextToken;
        private string _ouId;
        private string _policyArn;
        private string _systemArn;
        private string _userJourneyId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Filter services by AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentStatus. 
        /// <para>
        /// Filter services by assessment status.
        /// </para>
        /// </summary>
        public AssessmentStatus AssessmentStatus
        {
            get { return this._assessmentStatus; }
            set { this._assessmentStatus = value; }
        }

        // Check to see if AssessmentStatus property is set
        internal bool IsSetAssessmentStatus()
        {
            return this._assessmentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
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
        /// Gets and sets the property OuId. 
        /// <para>
        /// Filter services by organizational unit (OU) identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=16, Max=68)]
        public string OuId
        {
            get { return this._ouId; }
            set { this._ouId = value; }
        }

        // Check to see if OuId property is set
        internal bool IsSetOuId()
        {
            return this._ouId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Min=31)]
        public string SystemArn
        {
            get { return this._systemArn; }
            set { this._systemArn = value; }
        }

        // Check to see if SystemArn property is set
        internal bool IsSetSystemArn()
        {
            return this._systemArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserJourneyId. 
        /// <para>
        /// Filter services by user journey identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string UserJourneyId
        {
            get { return this._userJourneyId; }
            set { this._userJourneyId = value; }
        }

        // Check to see if UserJourneyId property is set
        internal bool IsSetUserJourneyId()
        {
            return this._userJourneyId != null;
        }

    }
}