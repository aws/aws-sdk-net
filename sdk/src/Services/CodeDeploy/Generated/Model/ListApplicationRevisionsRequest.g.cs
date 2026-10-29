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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplicationRevisions operation. Lists information
    /// about revisions for an application.
    /// </summary>
    public partial class ListApplicationRevisionsRequest : AmazonCodeDeployRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of an CodeDeploy application associated with the user or Amazon Web Services
        /// account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property Deployed. 
        /// <para>
        ///  Whether to list revisions based on whether the revision is the target revision of
        /// a deployment group: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>include</c>: List revisions that are target revisions of a deployment group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>exclude</c>: Do not list revisions that are target revisions of a deployment group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ignore</c>: List all revisions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ListStateFilterAction Deployed { get; set; }

        /// <summary>
        /// Checks to see if the Deployed property is set.
        /// </summary>
        internal bool IsSetDeployed() => this.Deployed != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier returned from the previous <c>ListApplicationRevisions</c> call. It
        /// can be used to return the next set of applications in the list.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        ///  An Amazon S3 bucket name to limit the search for revisions. 
        /// </para>
        ///  
        /// <para>
        ///  If set to null, all of the user's buckets are searched. 
        /// </para>
        /// </summary>
        public string S3Bucket { get; set; }

        /// <summary>
        /// Checks to see if the S3Bucket property is set.
        /// </summary>
        internal bool IsSetS3Bucket() => this.S3Bucket != null;

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        ///  A key prefix for the set of Amazon S3 objects to limit the search for revisions.
        /// 
        /// </para>
        /// </summary>
        public string S3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetS3KeyPrefix() => this.S3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The column name to use to sort the list results:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>registerTime</c>: Sort by the time the revisions were registered with CodeDeploy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>firstUsedTime</c>: Sort by the time the revisions were first used in a deployment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>lastUsedTime</c>: Sort by the time the revisions were last used in a deployment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If not specified or set to null, the results are returned in an arbitrary order.
        /// 
        /// </para>
        /// </summary>
        public ApplicationRevisionSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        ///  The order in which to sort the list results: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ascending</c>: ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>descending</c>: descending order.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If not specified, the results are sorted in ascending order.
        /// </para>
        ///  
        /// <para>
        /// If set to null, the results are sorted in an arbitrary order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
