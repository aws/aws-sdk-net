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
    /// A view is a structure that defines a set of filters that provide a view into the information
    /// in the Amazon Web Services Resource Explorer index. The filters specify which information
    /// from the index is visible to the users of the view. For example, you can specify filters
    /// that include only resources that are tagged with the key "ENV" and the value "DEVELOPMENT"
    /// in the results returned by this view. You could also create a second view that includes
    /// only resources that are tagged with "ENV" and "PRODUCTION".
    /// </summary>
    public partial class View
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of <a>SearchFilter</a> objects that specify which resources can be included
        /// in the results of queries made using this view.
        /// </para>
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
        /// A structure that contains additional information about the view.
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
        /// The date and time when this view was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The Amazon Web Services account that owns this view.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of an Amazon Web Services account, an organization, or an
        /// organizational unit (OU) that specifies whether this view includes resources from
        /// only the specified Amazon Web Services account, all accounts in the specified organization,
        /// or all accounts in the specified OU.
        /// </para>
        ///  
        /// <para>
        /// If not specified, the value defaults to the Amazon Web Services account used to call
        /// this operation.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property ViewArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// resource name (ARN)</a> of the view.
        /// </para>
        /// </summary>
        public string ViewArn { get; set; }

        /// <summary>
        /// Checks to see if the ViewArn property is set.
        /// </summary>
        internal bool IsSetViewArn() => this.ViewArn != null;

        /// <summary>
        /// Gets and sets the property ViewName. 
        /// <para>
        /// The name of the view.
        /// </para>
        /// </summary>
        public string ViewName { get; set; }

        /// <summary>
        /// Checks to see if the ViewName property is set.
        /// </summary>
        internal bool IsSetViewName() => this.ViewName != null;
    }
}
