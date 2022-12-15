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
    /// This displays the mapping of on-premises VMware tags to the corresponding Amazon Web
    /// Services tags.
    /// </summary>
    public partial class VmwareToAwsTagMapping
    {
        private string _awsTagKey;
        private string _awsTagValue;
        private string _vmwareCategory;
        private string _vmwareTagName;

        /// <summary>
        /// Gets and sets the property AwsTagKey. 
        /// <para>
        /// The key part of the Amazon Web Services tag's key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string AwsTagKey
        {
            get { return this._awsTagKey; }
            set { this._awsTagKey = value; }
        }

        // Check to see if AwsTagKey property is set
        internal bool IsSetAwsTagKey()
        {
            return this._awsTagKey != null;
        }

        /// <summary>
        /// Gets and sets the property AwsTagValue. 
        /// <para>
        /// The value part of the Amazon Web Services tag's key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string AwsTagValue
        {
            get { return this._awsTagValue; }
            set { this._awsTagValue = value; }
        }

        // Check to see if AwsTagValue property is set
        internal bool IsSetAwsTagValue()
        {
            return this._awsTagValue != null;
        }

        /// <summary>
        /// Gets and sets the property VmwareCategory. 
        /// <para>
        /// The is the category of VMware.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property VmwareTagName. 
        /// <para>
        /// This is the user-defined name of a VMware tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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