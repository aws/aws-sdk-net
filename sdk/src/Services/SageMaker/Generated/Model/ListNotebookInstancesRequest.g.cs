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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotebookInstances operation. Returns a list
    /// of the SageMaker AI notebook instances in the requester's account in an Amazon Web
    /// Services Region.
    /// </summary>
    public partial class ListNotebookInstancesRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalCodeRepositoryEquals. 
        /// <para>
        /// A filter that returns only notebook instances with associated with the specified git
        /// repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AdditionalCodeRepositoryEquals { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalCodeRepositoryEquals property is set.
        /// </summary>
        internal bool IsSetAdditionalCodeRepositoryEquals() => this.AdditionalCodeRepositoryEquals != null;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only notebook instances that were created after the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only notebook instances that were created before the specified
        /// time (timestamp). 
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultCodeRepositoryContains. 
        /// <para>
        /// A string in the name or URL of a Git repository associated with this notebook instance.
        /// This filter returns only notebook instances associated with a git repository with
        /// a name that contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string DefaultCodeRepositoryContains { get; set; }

        /// <summary>
        /// Checks to see if the DefaultCodeRepositoryContains property is set.
        /// </summary>
        internal bool IsSetDefaultCodeRepositoryContains() => this.DefaultCodeRepositoryContains != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// A filter that returns only notebook instances that were modified after the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeAfter() => this.LastModifiedTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// A filter that returns only notebook instances that were modified before the specified
        /// time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeBefore() => this.LastModifiedTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of notebook instances to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string in the notebook instances' name. This filter returns only notebook instances
        /// whose name contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  If the previous call to the <c>ListNotebookInstances</c> is truncated, the response
        /// includes a <c>NextToken</c>. You can use this token in your subsequent <c>ListNotebookInstances</c>
        /// request to fetch the next set of notebook instances. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You might specify a filter or a sort order in your request. When response is truncated,
        /// you must use the same values for the filer and sort order in the next request. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NotebookInstanceLifecycleConfigNameContains. 
        /// <para>
        /// A string in the name of a notebook instances lifecycle configuration associated with
        /// this notebook instance. This filter returns only notebook instances associated with
        /// a lifecycle configuration with a name that contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NotebookInstanceLifecycleConfigNameContains { get; set; }

        /// <summary>
        /// Checks to see if the NotebookInstanceLifecycleConfigNameContains property is set.
        /// </summary>
        internal bool IsSetNotebookInstanceLifecycleConfigNameContains() => this.NotebookInstanceLifecycleConfigNameContains != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to sort results by. The default is <c>Name</c>.
        /// </para>
        /// </summary>
        public NotebookInstanceSortKey SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for results. 
        /// </para>
        /// </summary>
        public NotebookInstanceSortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property StatusEquals. 
        /// <para>
        /// A filter that returns only notebook instances with the specified status.
        /// </para>
        /// </summary>
        public NotebookInstanceStatus StatusEquals { get; set; }

        /// <summary>
        /// Checks to see if the StatusEquals property is set.
        /// </summary>
        internal bool IsSetStatusEquals() => this.StatusEquals != null;
    }
}
