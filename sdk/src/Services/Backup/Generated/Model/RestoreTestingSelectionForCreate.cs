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
    /// This contains metadata about a specific restore testing selection.
    /// 
    ///  
    /// <para>
    /// ProtectedResourceType is required, such as Amazon EBS or Amazon EC2.
    /// </para>
    ///  
    /// <para>
    /// This consists of <c>RestoreTestingSelectionName</c>, <c>ProtectedResourceType</c>,
    /// and one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>ProtectedResourceArns</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ProtectedResourceConditions</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Each protected resource type can have one single value.
    /// </para>
    ///  
    /// <para>
    /// A restore testing selection can include a wildcard value ("*") for <c>ProtectedResourceArns</c>
    /// along with <c>ProtectedResourceConditions</c>. Alternatively, you can include up to
    /// 30 specific protected resource ARNs in <c>ProtectedResourceArns</c>.
    /// </para>
    ///  
    /// <para>
    ///  <c>ProtectedResourceConditions</c> examples include as <c>StringEquals</c> and <c>StringNotEquals</c>.
    /// </para>
    /// </summary>
    public partial class RestoreTestingSelectionForCreate
    {
        private string _iamRoleArn;
        private List<string> _protectedResourceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtectedResourceConditions _protectedResourceConditions;
        private string _protectedResourceType;
        private Dictionary<string, string> _restoreMetadataOverrides = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _restoreTestingSelectionName;
        private int? _validationWindowHours;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that Backup uses to create the target
        /// resource; for example: <c>arn:aws:iam::123456789012:role/S3Access</c>. 
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
        /// Each protected resource can be filtered by its specific ARNs, such as <c>ProtectedResourceArns:
        /// ["arn:aws:...", "arn:aws:..."]</c> or by a wildcard: <c>ProtectedResourceArns: ["*"]</c>,
        /// but not both.
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
        /// If you have included the wildcard in ProtectedResourceArns, you can include resource
        /// conditions, such as <c>ProtectedResourceConditions: { StringEquals: [{ key: "XXXX",
        /// value: "YYYY" }]</c>.
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
        /// The type of Amazon Web Services resource included in a restore testing selection;
        /// for example, an Amazon EBS volume or an Amazon RDS database.
        /// </para>
        ///  
        /// <para>
        /// Supported resource types accepted include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Aurora</c> for Amazon Aurora
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DocumentDB</c> for Amazon DocumentDB (with MongoDB compatibility)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DynamoDB</c> for Amazon DynamoDB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EBS</c> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2</c> for Amazon Elastic Compute Cloud
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EFS</c> for Amazon Elastic File System
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FSx</c> for Amazon FSx
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Neptune</c> for Amazon Neptune
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RDS</c> for Amazon Relational Database Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> for Amazon S3
        /// </para>
        ///  </li> </ul>
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
        /// This is amount of hours (0 to 168) available to run a validation script on the data.
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