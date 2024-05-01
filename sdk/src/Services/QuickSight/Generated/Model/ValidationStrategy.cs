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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The option to relax the validation that is required to create and update analyses,
    /// dashboards, and templates with definition objects. When you set this value to <c>LENIENT</c>,
    /// validation is skipped for specific errors.
    /// </summary>
    public partial class ValidationStrategy
    {
        private ValidationStrategyMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of validation for the asset to be created or updated. When you set this value
        /// to <c>STRICT</c>, strict validation for every error is enforced. When you set this
        /// value to <c>LENIENT</c>, validation is skipped for specific UI errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationStrategyMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}