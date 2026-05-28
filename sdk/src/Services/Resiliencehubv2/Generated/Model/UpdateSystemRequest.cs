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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSystem operation.
    /// Updates an existing system.
    /// </summary>
    public partial class UpdateSystemRequest : AmazonResiliencehubv2Request
    {
        private string _description;
        private bool? _sharingEnabled;
        private string _systemArn;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property SharingEnabled. 
        /// <para>
        /// Whether cross-account sharing is enabled for the system.
        /// </para>
        /// </summary>
        public bool? SharingEnabled
        {
            get { return this._sharingEnabled; }
            set { this._sharingEnabled = value; }
        }

        // Check to see if SharingEnabled property is set
        internal bool IsSetSharingEnabled()
        {
            return this._sharingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SystemArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string SystemArn
        {
            get { return this._systemArn; }
            set { this._systemArn = value; }
        }

        // Check to see if SystemArn property is set
        internal bool IsSetSystemArn()
        {
            return this._systemArn != null;
        }

    }
}