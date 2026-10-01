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
        /// <summary>
        /// Gets and sets the property Filters.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public SearchFilter Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property IncludedProperties. 
        /// <para>
        /// A structure that contains additional information about the managed view.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IncludedProperty> IncludedProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<IncludedProperty>() : null;

        /// <summary>
        /// Checks to see if the IncludedProperties property is set.
        /// </summary>
        internal bool IsSetIncludedProperties() => this.IncludedProperties != null && (this.IncludedProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The date and time when this managed view was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedViewArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the managed view.
        /// </para>
        /// </summary>
        public string ManagedViewArn { get; set; }

        /// <summary>
        /// Checks to see if the ManagedViewArn property is set.
        /// </summary>
        internal bool IsSetManagedViewArn() => this.ManagedViewArn != null;

        /// <summary>
        /// Gets and sets the property ManagedViewName. 
        /// <para>
        /// The name of the managed view. 
        /// </para>
        /// </summary>
        public string ManagedViewName { get; set; }

        /// <summary>
        /// Checks to see if the ManagedViewName property is set.
        /// </summary>
        internal bool IsSetManagedViewName() => this.ManagedViewName != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account that owns this managed view.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property ResourcePolicy. 
        /// <para>
        /// The resource policy that defines access to the managed view. To learn more about this
        /// policy, review <a href="https://docs.aws.amazon.com/resource-explorer/latest/userguide/aws-managed-views.html">Managed
        /// views</a>.
        /// </para>
        /// </summary>
        public string ResourcePolicy { get; set; }

        /// <summary>
        /// Checks to see if the ResourcePolicy property is set.
        /// </summary>
        internal bool IsSetResourcePolicy() => this.ResourcePolicy != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of an Amazon Web Services account or organization that specifies
        /// whether this managed view includes resources from only the specified Amazon Web Services
        /// account or all accounts in the specified organization. 
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TrustedService. 
        /// <para>
        /// The service principal of the Amazon Web Services service that created and manages
        /// the managed view. 
        /// </para>
        /// </summary>
        public string TrustedService { get; set; }

        /// <summary>
        /// Checks to see if the TrustedService property is set.
        /// </summary>
        internal bool IsSetTrustedService() => this.TrustedService != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the managed view. 
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
