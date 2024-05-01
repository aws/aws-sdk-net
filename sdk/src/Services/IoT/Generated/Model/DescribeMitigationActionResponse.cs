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
    /// This is the response object from the DescribeMitigationAction operation.
    /// </summary>
    public partial class DescribeMitigationActionResponse : AmazonWebServiceResponse
    {
        private string _actionArn;
        private string _actionId;
        private string _actionName;
        private MitigationActionParams _actionParams;
        private MitigationActionType _actionType;
        private DateTime? _creationDate;
        private DateTime? _lastModifiedDate;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ActionArn. 
        /// <para>
        /// The ARN that identifies this migration action.
        /// </para>
        /// </summary>
        public string ActionArn
        {
            get { return this._actionArn; }
            set { this._actionArn = value; }
        }

        // Check to see if ActionArn property is set
        internal bool IsSetActionArn()
        {
            return this._actionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// A unique identifier for this action.
        /// </para>
        /// </summary>
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The friendly name that uniquely identifies the mitigation action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ActionParams. 
        /// <para>
        /// Parameters that control how the mitigation action is applied, specific to the type
        /// of mitigation action.
        /// </para>
        /// </summary>
        public MitigationActionParams ActionParams
        {
            get { return this._actionParams; }
            set { this._actionParams = value; }
        }

        // Check to see if ActionParams property is set
        internal bool IsSetActionParams()
        {
            return this._actionParams != null;
        }

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of mitigation action.
        /// </para>
        /// </summary>
        public MitigationActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the mitigation action was added to your Amazon Web Services
        /// accounts.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the mitigation action was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role used to apply this action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

    }
}