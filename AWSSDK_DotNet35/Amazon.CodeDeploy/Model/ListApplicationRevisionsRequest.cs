/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListApplicationRevisions operation.
    /// Lists information about revisions for an application.
    /// </summary>
    public partial class ListApplicationRevisionsRequest : AmazonCodeDeployRequest
    {
        private string _applicationName;
        private ListStateFilterAction _deployed;
        private string _nextToken;
        private string _s3Bucket;
        private string _s3KeyPrefix;
        private ApplicationRevisionSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of an existing AWS CodeDeploy application associated with the applicable
        /// IAM user or AWS account.
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property Deployed. 
        /// <para>
        /// Whether to list revisions based on whether the revision is the target revision of
        /// an deployment group:
        /// </para>
        ///  <ul> <li>include: List revisions that are target revisions of a deployment group.</li>
        /// <li>exclude: Do not list revisions that are target revisions of a deployment group.</li>
        /// <li>ignore: List all revisions, regardless of whether they are target revisions of
        /// a deployment group.</li> </ul>
        /// </summary>
        public ListStateFilterAction Deployed
        {
            get { return this._deployed; }
            set { this._deployed = value; }
        }

        // Check to see if Deployed property is set
        internal bool IsSetDeployed()
        {
            return this._deployed != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous list application revisions call,
        /// which can be used to return the next set of applications in the list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// A specific Amazon S3 bucket name to limit the search for revisions.
        /// </para>
        ///  
        /// <para>
        /// If set to null, then all of the user's buckets will be searched.
        /// </para>
        /// </summary>
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3KeyPrefix. 
        /// <para>
        /// A specific key prefix for the set of Amazon S3 objects to limit the search for revisions.
        /// </para>
        /// </summary>
        public string S3KeyPrefix
        {
            get { return this._s3KeyPrefix; }
            set { this._s3KeyPrefix = value; }
        }

        // Check to see if S3KeyPrefix property is set
        internal bool IsSetS3KeyPrefix()
        {
            return this._s3KeyPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The column name to sort the list results by:
        /// </para>
        ///  <ul> <li>registerTime: Sort the list results by when the revisions were registered
        /// with AWS CodeDeploy.</li> <li>firstUsedTime: Sort the list results by when the revisions
        /// were first used by in a deployment.</li> <li>lastUsedTime: Sort the list results by
        /// when the revisions were last used in a deployment.</li> </ul> 
        /// <para>
        /// If not specified or set to null, the results will be returned in an arbitrary order.
        /// </para>
        /// </summary>
        public ApplicationRevisionSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort the list results by:
        /// </para>
        ///  <ul> <li>ascending: Sort the list of results in ascending order.</li> <li>descending:
        /// Sort the list of results in descending order.</li> </ul> 
        /// <para>
        /// If not specified, the results will be sorted in ascending order.
        /// </para>
        ///  
        /// <para>
        /// If set to null, the results will be sorted in an arbitrary order.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}