/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a stack.
    /// </summary>
    public partial class Stack
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _displayName;
        private string _feedbackURL;
        private string _name;
        private string _redirectURL;
        private List<StackError> _stackErrors = new List<StackError>();
        private List<StorageConnector> _storageConnectors = new List<StorageConnector>();
        private List<UserSetting> _userSettings = new List<UserSetting>();

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
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// The description for display.
        /// </para>
        /// </summary>
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
        /// The stack name for display.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FeedbackURL. 
        /// <para>
        /// The URL that users are redirected to after they click the Send Feedback link. If no
        /// URL is specified, no Send Feedback link is displayed.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<StackError> StackErrors
        {
            get { return this._stackErrors; }
            set { this._stackErrors = value; }
        }

        // Check to see if StackErrors property is set
        internal bool IsSetStackErrors()
        {
            return this._stackErrors != null && this._stackErrors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// The storage connectors to enable.
        /// </para>
        /// </summary>
        public List<StorageConnector> StorageConnectors
        {
            get { return this._storageConnectors; }
            set { this._storageConnectors = value; }
        }

        // Check to see if StorageConnectors property is set
        internal bool IsSetStorageConnectors()
        {
            return this._storageConnectors != null && this._storageConnectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserSettings. 
        /// <para>
        /// The actions that are enabled or disabled for users during their streaming sessions.
        /// By default these actions are enabled.
        /// </para>
        /// </summary>
        public List<UserSetting> UserSettings
        {
            get { return this._userSettings; }
            set { this._userSettings = value; }
        }

        // Check to see if UserSettings property is set
        internal bool IsSetUserSettings()
        {
            return this._userSettings != null && this._userSettings.Count > 0; 
        }

    }
}