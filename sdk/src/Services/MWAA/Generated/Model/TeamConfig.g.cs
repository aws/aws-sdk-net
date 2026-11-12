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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Describes the configuration for a single team in Apache Airflow multi-team support
    /// on your Amazon MWAA environment. A team configuration defines the Amazon S3 location
    /// of the DAG code for the team. The team name that maps to this configuration must match
    /// the display name of an Amazon Web Services IAM Identity Center group associated with
    /// your environment. For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/multi-team-environments.html">Apache
    /// Airflow multi-team environments</a>.
    /// </summary>
    public partial class TeamConfig
    {
        /// <summary>
        /// Gets and sets the property DagS3Path. 
        /// <para>
        /// The relative path to the DAGs folder for the team in the team's Amazon S3 bucket.
        /// For example, <c>dags/team-a</c>. For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/configuring-dag-folder.html">Adding
        /// or updating DAGs</a>.
        /// </para>
        ///  
        /// <para>
        /// DAG folders can't overlap. A team folder can't be inside the global folder or another
        /// team's folder, and the global folder can't be inside a team folder. Amazon Managed
        /// Workflows for Apache Airflow (Amazon MWAA) compares folder paths as Amazon S3 prefixes,
        /// so the trailing slash matters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/dags/</c> and <c>s3://amzn-s3-demo-bucket/dags/team-a/</c>
        /// overlap, because the first path is a prefix of the second.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/dags/</c> and <c>s3://amzn-s3-demo-bucket/dags-team-a/</c>
        /// don't overlap.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>s3://amzn-s3-demo-bucket/teams/team-a/</c> and <c>s3://amzn-s3-demo-bucket/teams/team-b/</c>
        /// don't overlap.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string DagS3Path { get; set; }

        /// <summary>
        /// Checks to see if the DagS3Path property is set.
        /// </summary>
        internal bool IsSetDagS3Path() => this.DagS3Path != null;

        /// <summary>
        /// Gets and sets the property SourceBucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 bucket where the team's DAG code and
        /// supporting files are stored. For example, <c>arn:aws:s3:::my-airflow-bucket-unique-name</c>.
        /// For more information, refer to <a href="https://docs.aws.amazon.com/mwaa/latest/userguide/mwaa-s3-bucket.html">Create
        /// an Amazon S3 bucket for Amazon MWAA</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1224)]
        public string SourceBucketArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBucketArn property is set.
        /// </summary>
        internal bool IsSetSourceBucketArn() => this.SourceBucketArn != null;
    }
}
