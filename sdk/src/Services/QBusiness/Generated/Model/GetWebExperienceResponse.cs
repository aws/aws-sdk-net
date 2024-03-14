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

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetWebExperience operation.
    /// </summary>
    public partial class GetWebExperienceResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private WebExperienceAuthConfiguration _authenticationConfiguration;
        private DateTime? _createdAt;
        private string _defaultEndpoint;
        private ErrorDetail _error;
        private WebExperienceSamplePromptsControlMode _samplePromptsControlMode;
        private WebExperienceStatus _status;
        private string _subtitle;
        private string _title;
        private DateTime? _updatedAt;
        private string _webExperienceArn;
        private string _webExperienceId;
        private string _welcomeMessage;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the Amazon Q application linked to the web experience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property AuthenticationConfiguration. 
        /// <para>
        /// The authentication configuration information for your Amazon Q web experience.
        /// </para>
        /// </summary>
        public WebExperienceAuthConfiguration AuthenticationConfiguration
        {
            get { return this._authenticationConfiguration; }
            set { this._authenticationConfiguration = value; }
        }

        // Check to see if AuthenticationConfiguration property is set
        internal bool IsSetAuthenticationConfiguration()
        {
            return this._authenticationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp when the retriever was created.
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
        /// The endpoint of your Amazon Q web experience.
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
        /// Gets and sets the property Error. 
        /// <para>
        /// When the <c>Status</c> field value is <c>FAILED</c>, the <c>ErrorMessage</c> field
        /// contains a description of the error that caused the data source connector to fail.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Amazon Q web experience. When the <c>Status</c> field value
        /// is <c>FAILED</c>, the <c>ErrorMessage</c> field contains a description of the error
        /// that caused the data source connector to fail. 
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
        /// Gets and sets the property Subtitle. 
        /// <para>
        /// The subtitle for your Amazon Q web experience. 
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
        /// Gets and sets the property Title. 
        /// <para>
        /// The title for your Amazon Q web experience. 
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the data source connector was last updated.
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
        /// Gets and sets the property WebExperienceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with the permission to access the Amazon
        /// Q web experience and required resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string WebExperienceArn
        {
            get { return this._webExperienceArn; }
            set { this._webExperienceArn = value; }
        }

        // Check to see if WebExperienceArn property is set
        internal bool IsSetWebExperienceArn()
        {
            return this._webExperienceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebExperienceId. 
        /// <para>
        /// The identifier of the Amazon Q web experience.
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

        /// <summary>
        /// Gets and sets the property WelcomeMessage. 
        /// <para>
        /// The customized welcome message for end users of an Amazon Q web experience.
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