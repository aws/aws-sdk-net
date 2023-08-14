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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// The details of a share.
    /// </summary>
    public partial class ShareDetails
    {
        private DateTime? _creationTime;
        private string _ownerId;
        private string _principalSubscriber;
        private string _resourceArn;
        private string _shareId;
        private string _shareName;
        private ShareStatus _status;
        private string _statusMessage;
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The timestamp for when the share was created. 
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        ///  The account ID for the data owner. The owner creates the share offer. 
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalSubscriber. 
        /// <para>
        ///  The principal subscriber is the account the analytics store data is being shared
        /// with. 
        /// </para>
        /// </summary>
        public string PrincipalSubscriber
        {
            get { return this._principalSubscriber; }
            set { this._principalSubscriber = value; }
        }

        // Check to see if PrincipalSubscriber property is set
        internal bool IsSetPrincipalSubscriber()
        {
            return this._principalSubscriber != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        ///  The resource Arn of the analytics store being shared. 
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ShareId. 
        /// <para>
        ///  The ID for a share offer for an analytics store . 
        /// </para>
        /// </summary>
        public string ShareId
        {
            get { return this._shareId; }
            set { this._shareId = value; }
        }

        // Check to see if ShareId property is set
        internal bool IsSetShareId()
        {
            return this._shareId != null;
        }

        /// <summary>
        /// Gets and sets the property ShareName. 
        /// <para>
        ///  The name of the share. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ShareName
        {
            get { return this._shareName; }
            set { this._shareName = value; }
        }

        // Check to see if ShareName property is set
        internal bool IsSetShareName()
        {
            return this._shareName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of a share. 
        /// </para>
        /// </summary>
        public ShareStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  The status message for a share. It provides more details on the status of the share.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        ///  The timestamp of the share update. 
        /// </para>
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}