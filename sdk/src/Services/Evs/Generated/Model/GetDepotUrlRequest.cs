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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// Container for the parameters to the GetDepotUrl operation.
    /// Returns a URL and authentication token for accessing the Amazon EVS Custom Addon depot.
    /// Configure the depot URL as a download source in vSphere Lifecycle Manager (vLCM) to
    /// sync and install the Amazon EVS Custom Addon.
    /// 
    ///  
    /// <para>
    /// The depot URL remains active until you rotate the authentication token by calling
    /// this action with <c>rotate</c> set to <c>true</c>.
    /// </para>
    /// </summary>
    public partial class GetDepotUrlRequest : AmazonEvsRequest
    {
        private string _environmentId;
        private bool? _rotate;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique ID of the Amazon EVS environment to get the depot URL for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property Rotate. 
        /// <para>
        /// Revokes the current authentication token and returns a new depot URL with a new token.
        /// Previously issued depot URLs will stop working within 5 minutes of rotation.
        /// </para>
        /// </summary>
        public bool? Rotate
        {
            get { return this._rotate; }
            set { this._rotate = value; }
        }

        // Check to see if Rotate property is set
        internal bool IsSetRotate()
        {
            return this._rotate.HasValue; 
        }

    }
}