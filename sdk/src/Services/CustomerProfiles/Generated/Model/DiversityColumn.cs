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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Defines a diversity constraint for a single item column, specifying a cap type and
    /// a target value or placeholder that controls how many recommended items may share the
    /// same column value.
    /// </summary>
    public partial class DiversityColumn
    {
        private DiversityCapType _capType;
        private string _name;
        private string _target;

        /// <summary>
        /// Gets and sets the property CapType. 
        /// <para>
        /// The type of diversity cap to apply. Valid values are <c>PERCENTAGE</c> (interpret
        /// <c>Target</c> as a percentage of returned items) and <c>VALUE</c> (interpret <c>Target</c>
        /// as an absolute count).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DiversityCapType CapType
        {
            get { return this._capType; }
            set { this._capType = value; }
        }

        // Check to see if CapType property is set
        internal bool IsSetCapType()
        {
            return this._capType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the item catalog column on which to apply the diversity cap. The column
        /// must be defined in the recommender schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The diversity cap target. Either an integer literal (for example, <c>"25"</c>) or
        /// a placeholder expression of the form <c>$name</c> whose value is supplied at inference
        /// time through <c>GetProfileRecommendations</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}