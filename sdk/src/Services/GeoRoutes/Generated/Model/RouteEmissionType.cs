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
    /// Type of the emission.
    /// 
    ///  
    /// <para>
    ///  <b>Valid values</b>: <c>Euro1, Euro2, Euro3, Euro4, Euro5, Euro6, EuroEev</c> 
    /// </para>
    /// </summary>
    public partial class RouteEmissionType
    {
        private string _co2EmissionClass;
        private string _type;

        /// <summary>
        /// Gets and sets the property Co2EmissionClass. 
        /// <para>
        /// The CO 2 emission classes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Co2EmissionClass
        {
            get { return this._co2EmissionClass; }
            set { this._co2EmissionClass = value; }
        }

        // Check to see if Co2EmissionClass property is set
        internal bool IsSetCo2EmissionClass()
        {
            return this._co2EmissionClass != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the emission.
        /// </para>
        ///  
        /// <para>
        ///  <b>Valid values</b>: <c>Euro1, Euro2, Euro3, Euro4, Euro5, Euro6, EuroEev</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}