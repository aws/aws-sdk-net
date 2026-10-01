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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Specifies the total weight for different axle group configurations. Used in regions
    /// where regulations set different weight limits based on axle group types.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>kilograms</c> 
    /// </para>
    /// </summary>
    public partial class WeightPerAxleGroup
    {
        /// <summary>
        /// Gets and sets the property Quad. 
        /// <para>
        /// Total weight in kilograms for quad (four adjacent) axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Quad { get; set; }

        /// <summary>
        /// Checks to see if the Quad property is set.
        /// </summary>
        internal bool IsSetQuad() => this.Quad.HasValue;

        /// <summary>
        /// Gets and sets the property Quint. 
        /// <para>
        /// Total weight in kilograms for quint (five adjacent) axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Quint { get; set; }

        /// <summary>
        /// Checks to see if the Quint property is set.
        /// </summary>
        internal bool IsSetQuint() => this.Quint.HasValue;

        /// <summary>
        /// Gets and sets the property Single. 
        /// <para>
        /// Total weight in kilograms for single axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Single { get; set; }

        /// <summary>
        /// Checks to see if the Single property is set.
        /// </summary>
        internal bool IsSetSingle() => this.Single.HasValue;

        /// <summary>
        /// Gets and sets the property Tandem. 
        /// <para>
        /// Total weight in kilograms for tandem (two adjacent) axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Tandem { get; set; }

        /// <summary>
        /// Checks to see if the Tandem property is set.
        /// </summary>
        internal bool IsSetTandem() => this.Tandem.HasValue;

        /// <summary>
        /// Gets and sets the property Triple. 
        /// <para>
        /// Total weight in kilograms for triple (three adjacent) axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Triple { get; set; }

        /// <summary>
        /// Checks to see if the Triple property is set.
        /// </summary>
        internal bool IsSetTriple() => this.Triple.HasValue;
    }
}
