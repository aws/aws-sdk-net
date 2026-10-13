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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

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
        public S3AccessPointAttachmentLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason.
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the S3 access point attachment; also used for the name of the S3 access
        /// point.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 50)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OntapConfiguration. 
        /// <para>
        /// The ONTAP configuration of the S3 access point attachment.
        /// </para>
        /// </summary>
        public S3AccessPointOntapConfiguration OntapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OntapConfiguration property is set.
        /// </summary>
        internal bool IsSetOntapConfiguration() => this.OntapConfiguration != null;

        /// <summary>
        /// Gets and sets the property OpenZFSConfiguration. 
        /// <para>
        /// The OpenZFSConfiguration of the S3 access point attachment.
        /// </para>
        /// </summary>
        public S3AccessPointOpenZFSConfiguration OpenZFSConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OpenZFSConfiguration property is set.
        /// </summary>
        internal bool IsSetOpenZFSConfiguration() => this.OpenZFSConfiguration != null;

        /// <summary>
        /// Gets and sets the property S3AccessPoint. 
        /// <para>
        /// The S3 access point configuration of the S3 access point attachment.
        /// </para>
        /// </summary>
        public S3AccessPoint S3AccessPoint { get; set; }

        /// <summary>
        /// Checks to see if the S3AccessPoint property is set.
        /// </summary>
        internal bool IsSetS3AccessPoint() => this.S3AccessPoint != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of Amazon FSx volume that the S3 access point is attached to. 
        /// </para>
        /// </summary>
        public S3AccessPointAttachmentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
