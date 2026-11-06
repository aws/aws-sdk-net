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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Specifies information about the replication destination bucket and its settings for
    /// an S3 on Outposts replication configuration.
    /// </summary>
    public partial class Destination
    {
        /// <summary>
        /// Gets and sets the property AccessControlTranslation. 
        /// <para>
        /// Specify this property only in a cross-account scenario (where the source and destination
        /// bucket owners are not the same), and you want to change replica ownership to the Amazon
        /// Web Services account that owns the destination bucket. If this property is not specified
        /// in the replication configuration, the replicas are owned by same Amazon Web Services
        /// account that owns the source object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessControlTranslation AccessControlTranslation { get; set; }

        /// <summary>
        /// Checks to see if the AccessControlTranslation property is set.
        /// </summary>
        internal bool IsSetAccessControlTranslation() => this.AccessControlTranslation != null;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The destination bucket owner's account ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Account { get; set; }

        /// <summary>
        /// Checks to see if the Account property is set.
        /// </summary>
        internal bool IsSetAccount() => this.Account != null;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the access point for the destination bucket where
        /// you want S3 on Outposts to store the replication results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// A container that provides information about encryption. If <c>SourceSelectionCriteria</c>
        /// is specified, you must specify this element.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        ///  A container that specifies replication metrics-related settings. 
        /// </para>
        /// </summary>
        public Metrics Metrics { get; set; }

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null;

        /// <summary>
        /// Gets and sets the property ReplicationTime. 
        /// <para>
        /// A container that specifies S3 Replication Time Control (S3 RTC) settings, including
        /// whether S3 RTC is enabled and the time when all objects and operations on objects
        /// must be replicated. Must be specified together with a <c>Metrics</c> block. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is not supported by Amazon S3 on Outposts buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationTime ReplicationTime { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTime property is set.
        /// </summary>
        internal bool IsSetReplicationTime() => this.ReplicationTime != null;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        ///  The storage class to use when replicating objects. All objects stored on S3 on Outposts
        /// are stored in the <c>OUTPOSTS</c> storage class. S3 on Outposts uses the <c>OUTPOSTS</c>
        /// storage class to create the object replicas. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Values other than <c>OUTPOSTS</c> aren't supported by Amazon S3 on Outposts. 
        /// </para>
        ///  </note>
        /// </summary>
        public ReplicationStorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
