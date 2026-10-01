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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// A filter for cases. Only one value can be provided.
    /// </summary>
    public partial class CaseFilter
    {
        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Provides "and all" filtering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<CaseFilter> AndAll { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseFilter>() : null;

        /// <summary>
        /// Checks to see if the AndAll property is set.
        /// </summary>
        internal bool IsSetAndAll() => this.AndAll != null && (this.AndAll.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// A list of fields to filter on.
        /// </para>
        /// </summary>
        public FieldFilter Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Not.
        /// </summary>
        public CaseFilter Not { get; set; }

        /// <summary>
        /// Checks to see if the Not property is set.
        /// </summary>
        internal bool IsSetNot() => this.Not != null;

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Provides "or all" filtering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<CaseFilter> OrAll { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseFilter>() : null;

        /// <summary>
        /// Checks to see if the OrAll property is set.
        /// </summary>
        internal bool IsSetOrAll() => this.OrAll != null && (this.OrAll.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// A list of tags to filter on.
        /// </para>
        /// </summary>
        public TagFilter Tag { get; set; }

        /// <summary>
        /// Checks to see if the Tag property is set.
        /// </summary>
        internal bool IsSetTag() => this.Tag != null;
    }
}
