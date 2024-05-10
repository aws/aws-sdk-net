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
    /// Container for the parameters to the CreateWebExperience operation.
    /// Creates an Amazon Q Business web experience.
    /// </summary>
    public partial class CreateWebExperienceRequest : AmazonQBusinessRequest
    {
        private string _applicationId;
        private string _clientToken;
        private string _roleArn;
        private WebExperienceSamplePromptsControlMode _samplePromptsControlMode;
        private string _subtitle;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _title;
        private string _welcomeMessage;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q Business web experience.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token you provide to identify a request to create an Amazon Q Business web experience.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service role attached to your web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SamplePromptsControlMode. 
        /// <para>
        /// Determines whether sample prompts are enabled in the web experience for an end user.
        /// </para>
        /// </summary>
        public WebExperienceSamplePromptsControlMode SamplePromptsControlMode
        {
            get { return this._samplePromptsControlMode; }
            set { this._samplePromptsControlMode = value; }
        }

        // Check to see if SamplePromptsControlMode property is set
        internal bool IsSetSamplePromptsControlMode()
        {
            return this._samplePromptsControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// A subtitle to personalize your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Subtitle
        {
            get { return this._subtitle; }
            set { this._subtitle = value; }
        }

        // Check to see if Subtitle property is set
        internal bool IsSetSubtitle()
        {
            return this._subtitle != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs that identify or categorize your Amazon Q Business web experience.
        /// You can also use tags to help control access to the web experience. Tag keys and values
        /// can consist of Unicode letters, digits, white space, and any of the following symbols:
        /// _ . : / = + - @.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title for your Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// The customized welcome message for end users of an Amazon Q Business web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=300)]
        public string WelcomeMessage
        {
            get { return this._welcomeMessage; }
            set { this._welcomeMessage = value; }
        }

        // Check to see if WelcomeMessage property is set
        internal bool IsSetWelcomeMessage()
        {
            return this._welcomeMessage != null;
        }

    }
}