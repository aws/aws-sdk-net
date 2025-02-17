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
    /// Provides comprehensive details about a customer project associated with an Engagement.
    /// This may include information such as project goals, timelines, and specific customer
    /// requirements.
    /// </summary>
    public partial class EngagementCustomerProjectDetails
    {
        private string _businessProblem;
        private string _targetCompletionDate;
        private string _title;

        /// <summary>
        /// Gets and sets the property BusinessProblem. 
        /// <para>
        /// A description of the business problem the project aims to solve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=20, Max=255)]
        public string BusinessProblem
        {
            get { return this._businessProblem; }
            set { this._businessProblem = value; }
        }

        // Check to see if BusinessProblem property is set
        internal bool IsSetBusinessProblem()
        {
            return this._businessProblem != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCompletionDate. 
        /// <para>
        /// The target completion date for the customer's project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetCompletionDate
        {
            get { return this._targetCompletionDate; }
            set { this._targetCompletionDate = value; }
        }

        // Check to see if TargetCompletionDate property is set
        internal bool IsSetTargetCompletionDate()
        {
            return this._targetCompletionDate != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}