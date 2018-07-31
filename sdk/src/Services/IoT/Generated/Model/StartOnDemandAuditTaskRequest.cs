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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the StartOnDemandAuditTask operation.
    /// Starts an on-demand Device Defender audit.
    /// </summary>
    public partial class StartOnDemandAuditTaskRequest : AmazonIoTRequest
    {
        private List<string> _targetCheckNames = new List<string>();

        /// <summary>
        /// Gets and sets the property TargetCheckNames. 
        /// <para>
        /// Which checks are performed during the audit. The checks you specify must be enabled
        /// for your account or an exception occurs. Use <code>DescribeAccountAuditConfiguration</code>
        /// to see the list of all checks including those that are enabled or <code>UpdateAccountAuditConfiguration</code>
        /// to select which checks are enabled.
        /// </para>
        /// </summary>
        public List<string> TargetCheckNames
        {
            get { return this._targetCheckNames; }
            set { this._targetCheckNames = value; }
        }

        // Check to see if TargetCheckNames property is set
        internal bool IsSetTargetCheckNames()
        {
            return this._targetCheckNames != null && this._targetCheckNames.Count > 0; 
        }

    }
}