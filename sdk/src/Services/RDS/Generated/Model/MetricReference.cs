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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// The reference (threshold) for a metric.
    /// </summary>
    public partial class MetricReference
    {
        private string _name;
        private ReferenceDetails _referenceDetails;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric reference.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceDetails. 
        /// <para>
        /// The details of a performance issue.
        /// </para>
        /// </summary>
        public ReferenceDetails ReferenceDetails
        {
            get { return this._referenceDetails; }
            set { this._referenceDetails = value; }
        }

        // Check to see if ReferenceDetails property is set
        internal bool IsSetReferenceDetails()
        {
            return this._referenceDetails != null;
        }

    }
}