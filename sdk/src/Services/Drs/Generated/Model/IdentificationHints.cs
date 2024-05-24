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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Hints used to uniquely identify a machine.
    /// </summary>
    public partial class IdentificationHints
    {
        private string _awsInstanceID;
        private string _fqdn;
        private string _hostname;
        private string _vmWareUuid;

        /// <summary>
        /// Gets and sets the property AwsInstanceID. 
        /// <para>
        /// AWS Instance ID identification hint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string AwsInstanceID
        {
            get { return this._awsInstanceID; }
            set { this._awsInstanceID = value; }
        }

        // Check to see if AwsInstanceID property is set
        internal bool IsSetAwsInstanceID()
        {
            return this._awsInstanceID != null;
        }

        /// <summary>
        /// Gets and sets the property Fqdn. 
        /// <para>
        /// Fully Qualified Domain Name identification hint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Fqdn
        {
            get { return this._fqdn; }
            set { this._fqdn = value; }
        }

        // Check to see if Fqdn property is set
        internal bool IsSetFqdn()
        {
            return this._fqdn != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// Hostname identification hint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Hostname
        {
            get { return this._hostname; }
            set { this._hostname = value; }
        }

        // Check to see if Hostname property is set
        internal bool IsSetHostname()
        {
            return this._hostname != null;
        }

        /// <summary>
        /// Gets and sets the property VmWareUuid. 
        /// <para>
        /// vCenter VM path identification hint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string VmWareUuid
        {
            get { return this._vmWareUuid; }
            set { this._vmWareUuid = value; }
        }

        // Check to see if VmWareUuid property is set
        internal bool IsSetVmWareUuid()
        {
            return this._vmWareUuid != null;
        }

    }
}