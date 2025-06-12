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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for a multivariate split activity in a journey. This type of
    /// activity sends participants down one of as many as five paths (including a default
    /// <i>Else</i> path) in a journey, based on conditions that you specify.
    /// 
    ///  <note>
    /// <para>
    /// To create multivariate split activities that send participants down different paths
    /// based on push notification events (such as Open or Received events), your mobile app
    /// has to specify the User ID and Endpoint ID values. For more information, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/integrate.html">Integrating
    /// Amazon Pinpoint with your application</a> in the <i>Amazon Pinpoint Developer Guide</i>.
    /// </para>
    /// </note>
    /// </summary>
    public partial class MultiConditionalSplitActivity
    {
        private List<MultiConditionalBranch> _branches = AWSConfigs.InitializeCollections ? new List<MultiConditionalBranch>() : null;
        private string _defaultActivity;
        private WaitTime _evaluationWaitTime;

        /// <summary>
        /// Gets and sets the property Branches. 
        /// <para>
        /// The paths for the activity, including the conditions for entering each path and the
        /// activity to perform for each path.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MultiConditionalBranch> Branches
        {
            get { return this._branches; }
            set { this._branches = value; }
        }

        // Check to see if Branches property is set
        internal bool IsSetBranches()
        {
            return this._branches != null && (this._branches.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DefaultActivity. 
        /// <para>
        /// The unique identifier for the activity to perform for participants who don't meet
        /// any of the conditions specified for other paths in the activity.
        /// </para>
        /// </summary>
        public string DefaultActivity
        {
            get { return this._defaultActivity; }
            set { this._defaultActivity = value; }
        }

        // Check to see if DefaultActivity property is set
        internal bool IsSetDefaultActivity()
        {
            return this._defaultActivity != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationWaitTime. 
        /// <para>
        /// The amount of time to wait or the date and time when Amazon Pinpoint determines whether
        /// the conditions are met.
        /// </para>
        /// </summary>
        public WaitTime EvaluationWaitTime
        {
            get { return this._evaluationWaitTime; }
            set { this._evaluationWaitTime = value; }
        }

        // Check to see if EvaluationWaitTime property is set
        internal bool IsSetEvaluationWaitTime()
        {
            return this._evaluationWaitTime != null;
        }

    }
}