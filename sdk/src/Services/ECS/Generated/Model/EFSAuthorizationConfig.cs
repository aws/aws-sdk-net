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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The authorization configuration details for the Amazon EFS file system.
    /// </summary>
    public partial class EFSAuthorizationConfig
    {
        private string _accessPointId;
        private EFSAuthorizationConfigIAM _iam;

        /// <summary>
        /// Gets and sets the property AccessPointId. 
        /// <para>
        /// The Amazon EFS access point ID to use. If an access point is specified, the root directory
        /// value specified in the <c>EFSVolumeConfiguration</c> must either be omitted or set
        /// to <c>/</c> which will enforce the path set on the EFS access point. If an access
        /// point is used, transit encryption must be on in the <c>EFSVolumeConfiguration</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/efs-access-points.html">Working
        /// with Amazon EFS access points</a> in the <i>Amazon Elastic File System User Guide</i>.
        /// </para>
        /// </summary>
        public string AccessPointId
        {
            get { return this._accessPointId; }
            set { this._accessPointId = value; }
        }

        // Check to see if AccessPointId property is set
        internal bool IsSetAccessPointId()
        {
            return this._accessPointId != null;
        }

        /// <summary>
        /// Gets and sets the property Iam. 
        /// <para>
        /// Determines whether to use the Amazon ECS task role defined in a task definition when
        /// mounting the Amazon EFS file system. If it is turned on, transit encryption must be
        /// turned on in the <c>EFSVolumeConfiguration</c>. If this parameter is omitted, the
        /// default value of <c>DISABLED</c> is used. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/efs-volumes.html#efs-volume-accesspoints">Using
        /// Amazon EFS access points</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public EFSAuthorizationConfigIAM Iam
        {
            get { return this._iam; }
            set { this._iam = value; }
        }

        // Check to see if Iam property is set
        internal bool IsSetIam()
        {
            return this._iam != null;
        }

    }
}