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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemporaryDataLocationCredentials operation.
    /// Allows a user or application in a secure environment to access data in a specific
    /// Amazon S3 location registered with Lake Formation by providing temporary scoped credentials
    /// that are limited to the requested data location and the caller's authorized access
    /// level. <para> <c>GetDataAccess</c> is logged in CloudTrail whenever a principal requests
    /// temporary data location credentials to access data in a data lake location that is
    /// registered with Lake Formation. </para> <para> The API operation returns an error
    /// in the following scenarios: </para> <ul> <li> <para> The data location is not registered
    /// with Lake Formation. </para> </li> <li> <para> No Glue table is associated with the
    /// data location. </para> </li> <li> <para> The caller doesn't have required permissions
    /// on the associated table. The caller must have <c>SELECT</c> or <c>SUPER</c> permissions
    /// on the associated table, and credential vending for full table access must be enabled
    /// in the data lake settings. </para> <para> For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/full-table-credential-vending.html">Application
    /// integration for full table access</a>. </para> </li> <li> <para> The data location
    /// is in a different Amazon Web Services Region. Lake Formation doesn't support cross-Region
    /// access when vending credentials for a data location. Lake Formation only supports
    /// Amazon S3 paths registered within the same Region as the API call. </para> </li> </ul>
    /// </summary>
    public partial class GetTemporaryDataLocationCredentialsRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property AuditContext.
        /// </summary>
        public AuditContext AuditContext { get; set; }

        /// <summary>
        /// Checks to see if the AuditContext property is set.
        /// </summary>
        internal bool IsSetAuditContext() => this.AuditContext != null;

        /// <summary>
        /// Gets and sets the property CredentialsScope. 
        /// <para>
        /// The credential scope is determined by the caller's Lake Formation permission on the
        /// associated table. Credential scope can be either:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// READ - Provides read-only access to the data location.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// READ_WRITE - Provides both read and write access to the data location.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CredentialsScope CredentialsScope { get; set; }

        /// <summary>
        /// Checks to see if the CredentialsScope property is set.
        /// </summary>
        internal bool IsSetCredentialsScope() => this.CredentialsScope != null;

        /// <summary>
        /// Gets and sets the property DataLocations. 
        /// <para>
        /// The Amazon S3 data location that you want to access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DataLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataLocations property is set.
        /// </summary>
        internal bool IsSetDataLocations() => this.DataLocations != null && (this.DataLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The time period, between 900 and 43,200 seconds, for the timeout of the temporary
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 900, Max = 43200)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;
    }
}
