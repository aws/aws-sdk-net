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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Post Launch Actions to executed on the Test or Cutover instance.
    /// </summary>
    public partial class PostLaunchActions
    {
        private string _cloudWatchLogGroupName;
        private PostLaunchActionsDeploymentType _deployment;
        private string _s3LogBucket;
        private string _s3OutputKeyPrefix;
        private List<SsmDocument> _ssmDocuments = new List<SsmDocument>();

        /// <summary>
        /// Gets and sets the property CloudWatchLogGroupName. 
        /// <para>
        /// AWS Systems Manager Command's CloudWatch log group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string CloudWatchLogGroupName
        {
            get { return this._cloudWatchLogGroupName; }
            set { this._cloudWatchLogGroupName = value; }
        }

        // Check to see if CloudWatchLogGroupName property is set
        internal bool IsSetCloudWatchLogGroupName()
        {
            return this._cloudWatchLogGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Deployment. 
        /// <para>
        /// Deployment type in which AWS Systems Manager Documents will be executed.
        /// </para>
        /// </summary>
        public PostLaunchActionsDeploymentType Deployment
        {
            get { return this._deployment; }
            set { this._deployment = value; }
        }

        // Check to see if Deployment property is set
        internal bool IsSetDeployment()
        {
            return this._deployment != null;
        }

        /// <summary>
        /// Gets and sets the property S3LogBucket. 
        /// <para>
        /// AWS Systems Manager Command's logs S3 log bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string S3LogBucket
        {
            get { return this._s3LogBucket; }
            set { this._s3LogBucket = value; }
        }

        // Check to see if S3LogBucket property is set
        internal bool IsSetS3LogBucket()
        {
            return this._s3LogBucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputKeyPrefix. 
        /// <para>
        /// AWS Systems Manager Command's logs S3 output key prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string S3OutputKeyPrefix
        {
            get { return this._s3OutputKeyPrefix; }
            set { this._s3OutputKeyPrefix = value; }
        }

        // Check to see if S3OutputKeyPrefix property is set
        internal bool IsSetS3OutputKeyPrefix()
        {
            return this._s3OutputKeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SsmDocuments. 
        /// <para>
        /// AWS Systems Manager Documents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<SsmDocument> SsmDocuments
        {
            get { return this._ssmDocuments; }
            set { this._ssmDocuments = value; }
        }

        // Check to see if SsmDocuments property is set
        internal bool IsSetSsmDocuments()
        {
            return this._ssmDocuments != null && this._ssmDocuments.Count > 0; 
        }

    }
}