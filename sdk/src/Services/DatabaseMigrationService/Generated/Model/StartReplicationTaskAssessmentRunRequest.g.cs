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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplicationTaskAssessmentRun operation. Starts
    /// a new premigration assessment run for one or more individual assessments of a migration
    /// task. <para> The assessments that you can specify depend on the source and target
    /// database engine and the migration type defined for the given task. To run this operation,
    /// your migration task must already be created. After you run this operation, you can
    /// review the status of each individual assessment. You can also run the migration task
    /// manually after the assessment run and its individual assessments complete. </para>
    /// </summary>
    public partial class StartReplicationTaskAssessmentRunRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AssessmentRunName. 
        /// <para>
        /// Unique name to identify the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssessmentRunName { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentRunName property is set.
        /// </summary>
        internal bool IsSetAssessmentRunName() => this.AssessmentRunName != null;

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Space-separated list of names for specific individual assessments that you want to
        /// exclude. These names come from the default list of individual assessments that DMS
        /// supports for the associated migration task. This task is specified by <c>ReplicationTaskArn</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't set a value for <c>Exclude</c> if you also set a value for <c>IncludeOnly</c>
        /// in the API operation.
        /// </para>
        ///  
        /// <para>
        /// To identify the names of the default individual assessments that DMS supports for
        /// the associated migration task, run the <c>DescribeApplicableIndividualAssessments</c>
        /// operation using its own <c>ReplicationTaskArn</c> request parameter.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Exclude { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Exclude property is set.
        /// </summary>
        internal bool IsSetExclude() => this.Exclude != null && (this.Exclude.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeOnly. 
        /// <para>
        /// Space-separated list of names for specific individual assessments that you want to
        /// include. These names come from the default list of individual assessments that DMS
        /// supports for the associated migration task. This task is specified by <c>ReplicationTaskArn</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't set a value for <c>IncludeOnly</c> if you also set a value for <c>Exclude</c>
        /// in the API operation. 
        /// </para>
        ///  
        /// <para>
        /// To identify the names of the default individual assessments that DMS supports for
        /// the associated migration task, run the <c>DescribeApplicableIndividualAssessments</c>
        /// operation using its own <c>ReplicationTaskArn</c> request parameter.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IncludeOnly { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IncludeOnly property is set.
        /// </summary>
        internal bool IsSetIncludeOnly() => this.IncludeOnly != null && (this.IncludeOnly.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the migration task associated with the premigration
        /// assessment run that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReplicationTaskArn { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationTaskArn property is set.
        /// </summary>
        internal bool IsSetReplicationTaskArn() => this.ReplicationTaskArn != null;

        /// <summary>
        /// Gets and sets the property ResultEncryptionMode. 
        /// <para>
        /// Encryption mode that you can specify to encrypt the results of this assessment run.
        /// If you don't specify this request parameter, DMS stores the assessment run results
        /// without encryption. You can specify one of the options following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"SSE_S3"</c> – The server-side encryption provided as a default by Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"SSE_KMS"</c> – Key Management Service (KMS) encryption. This encryption can use
        /// either a custom KMS encryption key that you specify or the default KMS encryption
        /// key that DMS provides.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResultEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the ResultEncryptionMode property is set.
        /// </summary>
        internal bool IsSetResultEncryptionMode() => this.ResultEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property ResultKmsKeyArn. 
        /// <para>
        /// ARN of a custom KMS encryption key that you specify when you set <c>ResultEncryptionMode</c>
        /// to <c>"SSE_KMS</c>".
        /// </para>
        /// </summary>
        public string ResultKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ResultKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetResultKmsKeyArn() => this.ResultKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ResultLocationBucket. 
        /// <para>
        /// Amazon S3 bucket where you want DMS to store the results of this assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResultLocationBucket { get; set; }

        /// <summary>
        /// Checks to see if the ResultLocationBucket property is set.
        /// </summary>
        internal bool IsSetResultLocationBucket() => this.ResultLocationBucket != null;

        /// <summary>
        /// Gets and sets the property ResultLocationFolder. 
        /// <para>
        /// Folder within an Amazon S3 bucket where you want DMS to store the results of this
        /// assessment run.
        /// </para>
        /// </summary>
        public string ResultLocationFolder { get; set; }

        /// <summary>
        /// Checks to see if the ResultLocationFolder property is set.
        /// </summary>
        internal bool IsSetResultLocationFolder() => this.ResultLocationFolder != null;

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// ARN of the service role needed to start the assessment run. The role must allow the
        /// <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceAccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceAccessRoleArn property is set.
        /// </summary>
        internal bool IsSetServiceAccessRoleArn() => this.ServiceAccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the premigration assessment run that you want to
        /// start.
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
