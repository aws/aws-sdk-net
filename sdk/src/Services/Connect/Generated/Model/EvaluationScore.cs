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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about scores of a contact evaluation item (section or question).
    /// </summary>
    public partial class EvaluationScore
    {
        private bool? _automaticFail;
        private bool? _notApplicable;
        private double? _percentage;

        /// <summary>
        /// Gets and sets the property AutomaticFail. 
        /// <para>
        /// The flag that marks the item as automatic fail. If the item or a child item gets an
        /// automatic fail answer, this flag will be true.
        /// </para>
        /// </summary>
        public bool? AutomaticFail
        {
            get { return this._automaticFail; }
            set { this._automaticFail = value; }
        }

        // Check to see if AutomaticFail property is set
        internal bool IsSetAutomaticFail()
        {
            return this._automaticFail.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotApplicable. 
        /// <para>
        /// The flag to mark the item as not applicable for scoring.
        /// </para>
        /// </summary>
        public bool? NotApplicable
        {
            get { return this._notApplicable; }
            set { this._notApplicable = value; }
        }

        // Check to see if NotApplicable property is set
        internal bool IsSetNotApplicable()
        {
            return this._notApplicable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        /// The score percentage for an item in a contact evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public double? Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage.HasValue; 
        }

    }
}