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
    /// Details about the state of the EC2 scan configuration for your environment.
    /// </summary>
    public partial class Ec2ConfigurationState
    {
        private Ec2ScanModeState _scanModeState;

        /// <summary>
        /// Gets and sets the property ScanModeState. 
        /// <para>
        /// An object that contains details about the state of the Amazon EC2 scan mode.
        /// </para>
        /// </summary>
        public Ec2ScanModeState ScanModeState
        {
            get { return this._scanModeState; }
            set { this._scanModeState = value; }
        }

        // Check to see if ScanModeState property is set
        internal bool IsSetScanModeState()
        {
            return this._scanModeState != null;
        }

    }
}