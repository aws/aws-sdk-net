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
    /// Contains details about the project associated with the Engagement Invitation, including
    /// the business problem and expected outcomes.
    /// </summary>
    public partial class ProjectDetails
    {
        private string _businessProblem;
        private List<ExpectedCustomerSpend> _expectedCustomerSpend = AWSConfigs.InitializeCollections ? new List<ExpectedCustomerSpend>() : null;
        private string _targetCompletionDate;
        private string _title;

        /// <summary>
        /// Gets and sets the property BusinessProblem. 
        /// <para>
        /// Describes the business problem that the project aims to solve. This information is
        /// crucial for understanding the project’s goals and objectives.
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
        /// Gets and sets the property ExpectedCustomerSpend. 
        /// <para>
        /// Contains revenue estimates for the partner related to the project. This field provides
        /// an idea of the financial potential of the opportunity for the partner.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<ExpectedCustomerSpend> ExpectedCustomerSpend
        {
            get { return this._expectedCustomerSpend; }
            set { this._expectedCustomerSpend = value; }
        }

        // Check to see if ExpectedCustomerSpend property is set
        internal bool IsSetExpectedCustomerSpend()
        {
            return this._expectedCustomerSpend != null && (this._expectedCustomerSpend.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetCompletionDate. 
        /// <para>
        /// Specifies the estimated date of project completion. This field helps track the project
        /// timeline and manage expectations.
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
        /// Specifies the title of the project. This title helps partners quickly identify and
        /// understand the focus of the project.
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