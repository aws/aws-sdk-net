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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Specifies configuration for propagating resource tags from source log groups to centralized
    /// destination log groups. The service uses a customer-managed IAM role in the destination
    /// account to add, update, and remove tags on destination log groups.
    /// </summary>
    public partial class TagPropagationConfiguration
    {
        private string _destinationRoleArn;
        private TagConflictResolutionStrategy _tagConflictResolutionStrategy;

        /// <summary>
        /// Gets and sets the property DestinationRoleArn. 
        /// <para>
        /// The ARN of a customer-managed IAM role in the destination account. The service assumes
        /// this role to propagate tags to destination log groups. You must have <c>iam:PassRole</c>
        /// permission on this role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DestinationRoleArn
        {
            get { return this._destinationRoleArn; }
            set { this._destinationRoleArn = value; }
        }

        // Check to see if DestinationRoleArn property is set
        internal bool IsSetDestinationRoleArn()
        {
            return this._destinationRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TagConflictResolutionStrategy. 
        /// <para>
        /// The strategy for resolving conflicts when a tag key exists on both the source and
        /// destination log groups. If not specified, defaults to <c>UPDATE_SYNC</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ADD_ONLY</c> – Only adds new tags from the source without modifying existing destination
        /// tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATE_SYNC</c> – Adds new tags and updates existing tags from the source. Does
        /// not remove destination tags that are absent from the source.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c> – Keeps destination tags fully synchronized with source tags, including
        /// removing destination tags that do not exist on the source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TagConflictResolutionStrategy TagConflictResolutionStrategy
        {
            get { return this._tagConflictResolutionStrategy; }
            set { this._tagConflictResolutionStrategy = value; }
        }

        // Check to see if TagConflictResolutionStrategy property is set
        internal bool IsSetTagConflictResolutionStrategy()
        {
            return this._tagConflictResolutionStrategy != null;
        }

    }
}