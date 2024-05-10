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
 * Do not modify this file. This file is generated from the codestar-connections-2019-12-01.normal.json service model.
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
namespace Amazon.CodeStarconnections.Model
{
    /// <summary>
    /// This is the response object from the UpdateSyncBlocker operation.
    /// </summary>
    public partial class UpdateSyncBlockerResponse : AmazonWebServiceResponse
    {
        private string _parentResourceName;
        private string _resourceName;
        private SyncBlocker _syncBlocker;

        /// <summary>
        /// Gets and sets the property ParentResourceName. 
        /// <para>
        /// The parent resource name for the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ParentResourceName
        {
            get { return this._parentResourceName; }
            set { this._parentResourceName = value; }
        }

        // Check to see if ParentResourceName property is set
        internal bool IsSetParentResourceName()
        {
            return this._parentResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The resource name for the sync blocker.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SyncBlocker. 
        /// <para>
        /// Information about the sync blocker to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SyncBlocker SyncBlocker
        {
            get { return this._syncBlocker; }
            set { this._syncBlocker = value; }
        }

        // Check to see if SyncBlocker property is set
        internal bool IsSetSyncBlocker()
        {
            return this._syncBlocker != null;
        }

    }
}