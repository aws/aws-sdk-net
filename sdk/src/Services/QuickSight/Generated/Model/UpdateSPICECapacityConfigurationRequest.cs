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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSPICECapacityConfiguration operation.
    /// Updates the SPICE capacity configuration for a QuickSight account.
    /// </summary>
    public partial class UpdateSPICECapacityConfigurationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private PurchaseMode _purchaseMode;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the SPICE configuration that
        /// you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PurchaseMode. 
        /// <para>
        /// Determines how SPICE capacity can be purchased. The following options are available.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MANUAL</c>: SPICE capacity can only be purchased manually.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTO_PURCHASE</c>: Extra SPICE capacity is automatically purchased on your behalf
        /// as needed. SPICE capacity can also be purchased manually with this option.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PurchaseMode PurchaseMode
        {
            get { return this._purchaseMode; }
            set { this._purchaseMode = value; }
        }

        // Check to see if PurchaseMode property is set
        internal bool IsSetPurchaseMode()
        {
            return this._purchaseMode != null;
        }

    }
}