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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information for an Amazon Q Business web experience.
    /// </summary>
    public partial class WebExperience
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultEndpoint. 
        /// <para>
        /// The endpoint URLs for your Amazon Q Business web experience. The URLs are unique and
        /// fully hosted by Amazon Web Services.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string DefaultEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DefaultEndpoint property is set.
        /// </summary>
        internal bool IsSetDefaultEndpoint() => this.DefaultEndpoint != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        public WebExperienceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when your Amazon Q Business web experience was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WebExperienceId { get; set; }

        /// <summary>
        /// Checks to see if the WebExperienceId property is set.
        /// </summary>
        internal bool IsSetWebExperienceId() => this.WebExperienceId != null;
    }
}
