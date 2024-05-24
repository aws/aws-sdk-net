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
    /// A DNS alias that is associated with the file system. You can use a DNS alias to access
    /// a file system using user-defined DNS names, in addition to the default DNS name that
    /// Amazon FSx assigns to the file system. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-dns-aliases.html">DNS
    /// aliases</a> in the <i>FSx for Windows File Server User Guide</i>.
    /// </summary>
    public partial class Alias
    {
        private AliasLifecycle _lifecycle;
        private string _name;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the state of the DNS alias.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AVAILABLE - The DNS alias is associated with an Amazon FSx file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATING - Amazon FSx is creating the DNS alias and associating it with the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED - Amazon FSx was unable to associate the DNS alias with the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING - Amazon FSx is disassociating the DNS alias from the file system and deleting
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED - Amazon FSx was unable to disassociate the DNS alias from the file
        /// system.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AliasLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the DNS alias. The alias name has to meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Formatted as a fully-qualified domain name (FQDN), <c>hostname.domain</c>, for example,
        /// <c>accounting.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can contain alphanumeric characters, the underscore (_), and the hyphen (-).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot start or end with a hyphen.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can start with a numeric.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For DNS names, Amazon FSx stores alphabetic characters as lowercase letters (a-z),
        /// regardless of how you specify them: as uppercase letters, lowercase letters, or the
        /// corresponding letters in escape codes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=253)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}