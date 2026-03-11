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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSessionLogger operation.
    /// Updates the details of a session logger.
    /// </summary>
    public partial class UpdateSessionLoggerRequest : AmazonWorkSpacesWebRequest
    {
        private string _displayName;
        private EventFilter _eventFilter;
        private LogConfiguration _logConfiguration;
        private string _sessionLoggerArn;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The updated display name.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property EventFilter. 
        /// <para>
        /// The updated eventFilter.
        /// </para>
        /// </summary>
        public EventFilter EventFilter
        {
            get { return this._eventFilter; }
            set { this._eventFilter = value; }
        }

        // Check to see if EventFilter property is set
        internal bool IsSetEventFilter()
        {
            return this._eventFilter != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The updated logConfiguration.
        /// </para>
        /// </summary>
        public LogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SessionLoggerArn. 
        /// <para>
        /// The ARN of the session logger to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SessionLoggerArn
        {
            get { return this._sessionLoggerArn; }
            set { this._sessionLoggerArn = value; }
        }

        // Check to see if SessionLoggerArn property is set
        internal bool IsSetSessionLoggerArn()
        {
            return this._sessionLoggerArn != null;
        }

    }
}