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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSnapshots operation.
    /// Creates crash-consistent snapshots of multiple EBS volumes and stores the data in
    /// S3. Volumes are chosen by specifying an instance. Any attached volumes will produce
    /// one snapshot each that is crash-consistent across the instance. Boot volumes can be
    /// excluded by changing the paramaters.
    /// </summary>
    public partial class CreateSnapshotsRequest : AmazonEC2Request
    {
        private CopyTagsFromSource _copyTagsFromSource;
        private string _description;
        private InstanceSpecification _instanceSpecification;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property CopyTagsFromSource. 
        /// <para>
        /// Copies the tags from the specified volume to corresponding snapshot.
        /// </para>
        /// </summary>
        public CopyTagsFromSource CopyTagsFromSource
        {
            get { return this._copyTagsFromSource; }
            set { this._copyTagsFromSource = value; }
        }

        // Check to see if CopyTagsFromSource property is set
        internal bool IsSetCopyTagsFromSource()
        {
            return this._copyTagsFromSource != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description propagated to every snapshot specified by the instance.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InstanceSpecification. 
        /// <para>
        /// The instance to specify which volumes should be included in the snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceSpecification InstanceSpecification
        {
            get { return this._instanceSpecification; }
            set { this._instanceSpecification = value; }
        }

        // Check to see if InstanceSpecification property is set
        internal bool IsSetInstanceSpecification()
        {
            return this._instanceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// Tags to apply to every snapshot specified by the instance.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}