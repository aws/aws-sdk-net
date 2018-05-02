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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetDefaultPatchBaseline operation.
    /// Retrieves the default patch baseline. Note that Systems Manager supports creating
    /// multiple default patch baselines. For example, you can create a default patch baseline
    /// for each operating system.
    /// 
    ///  
    /// <para>
    /// If you do not specify an operating system value, the default patch baseline for Windows
    /// is returned.
    /// </para>
    /// </summary>
    public partial class GetDefaultPatchBaselineRequest : AmazonSimpleSystemsManagementRequest
    {
        private OperatingSystem _operatingSystem;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Returns the default patch baseline for the specified operating system.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

    }
}