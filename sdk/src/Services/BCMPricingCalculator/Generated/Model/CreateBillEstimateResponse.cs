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
 * Do not modify this file. This file is generated from the bcm-pricing-calculator-2024-06-19.normal.json service model.
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
namespace Amazon.BCMPricingCalculator.Model
{
    /// <summary>
    /// This is the response object from the CreateBillEstimate operation.
    /// </summary>
    public partial class CreateBillEstimateResponse : AmazonWebServiceResponse
    {
        private BillInterval _billInterval;
        private BillEstimateCostSummary _costSummary;
        private DateTime? _createdAt;
        private DateTime? _expiresAt;
        private string _failureMessage;
        private string _id;
        private string _name;
        private BillEstimateStatus _status;

        /// <summary>
        /// Gets and sets the property BillInterval. 
        /// <para>
        ///  The bill month start and end timestamp that was used to create the Bill estimate.
        /// This is set to the last complete anniversary bill month start and end timestamp. 
        /// </para>
        /// </summary>
        public BillInterval BillInterval
        {
            get { return this._billInterval; }
            set { this._billInterval = value; }
        }

        // Check to see if BillInterval property is set
        internal bool IsSetBillInterval()
        {
            return this._billInterval != null;
        }

        /// <summary>
        /// Gets and sets the property CostSummary. 
        /// <para>
        ///  Returns summary-level cost information once a Bill estimate is successfully generated.
        /// This summary includes: 1) the total cost difference, showing the pre-tax cost change
        /// for the consolidated billing family between the completed anniversary bill and the
        /// estimated bill, and 2) total cost differences per service, detailing the pre-tax cost
        /// of each service, comparing the completed anniversary bill to the estimated bill on
        /// a per-service basis. 
        /// </para>
        /// </summary>
        public BillEstimateCostSummary CostSummary
        {
            get { return this._costSummary; }
            set { this._costSummary = value; }
        }

        // Check to see if CostSummary property is set
        internal bool IsSetCostSummary()
        {
            return this._costSummary != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp of when the Bill estimate create process was started (not when it successfully
        /// completed or failed). 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        ///  The timestamp of when the Bill estimate will expire. A Bill estimate becomes inaccessible
        /// after expiration. 
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt
        {
            get { return this._expiresAt; }
            set { this._expiresAt = value; }
        }

        // Check to see if ExpiresAt property is set
        internal bool IsSetExpiresAt()
        {
            return this._expiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        ///  This attribute provides the reason if a Bill estimate result generation fails. 
        /// </para>
        /// </summary>
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier of your newly created Bill estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of your newly created Bill estimate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string Name
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
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of your newly created Bill estimate. Bill estimate creation can take anywhere
        /// between 8 to 12 hours. The status will allow you to identify when the Bill estimate
        /// is complete or has failed. 
        /// </para>
        /// </summary>
        public BillEstimateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}