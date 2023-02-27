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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your source content has EIA-608 Line 21 Data Services, enable this feature to specify
    /// what MediaConvert does with the Extended Data Services (XDS) packets. You can choose
    /// to pass through XDS packets, or remove them from the output. For more information
    /// about XDS, see EIA-608 Line Data Services, section 9.5.1.5 05h Content Advisory.
    /// </summary>
    public partial class ExtendedDataServices
    {
        private CopyProtectionAction _copyProtectionAction;
        private VchipAction _vchipAction;

        /// <summary>
        /// Gets and sets the property CopyProtectionAction. The action to take on copy and redistribution
        /// control XDS packets. If you select PASSTHROUGH, packets will not be changed. If you
        /// select STRIP, any packets will be removed in output captions.
        /// </summary>
        public CopyProtectionAction CopyProtectionAction
        {
            get { return this._copyProtectionAction; }
            set { this._copyProtectionAction = value; }
        }

        // Check to see if CopyProtectionAction property is set
        internal bool IsSetCopyProtectionAction()
        {
            return this._copyProtectionAction != null;
        }

        /// <summary>
        /// Gets and sets the property VchipAction. The action to take on content advisory XDS
        /// packets. If you select PASSTHROUGH, packets will not be changed. If you select STRIP,
        /// any packets will be removed in output captions.
        /// </summary>
        public VchipAction VchipAction
        {
            get { return this._vchipAction; }
            set { this._vchipAction = value; }
        }

        // Check to see if VchipAction property is set
        internal bool IsSetVchipAction()
        {
            return this._vchipAction != null;
        }

    }
}