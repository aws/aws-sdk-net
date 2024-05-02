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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
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
namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProblem operation.
    /// Updates the visibility of the problem or specifies the problem as <c>RESOLVED</c>.
    /// </summary>
    public partial class UpdateProblemRequest : AmazonApplicationInsightsRequest
    {
        private string _problemId;
        private UpdateStatus _updateStatus;
        private Visibility _visibility;

        /// <summary>
        /// Gets and sets the property ProblemId. 
        /// <para>
        /// The ID of the problem.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=38, Max=38)]
        public string ProblemId
        {
            get { return this._problemId; }
            set { this._problemId = value; }
        }

        // Check to see if ProblemId property is set
        internal bool IsSetProblemId()
        {
            return this._problemId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the problem. Arguments can be passed for only problems that show a status
        /// of <c>RECOVERING</c>.
        /// </para>
        /// </summary>
        public UpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Visibility. 
        /// <para>
        /// The visibility of a problem. When you pass a value of <c>IGNORED</c>, the problem
        /// is removed from the default view, and all notifications for the problem are suspended.
        /// When <c>VISIBLE</c> is passed, the <c>IGNORED</c> action is reversed.
        /// </para>
        /// </summary>
        public Visibility Visibility
        {
            get { return this._visibility; }
            set { this._visibility = value; }
        }

        // Check to see if Visibility property is set
        internal bool IsSetVisibility()
        {
            return this._visibility != null;
        }

    }
}