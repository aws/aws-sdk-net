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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Identifies a built-in starter profile to use as the source when creating a data transformation
    /// profile. Valid only when the source format is Consolidated Clinical Document Architecture
    /// (C-CDA).
    /// </summary>
    public partial class StarterProfileSource
    {
        private string _starterProfileName;

        /// <summary>
        /// Gets and sets the property StarterProfileName. 
        /// <para>
        /// The name of the built-in starter profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StarterProfileName
        {
            get { return this._starterProfileName; }
            set { this._starterProfileName = value; }
        }

        // Check to see if StarterProfileName property is set
        internal bool IsSetStarterProfileName()
        {
            return this._starterProfileName != null;
        }

    }
}