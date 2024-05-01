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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about the state of the ECR scans for your environment.
    /// </summary>
    public partial class EcrConfigurationState
    {
        private EcrRescanDurationState _rescanDurationState;

        /// <summary>
        /// Gets and sets the property RescanDurationState. 
        /// <para>
        /// An object that contains details about the state of the ECR re-scan settings.
        /// </para>
        /// </summary>
        public EcrRescanDurationState RescanDurationState
        {
            get { return this._rescanDurationState; }
            set { this._rescanDurationState = value; }
        }

        // Check to see if RescanDurationState property is set
        internal bool IsSetRescanDurationState()
        {
            return this._rescanDurationState != null;
        }

    }
}