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
    /// Information about the Capacity Reservation usage.
    /// </summary>
    public partial class InstanceUsage
    {
        private string _accountId;
        private int? _usedInstanceCount;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that is making use of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property UsedInstanceCount. 
        /// <para>
        /// The number of instances the Amazon Web Services account currently has in the Capacity
        /// Reservation.
        /// </para>
        /// </summary>
        public int? UsedInstanceCount
        {
            get { return this._usedInstanceCount; }
            set { this._usedInstanceCount = value; }
        }

        // Check to see if UsedInstanceCount property is set
        internal bool IsSetUsedInstanceCount()
        {
            return this._usedInstanceCount.HasValue; 
        }

    }
}