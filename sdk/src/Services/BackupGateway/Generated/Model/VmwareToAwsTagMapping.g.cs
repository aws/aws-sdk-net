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
    /// This displays the mapping of VMware tags to the corresponding Amazon Web Services
    /// tags.
    /// </summary>
    public partial class VmwareToAwsTagMapping
    {
        /// <summary>
        /// Gets and sets the property AwsTagKey. 
        /// <para>
        /// The key part of the Amazon Web Services tag's key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string AwsTagKey { get; set; }

        /// <summary>
        /// Checks to see if the AwsTagKey property is set.
        /// </summary>
        internal bool IsSetAwsTagKey() => this.AwsTagKey != null;

        /// <summary>
        /// Gets and sets the property AwsTagValue. 
        /// <para>
        /// The value part of the Amazon Web Services tag's key-value pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string AwsTagValue { get; set; }

        /// <summary>
        /// Checks to see if the AwsTagValue property is set.
        /// </summary>
        internal bool IsSetAwsTagValue() => this.AwsTagValue != null;

        /// <summary>
        /// Gets and sets the property VmwareCategory. 
        /// <para>
        /// The is the category of VMware.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string VmwareCategory { get; set; }

        /// <summary>
        /// Checks to see if the VmwareCategory property is set.
        /// </summary>
        internal bool IsSetVmwareCategory() => this.VmwareCategory != null;

        /// <summary>
        /// Gets and sets the property VmwareTagName. 
        /// <para>
        /// This is the user-defined name of a VMware tag.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 80)]
        public string VmwareTagName { get; set; }

        /// <summary>
        /// Checks to see if the VmwareTagName property is set.
        /// </summary>
        internal bool IsSetVmwareTagName() => this.VmwareTagName != null;
    }
}
