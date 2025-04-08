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
    /// The configuration settings for the email alerts that are sent when a dataset refresh
    /// fails.
    /// </summary>
    public partial class RefreshFailureEmailAlert
    {
        private RefreshFailureAlertStatus _alertStatus;

        /// <summary>
        /// Gets and sets the property AlertStatus. 
        /// <para>
        /// The status value that determines if email alerts are sent.
        /// </para>
        /// </summary>
        public RefreshFailureAlertStatus AlertStatus
        {
            get { return this._alertStatus; }
            set { this._alertStatus = value; }
        }

        // Check to see if AlertStatus property is set
        internal bool IsSetAlertStatus()
        {
            return this._alertStatus != null;
        }

    }
}