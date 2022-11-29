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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAddonVersions operation.
    /// Describes the versions for an add-on. Information such as the Kubernetes versions
    /// that you can use the add-on with, the <code>owner</code>, <code>publisher</code>,
    /// and the <code>type</code> of the add-on are returned.
    /// </summary>
    public partial class DescribeAddonVersionsRequest : AmazonEKSRequest
    {
        private string _addonName;
        private string _kubernetesVersion;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _owners = new List<string>();
        private List<string> _publishers = new List<string>();
        private List<string> _types = new List<string>();

        /// <summary>
        /// Gets and sets the property AddonName. 
        /// <para>
        /// The name of the add-on. The name must match one of the names returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListAddons.html">
        /// <code>ListAddons</code> </a>.
        /// </para>
        /// </summary>
        public string AddonName
        {
            get { return this._addonName; }
            set { this._addonName = value; }
        }

        // Check to see if AddonName property is set
        internal bool IsSetAddonName()
        {
            return this._addonName != null;
        }

        /// <summary>
        /// Gets and sets the property KubernetesVersion. 
        /// <para>
        /// The Kubernetes versions that you can use the add-on with.
        /// </para>
        /// </summary>
        public string KubernetesVersion
        {
            get { return this._kubernetesVersion; }
            set { this._kubernetesVersion = value; }
        }

        // Check to see if KubernetesVersion property is set
        internal bool IsSetKubernetesVersion()
        {
            return this._kubernetesVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned from a previous paginated <code>DescribeAddonVersionsRequest</code>
        /// where <code>maxResults</code> was used and the results exceeded the value of that
        /// parameter. Pagination continues from the end of the previous results that returned
        /// the <code>nextToken</code> value.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is used only to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Owners. 
        /// <para>
        /// The owner of the add-on. For valid <code>owners</code>, don't specify a value for
        /// this property.
        /// </para>
        /// </summary>
        public List<string> Owners
        {
            get { return this._owners; }
            set { this._owners = value; }
        }

        // Check to see if Owners property is set
        internal bool IsSetOwners()
        {
            return this._owners != null && this._owners.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Publishers. 
        /// <para>
        /// The publisher of the add-on. For valid <code>publishers</code>, don't specify a value
        /// for this property.
        /// </para>
        /// </summary>
        public List<string> Publishers
        {
            get { return this._publishers; }
            set { this._publishers = value; }
        }

        // Check to see if Publishers property is set
        internal bool IsSetPublishers()
        {
            return this._publishers != null && this._publishers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The type of the add-on. For valid <code>types</code>, don't specify a value for this
        /// property.
        /// </para>
        /// </summary>
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && this._types.Count > 0; 
        }

    }
}