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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
        private List<string> _eq = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _gt;
        private long? _gte;
        private long? _lt;
        private long? _lte;
        private List<string> _neq = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// The value for the property matches (equals) the specified value. If you specify multiple
        /// values, Amazon Macie uses OR logic to join the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Eq
        {
            get { return this._eq; }
            set { this._eq = value; }
        }

        // Check to see if Eq property is set
        internal bool IsSetEq()
        {
            return this._eq != null && (this._eq.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        /// The value for the property is greater than the specified value.
        /// </para>
        /// </summary>
        public long? Gt
        {
            get { return this._gt; }
            set { this._gt = value; }
        }

        // Check to see if Gt property is set
        internal bool IsSetGt()
        {
            return this._gt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Gte. 
        /// <para>
        /// The value for the property is greater than or equal to the specified value.
        /// </para>
        /// </summary>
        public long? Gte
        {
            get { return this._gte; }
            set { this._gte = value; }
        }

        // Check to see if Gte property is set
        internal bool IsSetGte()
        {
            return this._gte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        /// The value for the property is less than the specified value.
        /// </para>
        /// </summary>
        public long? Lt
        {
            get { return this._lt; }
            set { this._lt = value; }
        }

        // Check to see if Lt property is set
        internal bool IsSetLt()
        {
            return this._lt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// The value for the property is less than or equal to the specified value.
        /// </para>
        /// </summary>
        public long? Lte
        {
            get { return this._lte; }
            set { this._lte = value; }
        }

        // Check to see if Lte property is set
        internal bool IsSetLte()
        {
            return this._lte.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Neq. 
        /// <para>
        /// The value for the property doesn't match (doesn't equal) the specified value. If you
        /// specify multiple values, Amazon Macie uses OR logic to join the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Neq
        {
            get { return this._neq; }
            set { this._neq = value; }
        }

        // Check to see if Neq property is set
        internal bool IsSetNeq()
        {
            return this._neq != null && (this._neq.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The name of the bucket begins with the specified value.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}