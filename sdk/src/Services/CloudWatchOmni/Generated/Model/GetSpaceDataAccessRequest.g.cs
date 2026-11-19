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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the GetSpaceDataAccess operation. Returns temporary
    /// credentials for working with data in a space, limited to the actions you request.
    /// The credentials allow only the requested actions that can be granted in the space
    /// and that your access grants allow. Requested actions that cannot be conferred are
    /// ignored rather than rejected.
    /// </summary>
    public partial class GetSpaceDataAccessRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property AuditContext. Caller-supplied key-value pairs that are
        /// recorded for auditing. They do not affect authorization or the permissions of the
        /// credentials.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public Dictionary<string, string> AuditContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null && (this.AuditContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DurationSeconds. The lifetime of the credentials, in seconds.
        /// Defaults to 3600.
        /// </summary>
        [AWSProperty(Min = 900, Max = 3600)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SpaceId. The unique ID of the space to return credentials
        /// for.
        /// </summary>
        [AWSProperty(Required = true)]
        public string SpaceId { get; set; }

        /// <summary>
        /// Checks to see if the SpaceId property is set.
        /// </summary>
        internal bool IsSetSpaceId() => this.SpaceId != null;

        /// <summary>
        /// Gets and sets the property TargetScopes. The actions to include in the credentials,
        /// grouped by service.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<DataAccessTarget> TargetScopes { get; set; } = AWSConfigs.InitializeCollections ? new List<DataAccessTarget>() : null;

        /// <summary>
        /// Checks to see if the TargetScopes property is set.
        /// </summary>
        internal bool IsSetTargetScopes() => this.TargetScopes != null && (this.TargetScopes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
