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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Holds persistent application user interface information. Applications installed on
    /// the Amazon EMR cluster publish user interfaces as web sites to monitor cluster activity.
    /// </summary>
    public partial class PersistentAppUI
    {
        /// <summary>
        /// Gets and sets the property AuthorId. 
        /// <para>
        /// The author ID for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AuthorId { get; set; }

        /// <summary>
        /// Checks to see if the AuthorId property is set.
        /// </summary>
        internal bool IsSetAuthorId() => this.AuthorId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation date and time for the persistent application user interface object.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time the persistent application user interface object was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStateChangeReason. 
        /// <para>
        /// The reason the persistent application user interface object was last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string LastStateChangeReason { get; set; }

        /// <summary>
        /// Checks to see if the LastStateChangeReason property is set.
        /// </summary>
        internal bool IsSetLastStateChangeReason() => this.LastStateChangeReason != null;

        /// <summary>
        /// Gets and sets the property PersistentAppUIId. 
        /// <para>
        /// The identifier for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PersistentAppUIId { get; set; }

        /// <summary>
        /// Checks to see if the PersistentAppUIId property is set.
        /// </summary>
        internal bool IsSetPersistentAppUIId() => this.PersistentAppUIId != null;

        /// <summary>
        /// Gets and sets the property PersistentAppUIStatus. 
        /// <para>
        /// The status for the persistent application user interface object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PersistentAppUIStatus { get; set; }

        /// <summary>
        /// Checks to see if the PersistentAppUIStatus property is set.
        /// </summary>
        internal bool IsSetPersistentAppUIStatus() => this.PersistentAppUIStatus != null;

        /// <summary>
        /// Gets and sets the property PersistentAppUITypeList. 
        /// <para>
        /// The type list for the persistent application user interface object. Valid values include
        /// SHS, YTS, or TEZ.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PersistentAppUITypeList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PersistentAppUITypeList property is set.
        /// </summary>
        internal bool IsSetPersistentAppUITypeList() => this.PersistentAppUITypeList != null && (this.PersistentAppUITypeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags for the persistent application user interface object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
