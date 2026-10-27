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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Contains summary information about a browser profile. A browser profile stores persistent
    /// browser data that can be reused across browser sessions.
    /// </summary>
    public partial class BrowserProfileSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the browser profile was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastSavedAt. 
        /// <para>
        /// The timestamp when browser session data was last saved to this profile.
        /// </para>
        /// </summary>
        public DateTime? LastSavedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSavedAt property is set.
        /// </summary>
        internal bool IsSetLastSavedAt() => this.LastSavedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastSavedBrowserId. 
        /// <para>
        /// The identifier of the browser from which data was last saved to this profile.
        /// </para>
        /// </summary>
        public string LastSavedBrowserId { get; set; }

        /// <summary>
        /// Checks to see if the LastSavedBrowserId property is set.
        /// </summary>
        internal bool IsSetLastSavedBrowserId() => this.LastSavedBrowserId != null;

        /// <summary>
        /// Gets and sets the property LastSavedBrowserSessionId. 
        /// <para>
        /// The identifier of the browser session from which data was last saved to this profile.
        /// </para>
        /// </summary>
        public string LastSavedBrowserSessionId { get; set; }

        /// <summary>
        /// Checks to see if the LastSavedBrowserSessionId property is set.
        /// </summary>
        internal bool IsSetLastSavedBrowserSessionId() => this.LastSavedBrowserSessionId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the browser profile was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProfileArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the ProfileArn property is set.
        /// </summary>
        internal bool IsSetProfileArn() => this.ProfileArn != null;

        /// <summary>
        /// Gets and sets the property ProfileId. 
        /// <para>
        /// The unique identifier of the browser profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileId property is set.
        /// </summary>
        internal bool IsSetProfileId() => this.ProfileId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the browser profile. Possible values include READY, SAVING,
        /// DELETING, and DELETED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BrowserProfileStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
