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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A number filter for querying findings.
    /// </summary>
    public partial class NumberFilter
    {
        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// The equal-to condition to be applied to a single field when querying for findings.
        /// </para>
        /// </summary>
        public double? Eq { get; set; }

        /// <summary>
        /// Checks to see if the Eq property is set.
        /// </summary>
        internal bool IsSetEq() => this.Eq.HasValue;

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        ///  The greater-than condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Gt { get; set; }

        /// <summary>
        /// Checks to see if the Gt property is set.
        /// </summary>
        internal bool IsSetGt() => this.Gt.HasValue;

        /// <summary>
        /// Gets and sets the property Gte. 
        /// <para>
        /// The greater-than-equal condition to be applied to a single field when querying for
        /// findings. 
        /// </para>
        /// </summary>
        public double? Gte { get; set; }

        /// <summary>
        /// Checks to see if the Gte property is set.
        /// </summary>
        internal bool IsSetGte() => this.Gte.HasValue;

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        ///  The less-than condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Lt { get; set; }

        /// <summary>
        /// Checks to see if the Lt property is set.
        /// </summary>
        internal bool IsSetLt() => this.Lt.HasValue;

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// The less-than-equal condition to be applied to a single field when querying for findings.
        /// 
        /// </para>
        /// </summary>
        public double? Lte { get; set; }

        /// <summary>
        /// Checks to see if the Lte property is set.
        /// </summary>
        internal bool IsSetLte() => this.Lte.HasValue;
    }
}
