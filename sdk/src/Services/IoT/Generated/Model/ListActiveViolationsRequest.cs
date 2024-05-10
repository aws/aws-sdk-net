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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListActiveViolations operation.
    /// Lists the active violations for a given Device Defender security profile.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListActiveViolations</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ListActiveViolationsRequest : AmazonIoTRequest
    {
        private BehaviorCriteriaType _behaviorCriteriaType;
        private bool? _listSuppressedAlerts;
        private int? _maxResults;
        private string _nextToken;
        private string _securityProfileName;
        private string _thingName;
        private VerificationState _verificationState;

        /// <summary>
        /// Gets and sets the property BehaviorCriteriaType. 
        /// <para>
        ///  The criteria for a behavior. 
        /// </para>
        /// </summary>
        public BehaviorCriteriaType BehaviorCriteriaType
        {
            get { return this._behaviorCriteriaType; }
            set { this._behaviorCriteriaType = value; }
        }

        // Check to see if BehaviorCriteriaType property is set
        internal bool IsSetBehaviorCriteriaType()
        {
            return this._behaviorCriteriaType != null;
        }

        /// <summary>
        /// Gets and sets the property ListSuppressedAlerts. 
        /// <para>
        ///  A list of all suppressed alerts. 
        /// </para>
        /// </summary>
        public bool? ListSuppressedAlerts
        {
            get { return this._listSuppressedAlerts; }
            set { this._listSuppressedAlerts = value; }
        }

        // Check to see if ListSuppressedAlerts property is set
        internal bool IsSetListSuppressedAlerts()
        {
            return this._listSuppressedAlerts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
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
        /// <para>
        /// The token for the next set of results.
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
        /// Gets and sets the property SecurityProfileName. 
        /// <para>
        /// The name of the Device Defender security profile for which violations are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecurityProfileName
        {
            get { return this._securityProfileName; }
            set { this._securityProfileName = value; }
        }

        // Check to see if SecurityProfileName property is set
        internal bool IsSetSecurityProfileName()
        {
            return this._securityProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The name of the thing whose active violations are listed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property VerificationState. 
        /// <para>
        /// The verification state of the violation (detect alarm).
        /// </para>
        /// </summary>
        public VerificationState VerificationState
        {
            get { return this._verificationState; }
            set { this._verificationState = value; }
        }

        // Check to see if VerificationState property is set
        internal bool IsSetVerificationState()
        {
            return this._verificationState != null;
        }

    }
}