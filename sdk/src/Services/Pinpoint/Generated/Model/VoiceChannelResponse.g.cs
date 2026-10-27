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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the status and settings of the voice channel for an application.
    /// </summary>
    public partial class VoiceChannelResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that the voice channel applies to.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the voice channel was enabled.
        /// </para>
        /// </summary>
        public string CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the voice channel is enabled for the application.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property HasCredential. 
        /// <para>
        /// (Not used) This property is retained only for backward compatibility.
        /// </para>
        /// </summary>
        public bool? HasCredential { get; set; }

        /// <summary>
        /// Checks to see if the HasCredential property is set.
        /// </summary>
        internal bool IsSetHasCredential() => this.HasCredential.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// (Deprecated) An identifier for the voice channel. This property is retained only for
        /// backward compatibility.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsArchived. 
        /// <para>
        /// Specifies whether the voice channel is archived.
        /// </para>
        /// </summary>
        public bool? IsArchived { get; set; }

        /// <summary>
        /// Checks to see if the IsArchived property is set.
        /// </summary>
        internal bool IsSetIsArchived() => this.IsArchived.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// The user who last modified the voice channel.
        /// </para>
        /// </summary>
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the voice channel was last modified.
        /// </para>
        /// </summary>
        public string LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The type of messaging or notification platform for the channel. For the voice channel,
        /// this value is VOICE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The current version of the voice channel.
        /// </para>
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
