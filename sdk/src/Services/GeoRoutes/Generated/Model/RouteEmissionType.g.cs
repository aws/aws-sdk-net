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
    /// Type of the emission.
    /// 
    ///  
    /// <para>
    ///  <b>Valid values</b>: <c>Euro1, Euro2, Euro3, Euro4, Euro5, Euro6, EuroEev</c> 
    /// </para>
    /// </summary>
    public partial class RouteEmissionType
    {
        /// <summary>
        /// Gets and sets the property Co2EmissionClass. 
        /// <para>
        /// The CO 2 emission classes.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Co2EmissionClass { get; set; }

        /// <summary>
        /// Checks to see if the Co2EmissionClass property is set.
        /// </summary>
        internal bool IsSetCo2EmissionClass() => this.Co2EmissionClass != null;

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
        [AWSProperty(Required = true, Sensitive = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
