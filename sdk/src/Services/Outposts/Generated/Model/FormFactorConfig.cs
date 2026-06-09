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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A supported form factor and Outpost generation configuration for an instance type.
    /// </summary>
    public partial class FormFactorConfig
    {
        private FormFactor _formFactor;
        private OutpostGeneration _outpostGeneration;

        /// <summary>
        /// Gets and sets the property FormFactor. 
        /// <para>
        /// The form factor. Valid values are <c>RACK</c> for rack-based Outposts and <c>SERVER</c>
        /// for server-based Outposts.
        /// </para>
        /// </summary>
        public FormFactor FormFactor
        {
            get { return this._formFactor; }
            set { this._formFactor = value; }
        }

        // Check to see if FormFactor property is set
        internal bool IsSetFormFactor()
        {
            return this._formFactor != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostGeneration. 
        /// <para>
        /// The Outpost generation. Valid values are <c>GENERATION_1</c> for first-generation
        /// rack deployments and <c>GENERATION_2</c> for second-generation rack deployments. This
        /// value is not set for server form factors.
        /// </para>
        /// </summary>
        public OutpostGeneration OutpostGeneration
        {
            get { return this._outpostGeneration; }
            set { this._outpostGeneration = value; }
        }

        // Check to see if OutpostGeneration property is set
        internal bool IsSetOutpostGeneration()
        {
            return this._outpostGeneration != null;
        }

    }
}