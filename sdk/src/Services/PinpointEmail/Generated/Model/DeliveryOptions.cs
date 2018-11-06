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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Used to associate a configuration set with a dedicated IP pool.
    /// </summary>
    public partial class DeliveryOptions
    {
        private string _sendingPoolName;

        /// <summary>
        /// Gets and sets the property SendingPoolName. 
        /// <para>
        /// The name of the dedicated IP pool that you want to associate with the configuration
        /// set.
        /// </para>
        /// </summary>
        public string SendingPoolName
        {
            get { return this._sendingPoolName; }
            set { this._sendingPoolName = value; }
        }

        // Check to see if SendingPoolName property is set
        internal bool IsSetSendingPoolName()
        {
            return this._sendingPoolName != null;
        }

    }
}