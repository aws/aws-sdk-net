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
    /// The failure configuration of a dataset.
    /// </summary>
    public partial class RefreshFailureConfiguration
    {
        private RefreshFailureEmailAlert _emailAlert;

        /// <summary>
        /// Gets and sets the property EmailAlert. 
        /// <para>
        /// The email alert configuration for a dataset refresh failure.
        /// </para>
        /// </summary>
        public RefreshFailureEmailAlert EmailAlert
        {
            get { return this._emailAlert; }
            set { this._emailAlert = value; }
        }

        // Check to see if EmailAlert property is set
        internal bool IsSetEmailAlert()
        {
            return this._emailAlert != null;
        }

    }
}