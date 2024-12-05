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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Provides the lifecycle view of an opportunity resource shared through a snapshot.
    /// </summary>
    public partial class LifeCycleForView
    {
        private string _nextSteps;
        private ReviewStatus _reviewStatus;
        private Stage _stage;
        private string _targetCloseDate;

        /// <summary>
        /// Gets and sets the property NextSteps. 
        /// <para>
        ///  Describes the next steps for the opportunity shared through a snapshot. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=255)]
        public string NextSteps
        {
            get { return this._nextSteps; }
            set { this._nextSteps = value; }
        }

        // Check to see if NextSteps property is set
        internal bool IsSetNextSteps()
        {
            return this._nextSteps != null;
        }

        /// <summary>
        /// Gets and sets the property ReviewStatus. 
        /// <para>
        ///  Defines the approval status of the opportunity shared through a snapshot. 
        /// </para>
        /// </summary>
        public ReviewStatus ReviewStatus
        {
            get { return this._reviewStatus; }
            set { this._reviewStatus = value; }
        }

        // Check to see if ReviewStatus property is set
        internal bool IsSetReviewStatus()
        {
            return this._reviewStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Stage. 
        /// <para>
        ///  Defines the current stage of the opportunity shared through a snapshot. 
        /// </para>
        /// </summary>
        public Stage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCloseDate. 
        /// <para>
        ///  The projected launch date of the opportunity shared through a snapshot. 
        /// </para>
        /// </summary>
        public string TargetCloseDate
        {
            get { return this._targetCloseDate; }
            set { this._targetCloseDate = value; }
        }

        // Check to see if TargetCloseDate property is set
        internal bool IsSetTargetCloseDate()
        {
            return this._targetCloseDate != null;
        }

    }
}