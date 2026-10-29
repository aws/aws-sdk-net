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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeMitigationAction operation.
    /// </summary>
    public partial class DescribeMitigationActionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActionArn. 
        /// <para>
        /// The ARN that identifies this migration action.
        /// </para>
        /// </summary>
        public string ActionArn { get; set; }

        /// <summary>
        /// Checks to see if the ActionArn property is set.
        /// </summary>
        internal bool IsSetActionArn() => this.ActionArn != null;

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// A unique identifier for this action.
        /// </para>
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// Checks to see if the ActionId property is set.
        /// </summary>
        internal bool IsSetActionId() => this.ActionId != null;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The friendly name that uniquely identifies the mitigation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string ActionName { get; set; }

        /// <summary>
        /// Checks to see if the ActionName property is set.
        /// </summary>
        internal bool IsSetActionName() => this.ActionName != null;

        /// <summary>
        /// Gets and sets the property ActionParams. 
        /// <para>
        /// Parameters that control how the mitigation action is applied, specific to the type
        /// of mitigation action.
        /// </para>
        /// </summary>
        public MitigationActionParams ActionParams { get; set; }

        /// <summary>
        /// Checks to see if the ActionParams property is set.
        /// </summary>
        internal bool IsSetActionParams() => this.ActionParams != null;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of mitigation action.
        /// </para>
        /// </summary>
        public MitigationActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the mitigation action was added to your Amazon Web Services
        /// accounts.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the mitigation action was last changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role used to apply this action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
