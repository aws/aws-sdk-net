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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// vCenter client.
    /// </summary>
    public partial class VcenterClient
    {
        private string _arn;
        private string _datacenterName;
        private string _hostname;
        private string _lastSeenDatetime;
        private Dictionary<string, string> _sourceServerTags = new Dictionary<string, string>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _vcenterClientID;
        private string _vcenteruuid;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Arn of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DatacenterName. 
        /// <para>
        /// Datacenter name of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DatacenterName
        {
            get { return this._datacenterName; }
            set { this._datacenterName = value; }
        }

        // Check to see if DatacenterName property is set
        internal bool IsSetDatacenterName()
        {
            return this._datacenterName != null;
        }

        /// <summary>
        /// Gets and sets the property Hostname. 
        /// <para>
        /// Hostname of vCenter client .
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
        /// Gets and sets the property LastSeenDatetime. 
        /// <para>
        /// Last seen time of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LastSeenDatetime
        {
            get { return this._lastSeenDatetime; }
            set { this._lastSeenDatetime = value; }
        }

        // Check to see if LastSeenDatetime property is set
        internal bool IsSetLastSeenDatetime()
        {
            return this._lastSeenDatetime != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerTags. 
        /// <para>
        /// Tags for Source Server of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> SourceServerTags
        {
            get { return this._sourceServerTags; }
            set { this._sourceServerTags = value; }
        }

        // Check to see if SourceServerTags property is set
        internal bool IsSetSourceServerTags()
        {
            return this._sourceServerTags != null && this._sourceServerTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VcenterClientID. 
        /// <para>
        /// ID of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string VcenterClientID
        {
            get { return this._vcenterClientID; }
            set { this._vcenterClientID = value; }
        }

        // Check to see if VcenterClientID property is set
        internal bool IsSetVcenterClientID()
        {
            return this._vcenterClientID != null;
        }

        /// <summary>
        /// Gets and sets the property VcenterUUID. 
        /// <para>
        /// Vcenter UUID of vCenter client.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string VcenterUUID
        {
            get { return this._vcenteruuid; }
            set { this._vcenteruuid = value; }
        }

        // Check to see if VcenterUUID property is set
        internal bool IsSetVcenterUUID()
        {
            return this._vcenteruuid != null;
        }

    }
}