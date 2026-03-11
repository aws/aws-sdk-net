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
    /// Information about automatic fail configuration for an evaluation form.
    /// </summary>
    public partial class AutomaticFailConfiguration
    {
        private string _targetSection;

        /// <summary>
        /// Gets and sets the property TargetSection. 
        /// <para>
        /// The referenceId of the target section for auto failure.
        /// </para>
        /// </summary>
        public string TargetSection
        {
            get { return this._targetSection; }
            set { this._targetSection = value; }
        }

        // Check to see if TargetSection property is set
        internal bool IsSetTargetSection()
        {
            return this._targetSection != null;
        }

    }
}