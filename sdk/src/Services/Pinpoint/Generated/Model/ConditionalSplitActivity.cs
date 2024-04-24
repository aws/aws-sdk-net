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
    /// Specifies the settings for a yes/no split activity in a journey. This type of activity
    /// sends participants down one of two paths in a journey, based on conditions that you
    /// specify.
    /// 
    ///  <note>
    /// <para>
    /// To create yes/no split activities that send participants down different paths based
    /// on push notification events (such as Open or Received events), your mobile app has
    /// to specify the User ID and Endpoint ID values. For more information, see <a href="https://docs.aws.amazon.com/pinpoint/latest/developerguide/integrate.html">Integrating
    /// Amazon Pinpoint with your application</a> in the <i>Amazon Pinpoint Developer Guide</i>.
    /// </para>
    /// </note>
    /// </summary>
    public partial class ConditionalSplitActivity
    {
        private Condition _condition;
        private WaitTime _evaluationWaitTime;
        private string _falseActivity;
        private string _trueActivity;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The conditions that define the paths for the activity, and the relationship between
        /// the conditions.
        /// </para>
        /// </summary>
        public Condition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationWaitTime. 
        /// <para>
        /// The amount of time to wait before determining whether the conditions are met, or the
        /// date and time when Amazon Pinpoint determines whether the conditions are met.
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

        /// <summary>
        /// Gets and sets the property FalseActivity. 
        /// <para>
        /// The unique identifier for the activity to perform if the conditions aren't met.
        /// </para>
        /// </summary>
        public string FalseActivity
        {
            get { return this._falseActivity; }
            set { this._falseActivity = value; }
        }

        // Check to see if FalseActivity property is set
        internal bool IsSetFalseActivity()
        {
            return this._falseActivity != null;
        }

        /// <summary>
        /// Gets and sets the property TrueActivity. 
        /// <para>
        /// The unique identifier for the activity to perform if the conditions are met.
        /// </para>
        /// </summary>
        public string TrueActivity
        {
            get { return this._trueActivity; }
            set { this._trueActivity = value; }
        }

        // Check to see if TrueActivity property is set
        internal bool IsSetTrueActivity()
        {
            return this._trueActivity != null;
        }

    }
}