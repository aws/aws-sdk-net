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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property DeregisterTime. 
        /// <para>
        /// If the on-premises instance was deregistered, the time at which the on-premises instance
        /// was deregistered.
        /// </para>
        /// </summary>
        public DateTime? DeregisterTime { get; set; }

        /// <summary>
        /// Checks to see if the DeregisterTime property is set.
        /// </summary>
        internal bool IsSetDeregisterTime() => this.DeregisterTime.HasValue;

        /// <summary>
        /// Gets and sets the property IamSessionArn. 
        /// <para>
        /// The ARN of the IAM session associated with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the IamSessionArn property is set.
        /// </summary>
        internal bool IsSetIamSessionArn() => this.IamSessionArn != null;

        /// <summary>
        /// Gets and sets the property IamUserArn. 
        /// <para>
        /// The user ARN associated with the on-premises instance.
        /// </para>
        /// </summary>
        public string IamUserArn { get; set; }

        /// <summary>
        /// Checks to see if the IamUserArn property is set.
        /// </summary>
        internal bool IsSetIamUserArn() => this.IamUserArn != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the on-premises instance.
        /// </para>
        /// </summary>
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property InstanceName. 
        /// <para>
        /// The name of the on-premises instance.
        /// </para>
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceName property is set.
        /// </summary>
        internal bool IsSetInstanceName() => this.InstanceName != null;

        /// <summary>
        /// Gets and sets the property RegisterTime. 
        /// <para>
        /// The time at which the on-premises instance was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisterTime { get; set; }

        /// <summary>
        /// Checks to see if the RegisterTime property is set.
        /// </summary>
        internal bool IsSetRegisterTime() => this.RegisterTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags currently associated with the on-premises instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
