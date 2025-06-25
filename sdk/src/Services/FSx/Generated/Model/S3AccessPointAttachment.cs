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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// An S3 access point attached to an Amazon FSx volume.
    /// </summary>
    public partial class S3AccessPointAttachment
    {
        private DateTime? _creationTime;
        private S3AccessPointAttachmentLifecycle _lifecycle;
        private LifecycleTransitionReason _lifecycleTransitionReason;
        private string _name;
        private S3AccessPointOpenZFSConfiguration _openZFSConfiguration;
        private S3AccessPoint _s3AccessPoint;
        private S3AccessPointAttachmentType _type;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the S3 access point attachment. The lifecycle can have the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AVAILABLE - the S3 access point attachment is available for use
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATING - Amazon FSx is creating the S3 access point and attachment
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING - Amazon FSx is deleting the S3 access point and attachment
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The S3 access point attachment is in a failed state. Delete and detach the
        /// S3 access point attachment, and create a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING - Amazon FSx is updating the S3 access point attachment
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public S3AccessPointAttachmentLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason.
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason
        {
            get { return this._lifecycleTransitionReason; }
            set { this._lifecycleTransitionReason = value; }
        }

        // Check to see if LifecycleTransitionReason property is set
        internal bool IsSetLifecycleTransitionReason()
        {
            return this._lifecycleTransitionReason != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the S3 access point attachment; also used for the name of the S3 access
        /// point.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=50)]
        public string Name
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
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The OpenZFSConfiguration of the S3 access point attachment.
        /// </para>
        /// </summary>
        public S3AccessPointOpenZFSConfiguration OpenZFSConfiguration
        {
            get { return this._openZFSConfiguration; }
            set { this._openZFSConfiguration = value; }
        }

        // Check to see if OpenZFSConfiguration property is set
        internal bool IsSetOpenZFSConfiguration()
        {
            return this._openZFSConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property S3AccessPoint. 
        /// <para>
        /// The S3 access point configuration of the S3 access point attachment.
        /// </para>
        /// </summary>
        public S3AccessPoint S3AccessPoint
        {
            get { return this._s3AccessPoint; }
            set { this._s3AccessPoint = value; }
        }

        // Check to see if S3AccessPoint property is set
        internal bool IsSetS3AccessPoint()
        {
            return this._s3AccessPoint != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Amazon FSx volume that the S3 access point is attached to. 
        /// </para>
        /// </summary>
        public S3AccessPointAttachmentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}