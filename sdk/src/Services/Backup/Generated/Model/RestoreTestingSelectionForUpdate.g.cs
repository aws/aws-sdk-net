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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This contains metadata about a restore testing selection.
    /// </summary>
    public partial class RestoreTestingSelectionForUpdate
    {
        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example: <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ProtectedResourceArns. 
        /// <para>
        /// You can include a list of specific ARNs, such as <c>ProtectedResourceArns: ["arn:aws:...",
        /// "arn:aws:..."]</c> or you can include a wildcard: <c>ProtectedResourceArns: ["*"]</c>,
        /// but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProtectedResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProtectedResourceArns property is set.
        /// </summary>
        internal bool IsSetProtectedResourceArns() => this.ProtectedResourceArns != null && (this.ProtectedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProtectedResourceConditions. 
        /// <para>
        /// The conditions that you define for resources in your restore testing plan using tags.
        /// </para>
        /// </summary>
        public ProtectedResourceConditions ProtectedResourceConditions { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedResourceConditions property is set.
        /// </summary>
        internal bool IsSetProtectedResourceConditions() => this.ProtectedResourceConditions != null;

        /// <summary>
        /// Gets and sets the property RestoreMetadataOverrides. 
        /// <para>
        /// You can override certain restore metadata keys by including the parameter <c>RestoreMetadataOverrides</c>
        /// in the body of <c>RestoreTestingSelection</c>. Key values are not case sensitive.
        /// </para>
        ///  
        /// <para>
        /// See the complete list of <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/restore-testing-inferred-metadata.html">restore
        /// testing inferred metadata</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> RestoreMetadataOverrides { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RestoreMetadataOverrides property is set.
        /// </summary>
        internal bool IsSetRestoreMetadataOverrides() => this.RestoreMetadataOverrides != null && (this.RestoreMetadataOverrides.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationWindowHours. 
        /// <para>
        /// This value represents the time, in hours, data is retained after a restore test so
        /// that optional validation can be completed.
        /// </para>
        ///  
        /// <para>
        /// Accepted value is an integer between 0 and 168 (the hourly equivalent of seven days).
        /// </para>
        /// </summary>
        public int? ValidationWindowHours { get; set; }

        /// <summary>
        /// Checks to see if the ValidationWindowHours property is set.
        /// </summary>
        internal bool IsSetValidationWindowHours() => this.ValidationWindowHours.HasValue;
    }
}
