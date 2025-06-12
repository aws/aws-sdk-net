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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// An Amazon Web Services-managed view is how other Amazon Web Services services can
    /// access resource information indexed by Resource Explorer for your Amazon Web Services
    /// account or organization with your consent. For more information, see <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/aws-managed-views.html">Managed
    /// views</a>.
    /// </summary>
    public partial class ManagedView
    {
        private SearchFilter _filters;
        private List<IncludedProperty> _includedProperties = AWSConfigs.InitializeCollections ? new List<IncludedProperty>() : null;
        private DateTime? _lastUpdatedAt;
        private string _managedViewArn;
        private string _managedViewName;
        private string _owner;
        private string _resourcePolicy;
        private string _scope;
        private string _trustedService;
        private string _version;

        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public SearchFilter Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedProperties. 
        /// <para>
        /// A structure that contains additional information about the managed view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncludedProperty> IncludedProperties
        {
            get { return this._includedProperties; }
            set { this._includedProperties = value; }
        }

        // Check to see if IncludedProperties property is set
        internal bool IsSetIncludedProperties()
        {
            return this._includedProperties != null && (this._includedProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when this managed view was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ManagedViewArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the managed view.
        /// </para>
        /// </summary>
        public string ManagedViewArn
        {
            get { return this._managedViewArn; }
            set { this._managedViewArn = value; }
        }

        // Check to see if ManagedViewArn property is set
        internal bool IsSetManagedViewArn()
        {
            return this._managedViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedViewName. 
        /// <para>
        /// The name of the managed view. 
        /// </para>
        /// </summary>
        public string ManagedViewName
        {
            get { return this._managedViewName; }
            set { this._managedViewName = value; }
        }

        // Check to see if ManagedViewName property is set
        internal bool IsSetManagedViewName()
        {
            return this._managedViewName != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account that owns this managed view.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The resource policy that defines access to the managed view. To learn more about this
        /// policy, review <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/aws-managed-views.html">Managed
        /// views</a>.
        /// </para>
        /// </summary>
        public string ResourcePolicy
        {
            get { return this._resourcePolicy; }
            set { this._resourcePolicy = value; }
        }

        // Check to see if ResourcePolicy property is set
        internal bool IsSetResourcePolicy()
        {
            return this._resourcePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of an Amazon Web Services account or organization that specifies
        /// whether this managed view includes resources from only the specified Amazon Web Services
        /// account or all accounts in the specified organization. 
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TrustedService. 
        /// <para>
        /// The service principal of the Amazon Web Services service that created and manages
        /// the managed view. 
        /// </para>
        /// </summary>
        public string TrustedService
        {
            get { return this._trustedService; }
            set { this._trustedService = value; }
        }

        // Check to see if TrustedService property is set
        internal bool IsSetTrustedService()
        {
            return this._trustedService != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the managed view. 
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}