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
    /// Container for the parameters to the DescribeKeyRegistration operation.
    /// Describes all customer managed key registrations in a QuickSight account.
    /// </summary>
    public partial class DescribeKeyRegistrationRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private bool? _defaultKeyOnly;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the customer managed key registration
        /// that you want to describe.
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
        /// Gets and sets the property DefaultKeyOnly. 
        /// <para>
        /// Determines whether the request returns the default key only.
        /// </para>
        /// </summary>
        public bool? DefaultKeyOnly
        {
            get { return this._defaultKeyOnly; }
            set { this._defaultKeyOnly = value; }
        }

        // Check to see if DefaultKeyOnly property is set
        internal bool IsSetDefaultKeyOnly()
        {
            return this._defaultKeyOnly.HasValue; 
        }

    }
}