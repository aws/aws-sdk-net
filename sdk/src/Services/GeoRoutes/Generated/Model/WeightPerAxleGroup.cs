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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
    /// Specifies the total weight for the specified axle group. Meant for usage in countries
    /// that have different regulations based on the axle group type.
    /// 
    ///  
    /// <para>
    ///  <b>Unit</b>: <c>Kilograms</c> 
    /// </para>
    /// </summary>
    public partial class WeightPerAxleGroup
    {
        private long? _quad;
        private long? _quint;
        private long? _single;
        private long? _tandem;
        private long? _triple;

        /// <summary>
        /// Gets and sets the property Quad. 
        /// <para>
        /// Weight for quad axle group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Quad
        {
            get { return this._quad; }
            set { this._quad = value; }
        }

        // Check to see if Quad property is set
        internal bool IsSetQuad()
        {
            return this._quad.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Quint. 
        /// <para>
        /// Weight for quad quint group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Quint
        {
            get { return this._quint; }
            set { this._quint = value; }
        }

        // Check to see if Quint property is set
        internal bool IsSetQuint()
        {
            return this._quint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Single. 
        /// <para>
        /// Weight for single axle group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Single
        {
            get { return this._single; }
            set { this._single = value; }
        }

        // Check to see if Single property is set
        internal bool IsSetSingle()
        {
            return this._single.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tandem. 
        /// <para>
        /// Weight for tandem axle group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Tandem
        {
            get { return this._tandem; }
            set { this._tandem = value; }
        }

        // Check to see if Tandem property is set
        internal bool IsSetTandem()
        {
            return this._tandem.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Triple. 
        /// <para>
        /// Weight for triple axle group.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? Triple
        {
            get { return this._triple; }
            set { this._triple = value; }
        }

        // Check to see if Triple property is set
        internal bool IsSetTriple()
        {
            return this._triple.HasValue; 
        }

    }
}