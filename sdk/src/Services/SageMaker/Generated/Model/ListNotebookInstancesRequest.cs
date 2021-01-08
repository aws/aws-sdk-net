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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotebookInstances operation.
    /// Returns a list of the Amazon SageMaker notebook instances in the requester's account
    /// in an AWS Region.
    /// </summary>
    public partial class ListNotebookInstancesRequest : AmazonSageMakerRequest
    {
        private string _additionalCodeRepositoryEquals;
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private string _defaultCodeRepositoryContains;
        private DateTime? _lastModifiedTimeAfter;
        private DateTime? _lastModifiedTimeBefore;
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;
        private string _notebookInstanceLifecycleConfigNameContains;
        private NotebookInstanceSortKey _sortBy;
        private NotebookInstanceSortOrder _sortOrder;
        private NotebookInstanceStatus _statusEquals;

        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositoryEquals. 
        /// <para>
        /// A filter that returns only notebook instances with associated with the specified git
        /// repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AdditionalCodeRepositoryEquals
        {
            get { return this._additionalCodeRepositoryEquals; }
            set { this._additionalCodeRepositoryEquals = value; }
        }

        // Check to see if AdditionalCodeRepositoryEquals property is set
        internal bool IsSetAdditionalCodeRepositoryEquals()
        {
            return this._additionalCodeRepositoryEquals != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only notebook instances that were created after the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime CreationTimeAfter
        {
            get { return this._creationTimeAfter.GetValueOrDefault(); }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only notebook instances that were created before the specified
        /// time (timestamp). 
        /// </para>
        /// </summary>
        public DateTime CreationTimeBefore
        {
            get { return this._creationTimeBefore.GetValueOrDefault(); }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultCodeRepositoryContains. 
        /// <para>
        /// A string in the name or URL of a Git repository associated with this notebook instance.
        /// This filter returns only notebook instances associated with a git repository with
        /// a name that contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string DefaultCodeRepositoryContains
        {
            get { return this._defaultCodeRepositoryContains; }
            set { this._defaultCodeRepositoryContains = value; }
        }

        // Check to see if DefaultCodeRepositoryContains property is set
        internal bool IsSetDefaultCodeRepositoryContains()
        {
            return this._defaultCodeRepositoryContains != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only notebook instances that were modified after the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimeAfter
        {
            get { return this._lastModifiedTimeAfter.GetValueOrDefault(); }
            set { this._lastModifiedTimeAfter = value; }
        }

        // Check to see if LastModifiedTimeAfter property is set
        internal bool IsSetLastModifiedTimeAfter()
        {
            return this._lastModifiedTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only notebook instances that were modified before the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimeBefore
        {
            get { return this._lastModifiedTimeBefore.GetValueOrDefault(); }
            set { this._lastModifiedTimeBefore = value; }
        }

        // Check to see if LastModifiedTimeBefore property is set
        internal bool IsSetLastModifiedTimeBefore()
        {
            return this._lastModifiedTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of notebook instances to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string in the notebook instances' name. This filter returns only notebook instances
        /// whose name contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If the previous call to the <code>ListNotebookInstances</code> is truncated, the
        /// response includes a <code>NextToken</code>. You can use this token in your subsequent
        /// <code>ListNotebookInstances</code> request to fetch the next set of notebook instances.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You might specify a filter or a sort order in your request. When response is truncated,
        /// you must use the same values for the filer and sort order in the next request. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=8192)]
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
        /// Gets and sets the property NotebookInstanceLifecycleConfigNameContains. 
        /// <para>
        /// A string in the name of a notebook instances lifecycle configuration associated with
        /// this notebook instance. This filter returns only notebook instances associated with
        /// a lifecycle configuration with a name that contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Max=63)]
        public string NotebookInstanceLifecycleConfigNameContains
        {
            get { return this._notebookInstanceLifecycleConfigNameContains; }
            set { this._notebookInstanceLifecycleConfigNameContains = value; }
        }

        // Check to see if NotebookInstanceLifecycleConfigNameContains property is set
        internal bool IsSetNotebookInstanceLifecycleConfigNameContains()
        {
            return this._notebookInstanceLifecycleConfigNameContains != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort results by. The default is <code>Name</code>.
        /// </para>
        /// </summary>
        public NotebookInstanceSortKey SortBy
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
        /// The sort order for results. 
        /// </para>
        /// </summary>
        public NotebookInstanceSortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// A filter that returns only notebook instances with the specified status.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus StatusEquals
        {
            get { return this._statusEquals; }
            set { this._statusEquals = value; }
        }

        // Check to see if StatusEquals property is set
        internal bool IsSetStatusEquals()
        {
            return this._statusEquals != null;
        }

    }
}