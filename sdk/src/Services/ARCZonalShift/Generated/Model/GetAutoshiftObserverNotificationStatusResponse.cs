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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// This is the response object from the GetAutoshiftObserverNotificationStatus operation.
    /// </summary>
    public partial class GetAutoshiftObserverNotificationStatusResponse : AmazonWebServiceResponse
    {
        private AutoshiftObserverNotificationStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of autoshift observer notification. If the status is <c>ENABLED</c>, ARC
        /// includes all autoshift events when you use the Amazon EventBridge pattern <c>Autoshift
        /// In Progress</c>. When the status is <c>DISABLED</c>, ARC includes only autoshift events
        /// for autoshifts when one or more of your resources is included in the autoshift. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoshiftObserverNotificationStatus Status
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