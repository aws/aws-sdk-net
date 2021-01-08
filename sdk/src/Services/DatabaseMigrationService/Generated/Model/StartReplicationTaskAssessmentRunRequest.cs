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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the StartReplicationTaskAssessmentRun operation.
    /// Starts a new premigration assessment run for one or more individual assessments of
    /// a migration task.
    /// 
    ///  
    /// <para>
    /// The assessments that you can specify depend on the source and target database engine
    /// and the migration type defined for the given task. To run this operation, your migration
    /// task must already be created. After you run this operation, you can review the status
    /// of each individual assessment. You can also run the migration task manually after
    /// the assessment run and its individual assessments complete.
    /// </para>
    /// </summary>
    public partial class StartReplicationTaskAssessmentRunRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _assessmentRunName;
        private List<string> _exclude = new List<string>();
        private List<string> _includeOnly = new List<string>();
        private string _replicationTaskArn;
        private string _resultEncryptionMode;
        private string _resultKmsKeyArn;
        private string _resultLocationBucket;
        private string _resultLocationFolder;
        private string _serviceAccessRoleArn;

        /// <summary>
        /// Gets and sets the property AssessmentRunName. 
        /// <para>
        /// Unique name to identify the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssessmentRunName
        {
            get { return this._assessmentRunName; }
            set { this._assessmentRunName = value; }
        }

        // Check to see if AssessmentRunName property is set
        internal bool IsSetAssessmentRunName()
        {
            return this._assessmentRunName != null;
        }

        /// <summary>
        /// Gets and sets the property Exclude. 
        /// <para>
        /// Space-separated list of names for specific individual assessments that you want to
        /// exclude. These names come from the default list of individual assessments that AWS
        /// DMS supports for the associated migration task. This task is specified by <code>ReplicationTaskArn</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't set a value for <code>Exclude</code> if you also set a value for <code>IncludeOnly</code>
        /// in the API operation.
        /// </para>
        ///  
        /// <para>
        /// To identify the names of the default individual assessments that AWS DMS supports
        /// for the associated migration task, run the <code>DescribeApplicableIndividualAssessments</code>
        /// operation using its own <code>ReplicationTaskArn</code> request parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> Exclude
        {
            get { return this._exclude; }
            set { this._exclude = value; }
        }

        // Check to see if Exclude property is set
        internal bool IsSetExclude()
        {
            return this._exclude != null && this._exclude.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeOnly. 
        /// <para>
        /// Space-separated list of names for specific individual assessments that you want to
        /// include. These names come from the default list of individual assessments that AWS
        /// DMS supports for the associated migration task. This task is specified by <code>ReplicationTaskArn</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't set a value for <code>IncludeOnly</code> if you also set a value for <code>Exclude</code>
        /// in the API operation. 
        /// </para>
        ///  
        /// <para>
        /// To identify the names of the default individual assessments that AWS DMS supports
        /// for the associated migration task, run the <code>DescribeApplicableIndividualAssessments</code>
        /// operation using its own <code>ReplicationTaskArn</code> request parameter.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> IncludeOnly
        {
            get { return this._includeOnly; }
            set { this._includeOnly = value; }
        }

        // Check to see if IncludeOnly property is set
        internal bool IsSetIncludeOnly()
        {
            return this._includeOnly != null && this._includeOnly.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the migration task associated with the premigration
        /// assessment run that you want to start.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResultEncryptionMode. 
        /// <para>
        /// Encryption mode that you can specify to encrypt the results of this assessment run.
        /// If you don't specify this request parameter, AWS DMS stores the assessment run results
        /// without encryption. You can specify one of the options following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>"SSE_S3"</code> – The server-side encryption provided as a default by Amazon
        /// S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>"SSE_KMS"</code> – AWS Key Management Service (AWS KMS) encryption. This encryption
        /// can use either a custom KMS encryption key that you specify or the default KMS encryption
        /// key that DMS provides.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResultEncryptionMode
        {
            get { return this._resultEncryptionMode; }
            set { this._resultEncryptionMode = value; }
        }

        // Check to see if ResultEncryptionMode property is set
        internal bool IsSetResultEncryptionMode()
        {
            return this._resultEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ResultKmsKeyArn. 
        /// <para>
        /// ARN of a custom KMS encryption key that you specify when you set <code>ResultEncryptionMode</code>
        /// to <code>"SSE_KMS</code>".
        /// </para>
        /// </summary>
        public string ResultKmsKeyArn
        {
            get { return this._resultKmsKeyArn; }
            set { this._resultKmsKeyArn = value; }
        }

        // Check to see if ResultKmsKeyArn property is set
        internal bool IsSetResultKmsKeyArn()
        {
            return this._resultKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResultLocationBucket. 
        /// <para>
        /// Amazon S3 bucket where you want AWS DMS to store the results of this assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResultLocationBucket
        {
            get { return this._resultLocationBucket; }
            set { this._resultLocationBucket = value; }
        }

        // Check to see if ResultLocationBucket property is set
        internal bool IsSetResultLocationBucket()
        {
            return this._resultLocationBucket != null;
        }

        /// <summary>
        /// Gets and sets the property ResultLocationFolder. 
        /// <para>
        /// Folder within an Amazon S3 bucket where you want AWS DMS to store the results of this
        /// assessment run.
        /// </para>
        /// </summary>
        public string ResultLocationFolder
        {
            get { return this._resultLocationFolder; }
            set { this._resultLocationFolder = value; }
        }

        // Check to see if ResultLocationFolder property is set
        internal bool IsSetResultLocationFolder()
        {
            return this._resultLocationFolder != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// ARN of a service role needed to start the assessment run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

    }
}