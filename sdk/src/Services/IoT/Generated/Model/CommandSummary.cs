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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Summary information about a particular command resource.
    /// </summary>
    public partial class CommandSummary
    {
        private string _commandArn;
        private string _commandId;
        private DateTime? _createdAt;
        private bool? _deprecated;
        private string _displayName;
        private DateTime? _lastUpdatedAt;
        private bool? _pendingDeletion;

        /// <summary>
        /// Gets and sets the property CommandArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the command.
        /// </para>
        /// </summary>
        public string CommandArn
        {
            get { return this._commandArn; }
            set { this._commandArn = value; }
        }

        // Check to see if CommandArn property is set
        internal bool IsSetCommandArn()
        {
            return this._commandArn != null;
        }

        /// <summary>
        /// Gets and sets the property CommandId. 
        /// <para>
        /// The unique identifier of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CommandId
        {
            get { return this._commandId; }
            set { this._commandId = value; }
        }

        // Check to see if CommandId property is set
        internal bool IsSetCommandId()
        {
            return this._commandId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp, when the command was created.
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
        /// Gets and sets the property Deprecated. 
        /// <para>
        /// Indicates whether the command has been deprecated.
        /// </para>
        /// </summary>
        public bool? Deprecated
        {
            get { return this._deprecated; }
            set { this._deprecated = value; }
        }

        // Check to see if Deprecated property is set
        internal bool IsSetDeprecated()
        {
            return this._deprecated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the command.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp, when the command was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingDeletion. 
        /// <para>
        /// Indicates whether the command is pending deletion.
        /// </para>
        /// </summary>
        public bool? PendingDeletion
        {
            get { return this._pendingDeletion; }
            set { this._pendingDeletion = value; }
        }

        // Check to see if PendingDeletion property is set
        internal bool IsSetPendingDeletion()
        {
            return this._pendingDeletion.HasValue; 
        }

    }
}