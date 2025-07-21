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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a volume status.
    /// </summary>
    public partial class VolumeStatusDetails
    {
        private VolumeStatusName _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the volume status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>io-enabled</c> - Indicates the volume I/O status. For more information, see <a
        /// href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-checks.html">Amazon
        /// EBS volume status checks</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io-performance</c> - Indicates the volume performance status. For more information,
        /// see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/monitoring-volume-checks.html">Amazon
        /// EBS volume status checks</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>initialization-state</c> - Indicates the status of the volume initialization process.
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">Initialize
        /// Amazon EBS volumes</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public VolumeStatusName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The intended status of the volume status.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}