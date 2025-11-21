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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// The license information that Amazon EVS requires to create an environment. Amazon
    /// EVS requires two license keys: a VCF solution key and a vSAN license key.
    /// </summary>
    public partial class LicenseInfo
    {
        private string _solutionKey;
        private string _vsanKey;

        /// <summary>
        /// Gets and sets the property SolutionKey. 
        /// <para>
        ///  The VCF solution key. This license unlocks VMware VCF product features, including
        /// vSphere, NSX, SDDC Manager, and vCenter Server. The VCF solution key must cover a
        /// minimum of 256 cores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SolutionKey
        {
            get { return this._solutionKey; }
            set { this._solutionKey = value; }
        }

        // Check to see if SolutionKey property is set
        internal bool IsSetSolutionKey()
        {
            return this._solutionKey != null;
        }

        /// <summary>
        /// Gets and sets the property VsanKey. 
        /// <para>
        ///  The VSAN license key. This license unlocks vSAN features. The vSAN license key must
        /// provide at least 110 TiB of vSAN capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VsanKey
        {
            get { return this._vsanKey; }
            set { this._vsanKey = value; }
        }

        // Check to see if VsanKey property is set
        internal bool IsSetVsanKey()
        {
            return this._vsanKey != null;
        }

    }
}