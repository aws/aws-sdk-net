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
    /// Container for the parameters to the UpdateKeyRegistration operation.
    /// Updates a customer managed key in a QuickSight account.
    /// </summary>
    public partial class UpdateKeyRegistrationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private List<RegisteredCustomerManagedKey> _keyRegistration = AWSConfigs.InitializeCollections ? new List<RegisteredCustomerManagedKey>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the customer managed key registration
        /// that you want to update.
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
        /// Gets and sets the property KeyRegistration. 
        /// <para>
        /// A list of <c>RegisteredCustomerManagedKey</c> objects to be updated to the QuickSight
        /// account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RegisteredCustomerManagedKey> KeyRegistration
        {
            get { return this._keyRegistration; }
            set { this._keyRegistration = value; }
        }

        // Check to see if KeyRegistration property is set
        internal bool IsSetKeyRegistration()
        {
            return this._keyRegistration != null && (this._keyRegistration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}