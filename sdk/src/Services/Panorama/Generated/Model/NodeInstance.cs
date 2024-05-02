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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A node instance.
    /// </summary>
    public partial class NodeInstance
    {
        private NodeInstanceStatus _currentStatus;
        private string _nodeId;
        private string _nodeInstanceId;
        private string _nodeName;
        private string _packageName;
        private string _packagePatchVersion;
        private string _packageVersion;

        /// <summary>
        /// Gets and sets the property CurrentStatus. 
        /// <para>
        /// The instance's current status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeInstanceStatus CurrentStatus
        {
            get { return this._currentStatus; }
            set { this._currentStatus = value; }
        }

        // Check to see if CurrentStatus property is set
        internal bool IsSetCurrentStatus()
        {
            return this._currentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The node's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeInstanceId. 
        /// <para>
        /// The instance's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NodeInstanceId
        {
            get { return this._nodeInstanceId; }
            set { this._nodeInstanceId = value; }
        }

        // Check to see if NodeInstanceId property is set
        internal bool IsSetNodeInstanceId()
        {
            return this._nodeInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The instance's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string NodeName
        {
            get { return this._nodeName; }
            set { this._nodeName = value; }
        }

        // Check to see if NodeName property is set
        internal bool IsSetNodeName()
        {
            return this._nodeName != null;
        }

        /// <summary>
        /// Gets and sets the property PackageName. 
        /// <para>
        /// The instance's package name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string PackageName
        {
            get { return this._packageName; }
            set { this._packageName = value; }
        }

        // Check to see if PackageName property is set
        internal bool IsSetPackageName()
        {
            return this._packageName != null;
        }

        /// <summary>
        /// Gets and sets the property PackagePatchVersion. 
        /// <para>
        /// The instance's package patch version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackagePatchVersion
        {
            get { return this._packagePatchVersion; }
            set { this._packagePatchVersion = value; }
        }

        // Check to see if PackagePatchVersion property is set
        internal bool IsSetPackagePatchVersion()
        {
            return this._packagePatchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVersion. 
        /// <para>
        /// The instance's package version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PackageVersion
        {
            get { return this._packageVersion; }
            set { this._packageVersion = value; }
        }

        // Check to see if PackageVersion property is set
        internal bool IsSetPackageVersion()
        {
            return this._packageVersion != null;
        }

    }
}