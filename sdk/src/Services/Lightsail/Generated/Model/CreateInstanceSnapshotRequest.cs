/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceSnapshot operation.
    /// Creates a snapshot of a specific virtual private server, or <i>instance</i>. You can
    /// use a snapshot to create a new instance that is based on that snapshot.
    /// 
    ///  
    /// <para>
    /// The <code>create instance snapshot</code> operation supports tag-based access control
    /// via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateInstanceSnapshotRequest : AmazonLightsailRequest
    {
        private string _instanceName;
        private string _instanceSnapshotName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The Lightsail instance on which to base your snapshot.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceSnapshotName. 
        /// <para>
        /// The name for your new snapshot.
        /// </para>
        /// </summary>
        public string InstanceSnapshotName
        {
            get { return this._instanceSnapshotName; }
            set { this._instanceSnapshotName = value; }
        }

        // Check to see if InstanceSnapshotName property is set
        internal bool IsSetInstanceSnapshotName()
        {
            return this._instanceSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// To tag a resource after it has been created, see the <code>tag resource</code> operation.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}