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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
        private DateTime? _creationTime;
        private string _creatorRequestId;
        private string _iamRoleArn;
        private List<string> _protectedResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtectedResourceConditions _protectedResourceConditions;
        private string _protectedResourceType;
        private Dictionary<string, string> _restoreMetadataOverrides = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _restoreTestingPlanName;
        private string _restoreTestingSelectionName;
        private int? _validationWindowHours;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a restore testing selection was created, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <c>CreationTime</c> is accurate to
        /// milliseconds. For example, the value 1516925490.087 represents Friday, January 26,
        /// 201812:11:30.087 AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

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
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example:<c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectedResourceArns. 
        /// <para>
        /// You can include specific ARNs, such as <c>ProtectedResourceArns: ["arn:aws:...", "arn:aws:..."]</c>
        /// or you can include a wildcard: <c>ProtectedResourceArns: ["*"]</c>, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProtectedResourceArns
        {
            get { return this._protectedResourceArns; }
            set { this._protectedResourceArns = value; }
        }

        // Check to see if ProtectedResourceArns property is set
        internal bool IsSetProtectedResourceArns()
        {
            return this._protectedResourceArns != null && (this._protectedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ProtectedResourceConditions. 
        /// <para>
        /// In a resource testing selection, this parameter filters by specific conditions such
        /// as <c>StringEquals</c> or <c>StringNotEquals</c>.
        /// </para>
        /// </summary>
        public ProtectedResourceConditions ProtectedResourceConditions
        {
            get { return this._protectedResourceConditions; }
            set { this._protectedResourceConditions = value; }
        }

        // Check to see if ProtectedResourceConditions property is set
        internal bool IsSetProtectedResourceConditions()
        {
            return this._protectedResourceConditions != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectedResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource included in a resource testing selection;
        /// for example, an Amazon EBS volume or an Amazon RDS database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProtectedResourceType
        {
            get { return this._protectedResourceType; }
            set { this._protectedResourceType = value; }
        }

        // Check to see if ProtectedResourceType property is set
        internal bool IsSetProtectedResourceType()
        {
            return this._protectedResourceType != null;
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> RestoreMetadataOverrides
        {
            get { return this._restoreMetadataOverrides; }
            set { this._restoreMetadataOverrides = value; }
        }

        // Check to see if RestoreMetadataOverrides property is set
        internal bool IsSetRestoreMetadataOverrides()
        {
            return this._restoreMetadataOverrides != null && (this._restoreMetadataOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The RestoreTestingPlanName is a unique string that is the name of the restore testing
        /// plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanName
        {
            get { return this._restoreTestingPlanName; }
            set { this._restoreTestingPlanName = value; }
        }

        // Check to see if RestoreTestingPlanName property is set
        internal bool IsSetRestoreTestingPlanName()
        {
            return this._restoreTestingPlanName != null;
        }

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
        [AWSProperty(Required=true)]
        public string RestoreTestingSelectionName
        {
            get { return this._restoreTestingSelectionName; }
            set { this._restoreTestingSelectionName = value; }
        }

        // Check to see if RestoreTestingSelectionName property is set
        internal bool IsSetRestoreTestingSelectionName()
        {
            return this._restoreTestingSelectionName != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationWindowHours. 
        /// <para>
        /// This is amount of hours (1 to 168) available to run a validation script on the data.
        /// The data will be deleted upon the completion of the validation script or the end of
        /// the specified retention period, whichever comes first.
        /// </para>
        /// </summary>
        public int? ValidationWindowHours
        {
            get { return this._validationWindowHours; }
            set { this._validationWindowHours = value; }
        }

        // Check to see if ValidationWindowHours property is set
        internal bool IsSetValidationWindowHours()
        {
            return this._validationWindowHours.HasValue; 
        }

    }
}