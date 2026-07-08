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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains the status and metadata for an opt-in feature.
    /// </summary>
    public partial class FeatureDetail
    {
        private FeatureStatus _featureStatus;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property FeatureStatus. 
        /// <para>
        /// The current enablement status of the feature. Valid values: <c>ENABLED</c> | <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public FeatureStatus FeatureStatus
        {
            get { return this._featureStatus; }
            set { this._featureStatus = value; }
        }

        // Check to see if FeatureStatus property is set
        internal bool IsSetFeatureStatus()
        {
            return this._featureStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the feature status was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}