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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a stack.
    /// </summary>
    public partial class Stack
    {
        private List<AccessEndpoint> _accessEndpoints = AWSConfigs.InitializeCollections ? new List<AccessEndpoint>() : null;
        private ApplicationSettingsResponse _applicationSettings;
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private List<string> _embedHostDomains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _feedbackURL;
        private string _name;
        private string _redirectURL;
        private List<StackError> _stackErrors = AWSConfigs.InitializeCollections ? new List<StackError>() : null;
        private List<StorageConnector> _storageConnectors = AWSConfigs.InitializeCollections ? new List<StorageConnector>() : null;
        private StreamingExperienceSettings _streamingExperienceSettings;
        private List<UserSetting> _userSettings = AWSConfigs.InitializeCollections ? new List<UserSetting>() : null;

        /// <summary>
        /// Gets and sets the property AccessEndpoints. 
        /// <para>
        /// The list of virtual private cloud (VPC) interface endpoint objects. Users of the stack
        /// can connect to AppStream 2.0 only through the specified endpoints. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<AccessEndpoint> AccessEndpoints
        {
            get { return this._accessEndpoints; }
            set { this._accessEndpoints = value; }
        }

        // Check to see if AccessEndpoints property is set
        internal bool IsSetAccessEndpoints()
        {
            return this._accessEndpoints != null && (this._accessEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationSettings. 
        /// <para>
        /// The persistent application settings for users of the stack.
        /// </para>
        /// </summary>
        public ApplicationSettingsResponse ApplicationSettings
        {
            get { return this._applicationSettings; }
            set { this._applicationSettings = value; }
        }

        // Check to see if ApplicationSettings property is set
        internal bool IsSetApplicationSettings()
        {
            return this._applicationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the stack.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the stack was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The stack name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property EmbedHostDomains. 
        /// <para>
        /// The domains where AppStream 2.0 streaming sessions can be embedded in an iframe. You
        /// must approve the domains that you want to host embedded AppStream 2.0 streaming sessions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> EmbedHostDomains
        {
            get { return this._embedHostDomains; }
            set { this._embedHostDomains = value; }
        }

        // Check to see if EmbedHostDomains property is set
        internal bool IsSetEmbedHostDomains()
        {
            return this._embedHostDomains != null && (this._embedHostDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeedbackURL. 
        /// <para>
        /// The URL that users are redirected to after they click the Send Feedback link. If no
        /// URL is specified, no Send Feedback link is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string FeedbackURL
        {
            get { return this._feedbackURL; }
            set { this._feedbackURL = value; }
        }

        // Check to see if FeedbackURL property is set
        internal bool IsSetFeedbackURL()
        {
            return this._feedbackURL != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stack.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectURL. 
        /// <para>
        /// The URL that users are redirected to after their streaming session ends.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string RedirectURL
        {
            get { return this._redirectURL; }
            set { this._redirectURL = value; }
        }

        // Check to see if RedirectURL property is set
        internal bool IsSetRedirectURL()
        {
            return this._redirectURL != null;
        }

        /// <summary>
        /// Gets and sets the property StackErrors. 
        /// <para>
        /// The errors for the stack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StackError> StackErrors
        {
            get { return this._stackErrors; }
            set { this._stackErrors = value; }
        }

        // Check to see if StackErrors property is set
        internal bool IsSetStackErrors()
        {
            return this._stackErrors != null && (this._stackErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// The storage connectors to enable.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageConnector> StorageConnectors
        {
            get { return this._storageConnectors; }
            set { this._storageConnectors = value; }
        }

        // Check to see if StorageConnectors property is set
        internal bool IsSetStorageConnectors()
        {
            return this._storageConnectors != null && (this._storageConnectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StreamingExperienceSettings. 
        /// <para>
        /// The streaming protocol you want your stack to prefer. This can be UDP or TCP. Currently,
        /// UDP is only supported in the Windows native client.
        /// </para>
        /// </summary>
        public StreamingExperienceSettings StreamingExperienceSettings
        {
            get { return this._streamingExperienceSettings; }
            set { this._streamingExperienceSettings = value; }
        }

        // Check to see if StreamingExperienceSettings property is set
        internal bool IsSetStreamingExperienceSettings()
        {
            return this._streamingExperienceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// The actions that are enabled or disabled for users during their streaming sessions.
        /// By default these actions are enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<UserSetting> UserSettings
        {
            get { return this._userSettings; }
            set { this._userSettings = value; }
        }

        // Check to see if UserSettings property is set
        internal bool IsSetUserSettings()
        {
            return this._userSettings != null && (this._userSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}