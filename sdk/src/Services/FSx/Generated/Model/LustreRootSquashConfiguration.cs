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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// The configuration for Lustre root squash used to restrict root-level access from clients
    /// that try to access your FSx for Lustre file system as root. Use the <c>RootSquash</c>
    /// parameter to enable root squash. To learn more about Lustre root squash, see <a href="https://docs.aws.amazon.com/fsx/latest/LustreGuide/root-squash.html">Lustre
    /// root squash</a>.
    /// 
    ///  
    /// <para>
    /// You can also use the <c>NoSquashNids</c> parameter to provide an array of clients
    /// who are not affected by the root squash setting. These clients will access the file
    /// system as root, with unrestricted privileges.
    /// </para>
    /// </summary>
    public partial class LustreRootSquashConfiguration
    {
        private List<string> _noSquashNids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _rootSquash;

        /// <summary>
        /// Gets and sets the property NoSquashNids. 
        /// <para>
        /// When root squash is enabled, you can optionally specify an array of NIDs of clients
        /// for which root squash does not apply. A client NID is a Lustre Network Identifier
        /// used to uniquely identify a client. You can specify the NID as either a single address
        /// or a range of addresses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A single address is described in standard Lustre NID format by specifying the client’s
        /// IP address followed by the Lustre network ID (for example, <c>10.0.1.6@tcp</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An address range is described using a dash to separate the range (for example, <c>10.0.[2-10].[1-255]@tcp</c>).
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=64)]
        public List<string> NoSquashNids
        {
            get { return this._noSquashNids; }
            set { this._noSquashNids = value; }
        }

        // Check to see if NoSquashNids property is set
        internal bool IsSetNoSquashNids()
        {
            return this._noSquashNids != null && (this._noSquashNids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RootSquash. 
        /// <para>
        /// You enable root squash by setting a user ID (UID) and group ID (GID) for the file
        /// system in the format <c>UID:GID</c> (for example, <c>365534:65534</c>). The UID and
        /// GID values can range from <c>0</c> to <c>4294967294</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A non-zero value for UID and GID enables root squash. The UID and GID values can be
        /// different, but each must be a non-zero value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A value of <c>0</c> (zero) for UID and GID indicates root, and therefore disables
        /// root squash.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When root squash is enabled, the user ID and group ID of a root user accessing the
        /// file system are re-mapped to the UID and GID you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=21)]
        public string RootSquash
        {
            get { return this._rootSquash; }
            set { this._rootSquash = value; }
        }

        // Check to see if RootSquash property is set
        internal bool IsSetRootSquash()
        {
            return this._rootSquash != null;
        }

    }
}