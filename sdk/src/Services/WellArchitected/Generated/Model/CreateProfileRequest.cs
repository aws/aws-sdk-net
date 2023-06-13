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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProfile operation.
    /// Create a profile.
    /// </summary>
    public partial class CreateProfileRequest : AmazonWellArchitectedRequest
    {
        private string _clientRequestToken;
        private string _profileDescription;
        private string _profileName;
        private List<ProfileQuestionUpdate> _profileQuestions = new List<ProfileQuestionUpdate>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileDescription. 
        /// <para>
        /// The profile description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
        public string ProfileDescription
        {
            get { return this._profileDescription; }
            set { this._profileDescription = value; }
        }

        // Check to see if ProfileDescription property is set
        internal bool IsSetProfileDescription()
        {
            return this._profileDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// Name of the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=100)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileQuestions. 
        /// <para>
        /// The profile questions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProfileQuestionUpdate> ProfileQuestions
        {
            get { return this._profileQuestions; }
            set { this._profileQuestions = value; }
        }

        // Check to see if ProfileQuestions property is set
        internal bool IsSetProfileQuestions()
        {
            return this._profileQuestions != null && this._profileQuestions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}