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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an on-premises instance.
    /// </summary>
    public partial class InstanceInfo
    {
        private DateTime? _deregisterTime;
        private string _iamSessionArn;
        private string _iamUserArn;
        private string _instanceArn;
        private string _instanceName;
        private DateTime? _registerTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DeregisterTime. 
        /// <para>
        /// If the on-premises instance was deregistered, the time at which the on-premises instance
        /// was deregistered.
        /// </para>
        /// </summary>
        public DateTime? DeregisterTime
        {
            get { return this._deregisterTime; }
            set { this._deregisterTime = value; }
        }

        // Check to see if DeregisterTime property is set
        internal bool IsSetDeregisterTime()
        {
            return this._deregisterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamSessionArn. 
        /// <para>
        /// The ARN of the IAM session associated with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamSessionArn
        {
            get { return this._iamSessionArn; }
            set { this._iamSessionArn = value; }
        }

        // Check to see if IamSessionArn property is set
        internal bool IsSetIamSessionArn()
        {
            return this._iamSessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The user ARN associated with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamUserArn
        {
            get { return this._iamUserArn; }
            set { this._iamUserArn = value; }
        }

        // Check to see if IamUserArn property is set
        internal bool IsSetIamUserArn()
        {
            return this._iamUserArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the on-premises instance.
        /// </para>
        /// </summary>
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the on-premises instance.
        /// </para>
        /// </summary>
        public string InstanceName
        {
            get { return this._instanceName; }
            set { this._instanceName = value; }
        }

        // Check to see if InstanceName property is set
        internal bool IsSetInstanceName()
        {
            return this._instanceName != null;
        }

        /// <summary>
        /// Gets and sets the property RegisterTime. 
        /// <para>
        /// The time at which the on-premises instance was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisterTime
        {
            get { return this._registerTime; }
            set { this._registerTime = value; }
        }

        // Check to see if RegisterTime property is set
        internal bool IsSetRegisterTime()
        {
            return this._registerTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags currently associated with the on-premises instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

    }
}