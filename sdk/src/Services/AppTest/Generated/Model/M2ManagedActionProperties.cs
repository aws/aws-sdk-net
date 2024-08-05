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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the AWS Mainframe Modernization managed action properties.
    /// </summary>
    public partial class M2ManagedActionProperties
    {
        private bool? _forceStop;
        private string _importDataSetLocation;

        /// <summary>
        /// Gets and sets the property ForceStop. 
        /// <para>
        /// Force stops the AWS Mainframe Modernization managed action properties.
        /// </para>
        /// </summary>
        public bool? ForceStop
        {
            get { return this._forceStop; }
            set { this._forceStop = value; }
        }

        // Check to see if ForceStop property is set
        internal bool IsSetForceStop()
        {
            return this._forceStop.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportDataSetLocation. 
        /// <para>
        /// The import data set location of the AWS Mainframe Modernization managed action properties.
        /// </para>
        /// </summary>
        public string ImportDataSetLocation
        {
            get { return this._importDataSetLocation; }
            set { this._importDataSetLocation = value; }
        }

        // Check to see if ImportDataSetLocation property is set
        internal bool IsSetImportDataSetLocation()
        {
            return this._importDataSetLocation != null;
        }

    }
}