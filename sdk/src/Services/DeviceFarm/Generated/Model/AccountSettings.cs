/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// A container for account-level settings within AWS Device Farm.
    /// </summary>
    public partial class AccountSettings
    {
        private string _awsAccountNumber;
        private Dictionary<string, int> _unmeteredDevices = new Dictionary<string, int>();

        /// <summary>
        /// Gets and sets the property AwsAccountNumber. 
        /// <para>
        /// The AWS account number specified in the <code>AccountSettings</code> container.
        /// </para>
        /// </summary>
        public string AwsAccountNumber
        {
            get { return this._awsAccountNumber; }
            set { this._awsAccountNumber = value; }
        }

        // Check to see if AwsAccountNumber property is set
        internal bool IsSetAwsAccountNumber()
        {
            return this._awsAccountNumber != null;
        }

        /// <summary>
        /// Gets and sets the property UnmeteredDevices. 
        /// <para>
        /// Returns the unmetered devices you have purchased.
        /// </para>
        /// </summary>
        public Dictionary<string, int> UnmeteredDevices
        {
            get { return this._unmeteredDevices; }
            set { this._unmeteredDevices = value; }
        }

        // Check to see if UnmeteredDevices property is set
        internal bool IsSetUnmeteredDevices()
        {
            return this._unmeteredDevices != null && this._unmeteredDevices.Count > 0; 
        }

    }
}