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
    /// The state of your Amazon EC2 scan mode configuration.
    /// </summary>
    public partial class Ec2ScanModeState
    {
        private Ec2ScanMode _scanMode;
        private Ec2ScanModeStatus _scanModeStatus;

        /// <summary>
        /// Gets and sets the property ScanMode. 
        /// <para>
        /// The scan method that is applied to the instance.
        /// </para>
        /// </summary>
        public Ec2ScanMode ScanMode
        {
            get { return this._scanMode; }
            set { this._scanMode = value; }
        }

        // Check to see if ScanMode property is set
        internal bool IsSetScanMode()
        {
            return this._scanMode != null;
        }

        /// <summary>
        /// Gets and sets the property ScanModeStatus. 
        /// <para>
        /// The status of the Amazon EC2 scan mode setting.
        /// </para>
        /// </summary>
        public Ec2ScanModeStatus ScanModeStatus
        {
            get { return this._scanModeStatus; }
            set { this._scanModeStatus = value; }
        }

        // Check to see if ScanModeStatus property is set
        internal bool IsSetScanModeStatus()
        {
            return this._scanModeStatus != null;
        }

    }
}