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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetPatchBaselineForPatchGroup operation.
    /// Retrieves the patch baseline that should be used for the specified patch group.
    /// </summary>
    public partial class GetPatchBaselineForPatchGroupRequest : AmazonSimpleSystemsManagementRequest
    {
        private OperatingSystem _operatingSystem;
        private string _patchGroup;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// Returns the operating system rule specified for patch groups using the patch baseline.
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

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group whose patch baseline should be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PatchGroup
        {
            get { return this._patchGroup; }
            set { this._patchGroup = value; }
        }

        // Check to see if PatchGroup property is set
        internal bool IsSetPatchGroup()
        {
            return this._patchGroup != null;
        }

    }
}