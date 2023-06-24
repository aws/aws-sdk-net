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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LTE local identification (local ID) information.
    /// </summary>
    public partial class LteLocalId
    {
        private int? _earfcn;
        private int? _pci;

        /// <summary>
        /// Gets and sets the property Earfcn. 
        /// <para>
        /// Evolved universal terrestrial radio access (E-UTRA) absolute radio frequency channel
        /// number (FCN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=262143)]
        public int Earfcn
        {
            get { return this._earfcn.GetValueOrDefault(); }
            set { this._earfcn = value; }
        }

        // Check to see if Earfcn property is set
        internal bool IsSetEarfcn()
        {
            return this._earfcn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pci. 
        /// <para>
        /// Physical cell ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=503)]
        public int Pci
        {
            get { return this._pci.GetValueOrDefault(); }
            set { this._pci = value; }
        }

        // Check to see if Pci property is set
        internal bool IsSetPci()
        {
            return this._pci.HasValue; 
        }

    }
}