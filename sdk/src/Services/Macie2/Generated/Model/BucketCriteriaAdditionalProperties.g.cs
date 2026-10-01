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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies the operator to use in a property-based condition that filters the results
    /// of a query for information about S3 buckets.
    /// </summary>
    public partial class BucketCriteriaAdditionalProperties
    {
        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// The value for the property matches (equals) the specified value. If you specify multiple
        /// values, Amazon Macie uses OR logic to join the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Eq { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Eq property is set.
        /// </summary>
        internal bool IsSetEq() => this.Eq != null && (this.Eq.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        /// The value for the property is greater than the specified value.
        /// </para>
        /// </summary>
        public long? Gt { get; set; }

        /// <summary>
        /// Checks to see if the Gt property is set.
        /// </summary>
        internal bool IsSetGt() => this.Gt.HasValue;

        /// <summary>
        /// Gets and sets the property Gte. 
        /// <para>
        /// The value for the property is greater than or equal to the specified value.
        /// </para>
        /// </summary>
        public long? Gte { get; set; }

        /// <summary>
        /// Checks to see if the Gte property is set.
        /// </summary>
        internal bool IsSetGte() => this.Gte.HasValue;

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        /// The value for the property is less than the specified value.
        /// </para>
        /// </summary>
        public long? Lt { get; set; }

        /// <summary>
        /// Checks to see if the Lt property is set.
        /// </summary>
        internal bool IsSetLt() => this.Lt.HasValue;

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// The value for the property is less than or equal to the specified value.
        /// </para>
        /// </summary>
        public long? Lte { get; set; }

        /// <summary>
        /// Checks to see if the Lte property is set.
        /// </summary>
        internal bool IsSetLte() => this.Lte.HasValue;

        /// <summary>
        /// Gets and sets the property Neq. 
        /// <para>
        /// The value for the property doesn't match (doesn't equal) the specified value. If you
        /// specify multiple values, Amazon Macie uses OR logic to join the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Neq { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Neq property is set.
        /// </summary>
        internal bool IsSetNeq() => this.Neq != null && (this.Neq.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The name of the bucket begins with the specified value.
        /// </para>
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;
    }
}
