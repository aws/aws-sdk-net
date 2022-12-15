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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _vmwareCategory;
        private string _vmwareTagDescription;
        private string _vmwareTagName;

        /// <summary>
        /// Gets and sets the property VmwareCategory. 
        /// <para>
        /// The is the category of VMware.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string VmwareCategory
        {
            get { return this._vmwareCategory; }
            set { this._vmwareCategory = value; }
        }

        // Check to see if VmwareCategory property is set
        internal bool IsSetVmwareCategory()
        {
            return this._vmwareCategory != null;
        }

        /// <summary>
        /// Gets and sets the property VmwareTagDescription. 
        /// <para>
        /// This is a user-defined description of a VMware tag.
        /// </para>
        /// </summary>
        public string VmwareTagDescription
        {
            get { return this._vmwareTagDescription; }
            set { this._vmwareTagDescription = value; }
        }

        // Check to see if VmwareTagDescription property is set
        internal bool IsSetVmwareTagDescription()
        {
            return this._vmwareTagDescription != null;
        }

        /// <summary>
        /// Gets and sets the property VmwareTagName. 
        /// <para>
        /// This is the user-defined name of a VMware tag.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string VmwareTagName
        {
            get { return this._vmwareTagName; }
            set { this._vmwareTagName = value; }
        }

        // Check to see if VmwareTagName property is set
        internal bool IsSetVmwareTagName()
        {
            return this._vmwareTagName != null;
        }

    }
}