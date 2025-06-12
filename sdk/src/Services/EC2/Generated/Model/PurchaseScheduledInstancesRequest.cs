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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseScheduledInstances operation.
    /// <note> 
    /// <para>
    /// You can no longer purchase Scheduled Instances.
    /// </para>
    ///  </note> 
    /// <para>
    /// Purchases the Scheduled Instances with the specified schedule.
    /// </para>
    ///  
    /// <para>
    /// Scheduled Instances enable you to purchase Amazon EC2 compute capacity by the hour
    /// for a one-year term. Before you can purchase a Scheduled Instance, you must call <a>DescribeScheduledInstanceAvailability</a>
    /// to check for available schedules and obtain a purchase token. After you purchase a
    /// Scheduled Instance, you must call <a>RunScheduledInstances</a> during each scheduled
    /// time period.
    /// </para>
    ///  
    /// <para>
    /// After you purchase a Scheduled Instance, you can't cancel, modify, or resell your
    /// purchase.
    /// </para>
    /// </summary>
    public partial class PurchaseScheduledInstancesRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _dryRun;
        private List<PurchaseRequest> _purchaseRequests = AWSConfigs.InitializeCollections ? new List<PurchaseRequest>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that ensures the idempotency of the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PurchaseRequests. 
        /// <para>
        /// The purchase requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<PurchaseRequest> PurchaseRequests
        {
            get { return this._purchaseRequests; }
            set { this._purchaseRequests = value; }
        }

        // Check to see if PurchaseRequests property is set
        internal bool IsSetPurchaseRequests()
        {
            return this._purchaseRequests != null && (this._purchaseRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}