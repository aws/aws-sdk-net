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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Represents an object that contains entries and targets for <c>HomeDirectoryMappings</c>.
    /// 
    ///  
    /// <para>
    /// The following is an <c>Entry</c> and <c>Target</c> pair example for <c>chroot</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>[ { "Entry": "/", "Target": "/bucket_name/home/mydirectory" } ]</c> 
    /// </para>
    /// </summary>
    public partial class HomeDirectoryMapEntry
    {
        /// <summary>
        /// Gets and sets the property Entry. 
        /// <para>
        /// Represents an entry for <c>HomeDirectoryMappings</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Entry { get; set; }

        /// <summary>
        /// Checks to see if the Entry property is set.
        /// </summary>
        internal bool IsSetEntry() => this.Entry != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Represents the map target that is used in a <c>HomeDirectoryMapEntry</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the type of mapping. Set the type to <c>FILE</c> if you want the mapping
        /// to point to a file, or <c>DIRECTORY</c> for the directory to point to a directory.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, home directory mappings have a <c>Type</c> of <c>DIRECTORY</c> when you
        /// create a Transfer Family server. You would need to explicitly set <c>Type</c> to <c>FILE</c>
        /// if you want a mapping to have a file target.
        /// </para>
        ///  </note>
        /// </summary>
        public MapType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
