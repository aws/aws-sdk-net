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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LTE local identification (local ID) information.
    /// </summary>
    public partial class LteLocalId
    {
        /// <summary>
        /// Gets and sets the property Earfcn. 
        /// <para>
        /// Evolved universal terrestrial radio access (E-UTRA) absolute radio frequency channel
        /// number (FCN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 262143)]
        public int? Earfcn { get; set; }

        /// <summary>
        /// Checks to see if the Earfcn property is set.
        /// </summary>
        internal bool IsSetEarfcn() => this.Earfcn.HasValue;

        /// <summary>
        /// Gets and sets the property Pci. 
        /// <para>
        /// Physical cell ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 503)]
        public int? Pci { get; set; }

        /// <summary>
        /// Checks to see if the Pci property is set.
        /// </summary>
        internal bool IsSetPci() => this.Pci.HasValue;
    }
}
