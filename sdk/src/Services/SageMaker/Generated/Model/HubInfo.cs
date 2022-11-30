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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Information about a hub.
    /// </summary>
    public partial class HubInfo
    {
        private DateTime? _creationTime;
        private string _hubArn;
        private string _hubDescription;
        private string _hubDisplayName;
        private string _hubName;
        private List<string> _hubSearchKeywords = new List<string>();
        private HubStatus _hubStatus;
        private DateTime? _lastModifiedTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the hub was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string HubArn
        {
            get { return this._hubArn; }
            set { this._hubArn = value; }
        }

        // Check to see if HubArn property is set
        internal bool IsSetHubArn()
        {
            return this._hubArn != null;
        }

        /// <summary>
        /// Gets and sets the property HubDescription. 
        /// <para>
        /// A description of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1023)]
        public string HubDescription
        {
            get { return this._hubDescription; }
            set { this._hubDescription = value; }
        }

        // Check to see if HubDescription property is set
        internal bool IsSetHubDescription()
        {
            return this._hubDescription != null;
        }

        /// <summary>
        /// Gets and sets the property HubDisplayName. 
        /// <para>
        /// The display name of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string HubDisplayName
        {
            get { return this._hubDisplayName; }
            set { this._hubDisplayName = value; }
        }

        // Check to see if HubDisplayName property is set
        internal bool IsSetHubDisplayName()
        {
            return this._hubDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string HubName
        {
            get { return this._hubName; }
            set { this._hubName = value; }
        }

        // Check to see if HubName property is set
        internal bool IsSetHubName()
        {
            return this._hubName != null;
        }

        /// <summary>
        /// Gets and sets the property HubSearchKeywords. 
        /// <para>
        /// The searchable keywords for the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> HubSearchKeywords
        {
            get { return this._hubSearchKeywords; }
            set { this._hubSearchKeywords = value; }
        }

        // Check to see if HubSearchKeywords property is set
        internal bool IsSetHubSearchKeywords()
        {
            return this._hubSearchKeywords != null && this._hubSearchKeywords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HubStatus. 
        /// <para>
        /// The status of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HubStatus HubStatus
        {
            get { return this._hubStatus; }
            set { this._hubStatus = value; }
        }

        // Check to see if HubStatus property is set
        internal bool IsSetHubStatus()
        {
            return this._hubStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the hub was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

    }
}