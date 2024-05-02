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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information for an Amazon Q Business web experience.
    /// </summary>
    public partial class WebExperience
    {
        private DateTime? _createdAt;
        private string _defaultEndpoint;
        private WebExperienceStatus _status;
        private DateTime? _updatedAt;
        private string _webExperienceId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultEndpoint. 
        /// <para>
        /// The endpoint URLs for your Amazon Q Business web experience. The URLs are unique and
        /// fully hosted by Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DefaultEndpoint
        {
            get { return this._defaultEndpoint; }
            set { this._defaultEndpoint = value; }
        }

        // Check to see if DefaultEndpoint property is set
        internal bool IsSetDefaultEndpoint()
        {
            return this._defaultEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        public WebExperienceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when your Amazon Q Business web experience was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string WebExperienceId
        {
            get { return this._webExperienceId; }
            set { this._webExperienceId = value; }
        }

        // Check to see if WebExperienceId property is set
        internal bool IsSetWebExperienceId()
        {
            return this._webExperienceId != null;
        }

    }
}