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

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// A VMware tag is a tag attached to a specific virtual machine. A <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_BGW_Tag.html">tag</a>
    /// is a key-value pair you can use to manage, filter, and search for your resources.
    /// 
    ///  
    /// <para>
    /// The content of VMware tags can be matched to Amazon Web Services tags.
    /// </para>
    /// </summary>
    public partial class VmwareTag
    {
        /// <summary>
        /// Gets and sets the property VmwareCategory. 
        /// <para>
        /// The is the category of VMware.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string VmwareCategory { get; set; }

        /// <summary>
        /// Checks to see if the VmwareCategory property is set.
        /// </summary>
        internal bool IsSetVmwareCategory() => this.VmwareCategory != null;

        /// <summary>
        /// Gets and sets the property VmwareTagDescription. 
        /// <para>
        /// This is a user-defined description of a VMware tag.
        /// </para>
        /// </summary>
        public string VmwareTagDescription { get; set; }

        /// <summary>
        /// Checks to see if the VmwareTagDescription property is set.
        /// </summary>
        internal bool IsSetVmwareTagDescription() => this.VmwareTagDescription != null;

        /// <summary>
        /// Gets and sets the property VmwareTagName. 
        /// <para>
        /// This is the user-defined name of a VMware tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string VmwareTagName { get; set; }

        /// <summary>
        /// Checks to see if the VmwareTagName property is set.
        /// </summary>
        internal bool IsSetVmwareTagName() => this.VmwareTagName != null;
    }
}
