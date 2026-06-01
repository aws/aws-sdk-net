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
    /// A reference to an existing custom prompt profile.
    /// </summary>
    public partial class CustomPromptProfile
    {
        private string _modelProfileId;
        private string _qbsAwsAccountId;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property ModelProfileId. 
        /// <para>
        /// The identifier of the model profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ModelProfileId
        {
            get { return this._modelProfileId; }
            set { this._modelProfileId = value; }
        }

        // Check to see if ModelProfileId property is set
        internal bool IsSetModelProfileId()
        {
            return this._modelProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property QbsAwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=15)]
        public string QbsAwsAccountId
        {
            get { return this._qbsAwsAccountId; }
            set { this._qbsAwsAccountId = value; }
        }

        // Check to see if QbsAwsAccountId property is set
        internal bool IsSetQbsAwsAccountId()
        {
            return this._qbsAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=32)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

    }
}