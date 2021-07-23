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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A placement strategy that determines how to place the tasks for the service.
    /// </summary>
    public partial class AwsEcsServicePlacementStrategiesDetails
    {
        private string _field;
        private string _type;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to apply the placement strategy against.
        /// </para>
        ///  
        /// <para>
        /// For the <code>spread</code> placement strategy, valid values are <code>instanceId</code>
        /// (or <code>host</code>, which has the same effect), or any platform or custom attribute
        /// that is applied to a container instance, such as <code>attribute:ecs.availability-zone</code>.
        /// </para>
        ///  
        /// <para>
        /// For the <code>binpack</code> placement strategy, valid values are <code>cpu</code>
        /// and <code>memory</code>.
        /// </para>
        ///  
        /// <para>
        /// For the <code>random</code> placement strategy, this attribute is not used.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of placement strategy.
        /// </para>
        ///  
        /// <para>
        /// The <code>random</code> placement strategy randomly places tasks on available candidates.
        /// </para>
        ///  
        /// <para>
        /// The <code>spread</code> placement strategy spreads placement across available candidates
        /// evenly based on the value of <code>Field</code>.
        /// </para>
        ///  
        /// <para>
        /// The <code>binpack</code> strategy places tasks on available candidates that have the
        /// least available amount of the resource that is specified in <code>Field</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>random</code> | <code>spread</code> | <code>binpack</code> 
        /// </para>
        /// </summary>
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