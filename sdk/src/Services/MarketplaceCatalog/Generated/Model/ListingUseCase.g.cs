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

namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// A use case from the AWS Marketplace use case taxonomy.
    /// </summary>
    public partial class ListingUseCase
    {
        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The group of the use case in the taxonomy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Group { get; set; }

        /// <summary>
        /// Checks to see if the Group property is set.
        /// </summary>
        internal bool IsSetGroup() => this.Group != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the use case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the use case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The rank of the use case. A rank of 1 is the strongest match. Valid values range from
        /// 1 to 5.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5)]
        public int? Rank { get; set; }

        /// <summary>
        /// Checks to see if the Rank property is set.
        /// </summary>
        internal bool IsSetRank() => this.Rank.HasValue;

        /// <summary>
        /// Gets and sets the property Rationale. 
        /// <para>
        /// Why this use case is recommended.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Rationale { get; set; }

        /// <summary>
        /// Checks to see if the Rationale property is set.
        /// </summary>
        internal bool IsSetRationale() => this.Rationale != null;

        /// <summary>
        /// Gets and sets the property Subgroup. 
        /// <para>
        /// The subgroup of the use case in the taxonomy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Subgroup { get; set; }

        /// <summary>
        /// Checks to see if the Subgroup property is set.
        /// </summary>
        internal bool IsSetSubgroup() => this.Subgroup != null;

        /// <summary>
        /// Gets and sets the property UseCaseDetails. 
        /// <para>
        /// How the solution serves the use case.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string UseCaseDetails { get; set; }

        /// <summary>
        /// Checks to see if the UseCaseDetails property is set.
        /// </summary>
        internal bool IsSetUseCaseDetails() => this.UseCaseDetails != null;
    }
}
