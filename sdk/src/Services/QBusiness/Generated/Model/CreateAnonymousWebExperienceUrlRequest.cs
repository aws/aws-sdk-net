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
    /// Container for the parameters to the CreateAnonymousWebExperienceUrl operation.
    /// Creates a unique URL for anonymous Amazon Q Business web experience. This URL can
    /// only be used once and must be used within 5 minutes after it's generated.
    /// </summary>
    public partial class CreateAnonymousWebExperienceUrlRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private int? _sessionDurationInMinutes;
        private string _webExperienceId;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business application environment attached to the web
        /// experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property SessionDurationInMinutes. 
        /// <para>
        /// The duration of the session associated with the unique URL for the web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=60)]
        public int? SessionDurationInMinutes
        {
            get { return this._sessionDurationInMinutes; }
            set { this._sessionDurationInMinutes = value; }
        }

        // Check to see if SessionDurationInMinutes property is set
        internal bool IsSetSessionDurationInMinutes()
        {
            return this._sessionDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of the web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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