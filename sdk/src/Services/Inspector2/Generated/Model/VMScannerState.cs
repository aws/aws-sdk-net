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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The state of the Amazon Inspector VM scanner.
    /// </summary>
    public partial class VMScannerState
    {
        private bool? _activated;
        private DateTime? _activatedAt;
        private VMScannerStatus _status;

        /// <summary>
        /// Gets and sets the property Activated. 
        /// <para>
        /// Whether the VM scanner is activated.
        /// </para>
        /// </summary>
        public bool? Activated
        {
            get { return this._activated; }
            set { this._activated = value; }
        }

        // Check to see if Activated property is set
        internal bool IsSetActivated()
        {
            return this._activated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The date and time the VM scanner was activated.
        /// </para>
        /// </summary>
        public DateTime? ActivatedAt
        {
            get { return this._activatedAt; }
            set { this._activatedAt = value; }
        }

        // Check to see if ActivatedAt property is set
        internal bool IsSetActivatedAt()
        {
            return this._activatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the VM scanner.
        /// </para>
        /// </summary>
        public VMScannerStatus Status
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