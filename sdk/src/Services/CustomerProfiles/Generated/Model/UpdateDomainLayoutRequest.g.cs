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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDomainLayout operation. Updates the layout
    /// used to view data for a specific domain. This API can only be invoked from the Amazon
    /// Connect admin website.
    /// </summary>
    public partial class UpdateDomainLayoutRequest : AmazonCustomerProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the layout
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 1000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The display name of the layout
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// If set to true for a layout, this layout will be used by default to view data. If
        /// set to false, then the layout will not be used by default, but it can be used to view
        /// data by explicitly selecting it in the console.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// A customizable layout that can be used to view data under a Customer Profiles domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2000000)]
        public string Layout { get; set; }

        /// <summary>
        /// Checks to see if the Layout property is set.
        /// </summary>
        internal bool IsSetLayout() => this.Layout != null;

        /// <summary>
        /// Gets and sets the property LayoutDefinitionName. 
        /// <para>
        /// The unique name of the layout.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LayoutDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the LayoutDefinitionName property is set.
        /// </summary>
        internal bool IsSetLayoutDefinitionName() => this.LayoutDefinitionName != null;

        /// <summary>
        /// Gets and sets the property LayoutType. 
        /// <para>
        /// The type of layout that can be used to view data under a Customer Profiles domain.
        /// </para>
        /// </summary>
        public LayoutType LayoutType { get; set; }

        /// <summary>
        /// Checks to see if the LayoutType property is set.
        /// </summary>
        internal bool IsSetLayoutType() => this.LayoutType != null;
    }
}
