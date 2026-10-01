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
    public partial class RestoreTestingSelectionForGet
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a restore testing selection was created, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <c>CreationTime</c> is accurate to
        /// milliseconds. For example, the value 1516925490.087 represents Friday, January 26,
        /// 201812:11:30.087 AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This identifies the request and allows failed requests to be retried without the risk
        /// of running the operation twice. If the request includes a <c>CreatorRequestId</c>
        /// that matches an existing backup plan, that plan is returned. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example:<c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property ProtectedResourceArns. 
        /// <para>
        /// You can include specific ARNs, such as <c>ProtectedResourceArns: ["arn:aws:...", "arn:aws:..."]</c>
        /// or you can include a wildcard: <c>ProtectedResourceArns: ["*"]</c>, but not both.
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
        /// In a resource testing selection, this parameter filters by specific conditions such
        /// as <c>StringEquals</c> or <c>StringNotEquals</c>.
        /// </para>
        /// </summary>
        public ProtectedResourceConditions ProtectedResourceConditions { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedResourceConditions property is set.
        /// </summary>
        internal bool IsSetProtectedResourceConditions() => this.ProtectedResourceConditions != null;

        /// <summary>
        /// Gets and sets the property ProtectedResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource included in a resource testing selection;
        /// for example, an Amazon EBS volume or an Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProtectedResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ProtectedResourceType property is set.
        /// </summary>
        internal bool IsSetProtectedResourceType() => this.ProtectedResourceType != null;

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
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The RestoreTestingPlanName is a unique string that is the name of the restore testing
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingSelectionName. 
        /// <para>
        /// The unique name of the restore testing selection that belongs to the related restore
        /// testing plan.
        /// </para>
        ///  
        /// <para>
        /// The name consists of only alphanumeric characters and underscores. Maximum length
        /// is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingSelectionName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingSelectionName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingSelectionName() => this.RestoreTestingSelectionName != null;

        /// <summary>
        /// Gets and sets the property ValidationWindowHours. 
        /// <para>
        /// This is amount of hours (1 to 168) available to run a validation script on the data.
        /// The data will be deleted upon the completion of the validation script or the end of
        /// the specified retention period, whichever comes first.
        /// </para>
        /// </summary>
        public int? ValidationWindowHours { get; set; }

        /// <summary>
        /// Checks to see if the ValidationWindowHours property is set.
        /// </summary>
        internal bool IsSetValidationWindowHours() => this.ValidationWindowHours.HasValue;
    }
}
